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
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
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
                    setGroupDetails(m_SelectedGroup);
                    buttonPostInGroup.Enabled = true;
                    richTextBoxPost.Enabled = true;
                }
            }
        }

        private void setGroupDetails(Group i_SelectedGroup)
        {
            string groupName;
            string groupMembers;
            string groupPosts;
            string groupDescription;
            string groupOwner;

            try
            {
                groupName = i_SelectedGroup.Name ?? k_EmptyFieldMsg;
            }
            catch(Exception)
            {
                groupName = k_AccessDeniedMsg;
            }

            try
            {
                groupMembers = i_SelectedGroup.Members != null ? i_SelectedGroup.Members.Count.ToString() :
                                   k_EmptyFieldMsg;
            }
            catch(Exception)
            {
                groupMembers = k_AccessDeniedMsg;
            }

            try
            {
                groupPosts = i_SelectedGroup.WallPosts != null ? i_SelectedGroup.WallPosts.Count.ToString() :
                                 k_EmptyFieldMsg;
            }
            catch(Exception)
            {
                groupPosts = k_AccessDeniedMsg;
            }

            try
            {
                groupDescription = i_SelectedGroup.Description ?? k_EmptyFieldMsg;
            }
            catch(Exception)
            {
                groupDescription = k_AccessDeniedMsg;
            }

            try
            {
                groupOwner = i_SelectedGroup.Owner != null? i_SelectedGroup.Owner.Name : k_EmptyFieldMsg;
            }
            catch(Exception)
            {
                groupOwner = k_AccessDeniedMsg;
            }

            labelGroupName.Text = $"Group name: {groupName}";
            labelGroupMembers.Text = $"Group members: {groupMembers}";
            labelGroupPosts.Text = $"Group posts: {groupPosts}";
            labelGroupDescription.Text = $"Group Description: {groupDescription}";
            labelOwner.Text = $"Group Owner: {groupOwner}";
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
