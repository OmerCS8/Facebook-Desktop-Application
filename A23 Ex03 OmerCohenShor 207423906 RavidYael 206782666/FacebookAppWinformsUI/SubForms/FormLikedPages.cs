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
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormLikedPages : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        private const int k_PagePhotoSize = 100;
        private const string k_AccessDeniedMsg = "Access Denied!";
        private Page m_SelectedPage = null;

        public FormLikedPages()
        {
            InitializeComponent();
            buttonPostInPage.BackColor = ColorsUtils.sr_ButtonsChosenColor;
            new Thread(setPages) { IsBackground = true }.Start();
        }

        private void setPages()
        {
            FacebookObjectCollection<Page> userPages = r_UserManager.LoggedInUserLikedPages;

            foreach (Page currentPage in userPages)
            {
                PictureBox pagePictureBox = new PictureBox() { Size = new Size(k_PagePhotoSize, k_PagePhotoSize) };
                PictureBoxBordered pageCoverPictureBox;

                try
                {
                    pagePictureBox.BackgroundImage = currentPage.ImageNormal;
                }
                catch (Exception)
                {
                    pagePictureBox.BackgroundImage = Properties.Resources.default_Album_Image;
                }

                pageCoverPictureBox = new PictureBoxBordered(new PictureBoxNamed(pagePictureBox, currentPage.Name));
                pageCoverPictureBox.Click += pagePictureBox_Clicked;
                flowLayoutPanelPages.Invoke(new Action(() => flowLayoutPanelPages.Controls.Add(pageCoverPictureBox)));
            }
        }

        private void pagePictureBox_Clicked(object i_Sender, EventArgs i_E)
        {
            if (i_Sender is PictureBoxBordered clickedGroupPictureBox)
            {
                if (clickedGroupPictureBox.InnerPictureBox is PictureBoxNamed clickedInnerPictureBox)
                {
                    m_SelectedPage = r_UserManager.LoggedInUserLikedPages.Find(
                        i_Page => i_Page.Name == clickedInnerPictureBox.PictureName);
                    if (m_SelectedPage != null)
                    {
                        buttonPostInPage.Enabled = true;
                        richTextBoxPage.Enabled = true;
                        pageBindingSource.DataSource = m_SelectedPage;
                    }
                }
            }
        }

        private void buttonPostInPage_Click(object sender, EventArgs e)
        {
            if (richTextBoxPage.TextLength > 0)
            {
                try
                {
                    m_SelectedPage?.PostStatus(richTextBoxPage.Text);
                    richTextBoxPage.Clear();
                    MessageBox.Show("Post was created", "post succeeded",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, k_AccessDeniedMsg,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Can not post an empty post!", "Empty post",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
