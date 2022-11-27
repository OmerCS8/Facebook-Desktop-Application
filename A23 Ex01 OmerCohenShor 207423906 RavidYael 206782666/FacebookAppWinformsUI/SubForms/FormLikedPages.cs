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
                    setPageDetails(m_SelectedPage);
                    buttonPostInPage.Enabled = true;
                    richTextBoxPage.Enabled = true;
                }
            }
        }

        private void setPageDetails(Page i_SelectedPage)
        {
            string pageName;
            string pageLocation;
            string pagePosts;
            string pageDescription;
            string pagePhone;

            try
            {
                pageName = i_SelectedPage.Name ?? k_EmptyFieldMsg;
            }
            catch (Exception)
            {
                pageName = k_AccessDeniedMsg;
            }

            try
            {
                pageLocation = i_SelectedPage.Location != null ? i_SelectedPage.Location.ToString() :
                                   k_EmptyFieldMsg;
            }
            catch (Exception)
            {
                pageLocation = k_AccessDeniedMsg;
            }

            try
            {
                pagePosts = i_SelectedPage.WallPosts != null ? i_SelectedPage.WallPosts.Count.ToString() :
                                 k_EmptyFieldMsg;
            }
            catch (Exception)
            {
                pagePosts = k_AccessDeniedMsg;
            }

            try
            {
                pageDescription = i_SelectedPage.Description ?? k_EmptyFieldMsg;
            }
            catch (Exception)
            {
                pageDescription = k_AccessDeniedMsg;
            }

            try
            {
                pagePhone = i_SelectedPage.Phone ??  k_EmptyFieldMsg;
            }
            catch (Exception)
            {
                pagePhone = k_AccessDeniedMsg;
            }

            labelPageName.Text = $"Page name: {pageName}";
            labelPageLocation.Text = $"Page location: {pageLocation}";
            labelPagePosts.Text = $"Page posts: {pagePosts}";
            labelPageDescription.Text = $"Page Description: {pageDescription}";
            labelPagePhone.Text = $"Page phone: {pagePhone}";
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
