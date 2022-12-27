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
    public partial class FormGroups : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance();
        private const int k_GroupPhotoSize = 100;
        private const string k_AccessDeniedMsg = "Access Denied!";
        private const string k_EmptyFieldMsg = "None";
        private Group m_SelectedGroup = null;

        public FormGroups()
        {
            InitializeComponent();
            buttonPostInGroup.BackColor = ColorsUtils.sr_ButtonsChosenColor;
            setGroups();
        }

        private void setGroups()
        {
            FacebookObjectCollection<Group> userGroups = r_UserManager.LoggedInUserGroups;

            foreach (Group currentGroup in userGroups)
            {
                PictureBoxBorderedAndNamed groupPictureBox = new PictureBoxBorderedAndNamed(k_GroupPhotoSize, true);

                try
                {
                    groupPictureBox.PictureBackgroundImage = currentGroup.ImageNormal;
                }
                catch (Exception)
                {
                    groupPictureBox.PictureBackgroundImage = Properties.Resources.default_Album_Image;
                }

                groupPictureBox.PictureName = currentGroup.Name;
                groupPictureBox.AddOnClickAction(this.groupPictureBox_Clicked);
                flowLayoutPanelGroups.Controls.Add(groupPictureBox);
            }
        }

        private void groupPictureBox_Clicked(object i_Sender, EventArgs i_E)
        {
            if (i_Sender is PictureBoxBorderedAndNamed clickedGroupPictureBox)
            {
                m_SelectedGroup = r_UserManager.LoggedInUserGroups.Find(
                    i_Group => i_Group.Name == clickedGroupPictureBox.PictureName);
                if (m_SelectedGroup != null)
                {
                    buttonPostInGroup.Enabled = true;
                    richTextBoxPost.Enabled = true;
                    groupBindingSource.DataSource = m_SelectedGroup;
                }
            }
        }

        private void buttonPostInGroup_Click(object sender, EventArgs e)
        {
            if(richTextBoxPost.TextLength > 0)
            {
                try
                {
                    m_SelectedGroup?.PostToWall(richTextBoxPost.Text);
                    richTextBoxPost.Clear();
                    MessageBox.Show("Post was created", "post succeeded", 
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch(Exception exception)
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
