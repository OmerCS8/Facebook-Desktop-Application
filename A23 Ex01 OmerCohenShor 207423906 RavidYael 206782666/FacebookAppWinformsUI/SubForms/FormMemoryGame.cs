using FacebookAppEngine;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormMemoryGame : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        private TimeSpan m_timeLeft;
        private readonly Random m_RandomMaker = new Random();
        private const string k_LostMsg = "You lost. Try again...?";
        private const string k_WonMsg = "You won! play again?";
        private const int k_EasyCardSize = 100;
        private const int k_MediumCardSize = 80;
        private const int k_HardCardSize = 70;

        public FormMemoryGame()
        {
            InitializeComponent();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            m_timeLeft = new TimeSpan(0, 2, 0);
            startGame(3, 4 , k_EasyCardSize);
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            m_timeLeft = new TimeSpan(0, 1, 30);
            startGame(4, 5, k_MediumCardSize);
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            m_timeLeft = new TimeSpan(0, 1, 0);
            startGame(5, 6, k_HardCardSize);
        }
        private void startGame(int i_Rows, int i_Cols, int i_CardSize)
        {
            panelLevelButtons.Visible = false;
            panelTimer.Visible = true;
            labelResult.Visible = false;
            updateTimerLabel();
            timerTimeLeft.Start();
            generateCards(i_Rows, i_Cols, i_CardSize);
        }

        private void generateCards(int i_Rows, int i_Cols, int i_CardSize)
        {
            List<Image> randomImages = getRandomImagesFromUserAlbums((i_Cols * i_Rows) / 2);

            for(int i = 0; i < i_Rows; i++)
            {
                for(int j = 0; j < i_Cols; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(i_CardSize, i_CardSize);
                    pictureBox.BackgroundImage = randomImages[i * i_Cols + j];
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    panelGame.Controls.Add(pictureBox);
                    pictureBox.Location = new Point(j * (i_CardSize + 10) + 20, i * (i_CardSize + 10));
                } 
            }
        }

        private List<Image> getRandomImagesFromUserAlbums(int i_ImageNumber)
        {
            FacebookObjectCollection<Album> userAlbums = r_UserManager.LoggedInUserAlbums;
            List<Image> randomImages = new List<Image>();
            Album chosenAlbum;
            Image chosenPhotoImage;


            for (int i = 0; i < i_ImageNumber; i++)
            {
                chosenAlbum = userAlbums[m_RandomMaker.Next(userAlbums.Count)];
                if (chosenAlbum.Photos.Count == 0)
                {
                    i--;
                    continue;
                }
                chosenPhotoImage = (chosenAlbum.Photos[m_RandomMaker.Next(chosenAlbum.Photos.Count)].ImageNormal);
                if (randomImages.Contains(chosenPhotoImage))
                {
                    i--;
                }
                else
                {
                    randomImages.Add(chosenPhotoImage);
                    randomImages.Add(chosenPhotoImage);
                }
            }

            return randomImages.OrderBy(i_Image => m_RandomMaker.Next()).ToList();
        }

        private void timerTimeLeft_Tick(object sender, EventArgs e)
        {
            m_timeLeft = m_timeLeft.Subtract(TimeSpan.FromMilliseconds(timerTimeLeft.Interval));
            updateTimerLabel();
            if (m_timeLeft <= TimeSpan.Zero)
            {
                setGameOver("You lost. Try again...?");
            }
        }

        private void setGameOver(string i_ResultMsg)
        {
            timerTimeLeft.Stop();
            labelResult.Text = i_ResultMsg;
            labelResult.Visible = true;
            panelLevelButtons.Visible = true;
        }

        private void updateTimerLabel()
        {
            labelTimer.Text = $"{m_timeLeft.Minutes}:{m_timeLeft.Seconds}";
        }
    }
}
