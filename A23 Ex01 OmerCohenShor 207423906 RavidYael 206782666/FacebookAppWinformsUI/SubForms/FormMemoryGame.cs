using FacebookAppEngine;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.FormsUtils;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormMemoryGame : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        private TimeSpan m_TimeLeft;
        private int m_PairsLeft;
        private PictureBoxCard m_PrevSelectedCard = null;
        private PictureBoxCard m_SelectedCard = null;
        private const string k_LostMsg = "You lost. Try again...?";
        private const string k_WonMsg = "You won! play again?";
        private const string k_NotEnoughPhotosMsg = "You don't have enough photos for this mode.";
        private const int k_EasyCardSize = 100;
        private const int k_MediumCardSize = 80;
        private const int k_HardCardSize = 70;

        public FormMemoryGame()
        {
            InitializeComponent();
            initializeControlsLocations();
        }

        private void initializeControlsLocations()
        {
            panelLevelButtons.Left = (panelGame.Width - panelLevelButtons.Width) / 2;
            panelLevelButtons.Top = (panelGame.Height - panelLevelButtons.Height) / 2;
            pictureBoxHeadline.Left = (panelHeader.Width - pictureBoxHeadline.Width) / 2;
            pictureBoxHeadline.Top = (panelHeader.Height - pictureBoxHeadline.Height) / 2;
            labelResult.Top = panelLevelButtons.Top - labelResult.Height - 10;
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            m_TimeLeft = new TimeSpan(0, 2, 0);
            m_PairsLeft = 6;
            prepareScreenForGame();
            new Thread((() => startGame(3, 4, k_EasyCardSize))) { IsBackground = true }.Start();
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            m_TimeLeft = new TimeSpan(0, 1, 30);
            m_PairsLeft = 10;
            prepareScreenForGame();
            new Thread((() => startGame(4, 5, k_MediumCardSize))) { IsBackground = true }.Start();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            m_TimeLeft = new TimeSpan(0, 1, 0);
            m_PairsLeft = 15;
            prepareScreenForGame();
            new Thread((() => startGame(5, 6, k_HardCardSize))) { IsBackground = true }.Start();
        }

        private void prepareScreenForGame()
        {
            panelTimer.Visible = false;
            panelLevelButtons.Visible = false;
            panelHeader.Visible = true;
            labelResult.Visible = false;
        }

        private void startGame(int i_Rows, int i_Cols, int i_CardSize)
        {
            if(r_UserManager.LoggedInUserNumberOfPhotos >= (i_Cols * i_Rows)/2)
            {
                generateCards(i_Rows, i_Cols, i_CardSize);
                labelTimer.Invoke(new Action(updateTimerLabel));
                panelTimer.Invoke(new Action(() => panelTimer.Visible = true));
                panelGame.Invoke(new Action(timerTimeLeft.Start));
            }
            else
            {
                MessageBox.Show(k_NotEnoughPhotosMsg, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generateCards(int i_Rows, int i_Cols, int i_CardSize)
        {
            List<Image> randomImages = r_UserManager.GetRandomImagesFromUserAlbums((i_Cols * i_Rows) / 2);
            PictureBoxCard cardPictureBox;

            for(int i = 0; i < i_Rows; i++)
            {
                for(int j = 0; j < i_Cols; j++)
                {
                    cardPictureBox = new PictureBoxCard(i_CardSize, i_CardSize, randomImages[i * i_Cols + j]);
                    cardPictureBox.Click += card_Clicked;
                    panelGame.Invoke(new Action(() => panelGame.Controls.Add(cardPictureBox)));
                    cardPictureBox.Invoke(new Action(
                        () => cardPictureBox.Location = new Point(j * (i_CardSize + 10) + 20, i * (i_CardSize + 10))));
                }
            }
        }

        private void card_Clicked(object i_Sender, EventArgs i_E)
        {
            if (i_Sender is PictureBoxCard selectedCard)
            {
                m_SelectedCard = selectedCard;
                selectedCard.FlipToFront();
                if(m_PrevSelectedCard == null)
                {
                    m_PrevSelectedCard = selectedCard;
                    m_PrevSelectedCard.Click -= card_Clicked;
                }
                else
                {
                    if(m_PrevSelectedCard.FrontImage == selectedCard.FrontImage)
                    {
                        setAllCardsUnClickable();
                        timerGoodPair.Start();
                    }
                    else
                    {
                        setAllCardsUnClickable();
                        timerWrongPair.Start();
                    }
                }
            }
        }

        private void timerTimeLeft_Tick(object sender, EventArgs e)
        {
            m_TimeLeft = m_TimeLeft.Subtract(TimeSpan.FromMilliseconds(timerTimeLeft.Interval));
            updateTimerLabel();
            if (m_TimeLeft <= TimeSpan.Zero)
            {
                setGameOver(k_LostMsg);
            }
        }

        private void setGameOver(string i_ResultMsg)
        {
            timerTimeLeft.Stop();
            removeAllCards();
            labelResult.Text = i_ResultMsg;
            labelResult.Visible = true;
            labelResult.Left = (panelGame.Width - labelResult.Width) / 2;
            panelLevelButtons.Visible = true;
        }

        private void updateTimerLabel()
        {
            labelTimer.Text = $"{m_TimeLeft.Minutes:00}:{m_TimeLeft.Seconds:00}";
        }

        private void timerWrongPair_Tick(object sender, EventArgs e)
        {
            timerWrongPair.Stop();
            m_PrevSelectedCard = null;
            m_SelectedCard = null;
            setAllCardsToBackAndClickable();
        }

        private void setAllCardsUnClickable()
        {
            foreach (Control panelGameControl in panelGame.Controls)
            {
                if (panelGameControl is PictureBoxCard card)
                {
                    card.Click -= card_Clicked;
                }
            }
        }

        private void setAllCardsToBackAndClickable()
        {
            foreach (Control panelGameControl in panelGame.Controls)
            {
                if (panelGameControl is PictureBoxCard card)
                {
                    card.FlipToBack();
                    card.Click += card_Clicked;
                }
            }
        }

        private void removeAllCards()
        {
            panelGame.Controls.Clear();
            panelGame.Controls.Add(panelLevelButtons);
            panelGame.Controls.Add(labelResult);
        }

        private void timerGoodPair_Tick(object sender, EventArgs e)
        {
            timerGoodPair.Stop();
            m_PairsLeft--;
            panelGame.Controls.Remove(m_PrevSelectedCard);
            panelGame.Controls.Remove(m_SelectedCard);
            m_PrevSelectedCard = null;
            m_SelectedCard = null;
            if (m_PairsLeft == 0)
            {
                setGameOver(k_WonMsg);
            }
            else
            {
                setAllCardsToBackAndClickable();
            }
        }
    }
}
