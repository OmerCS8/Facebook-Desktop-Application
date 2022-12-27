using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.FormsUtils;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormLikedPages : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance();
        private const int k_PagePhotoSize = 100;
        private const string k_AccessDeniedMsg = "Access Denied!";
        private const string k_EmptyFieldMsg = "None";
        private Page m_SelectedPage = null;

        public FormLikedPages()
        {
            InitializeComponent();
            buttonPostInPage.BackColor = ColorsUtils.sr_ButtonsChosenColor;
            setPages();
        }

        private void setPages()
        {
            FacebookObjectCollection<Page> userPages = r_UserManager.LoggedInUserLikedPages;

            foreach (Page currentPage in userPages)
            {
                PictureBoxBorderedAndNamed pagePictureBox = new PictureBoxBorderedAndNamed(k_PagePhotoSize, true);

                try
                {
                    pagePictureBox.PictureBackgroundImage = currentPage.ImageNormal;
                }
                catch (Exception)
                {
                    pagePictureBox.PictureBackgroundImage = Properties.Resources.default_Album_Image;
                }

                pagePictureBox.PictureName = currentPage.Name;
                pagePictureBox.AddOnClickAction(this.pagePictureBox_Clicked);
                flowLayoutPanelPages.Controls.Add(pagePictureBox);
            }
        }

        private void pagePictureBox_Clicked(object i_Sender, EventArgs i_E)
        {
            if (i_Sender is PictureBoxBorderedAndNamed clickedPagePictureBox)
            {
                m_SelectedPage = r_UserManager.LoggedInUserLikedPages.Find(
                    i_Page => i_Page.Name == clickedPagePictureBox.PictureName);
                if (m_SelectedPage != null)
                {
                    buttonPostInPage.Enabled = true;
                    richTextBoxPage.Enabled = true;
                    pageBindingSource.DataSource = m_SelectedPage;
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
