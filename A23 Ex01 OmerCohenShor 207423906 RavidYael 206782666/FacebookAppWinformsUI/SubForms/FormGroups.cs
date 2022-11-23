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
        private readonly int r_GroupPhotoSize = 100;
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        private readonly string r_AccessDeniedMSG = "Access Denied!";
        private readonly string r_EmptyFieldMSG = "None";
        private Group m_SelectedGroup = null;
        public FormGroups()
        {
            InitializeComponent();
            buttonPostInGroup.BackColor = ColorsUtils.sr_ButtonsDefaultColor;
            setGroups();
        }

        private void setGroups()
        {
            FacebookObjectCollection<Group> userGroups = r_UserManager.LoggedInUserGroups;
            foreach (Group currentGroup in userGroups)
            {
                PictureBoxBorderedAndNamed groupPictureBox = new PictureBoxBorderedAndNamed(r_GroupPhotoSize, true);
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
                groupName = i_SelectedGroup.Name ?? r_EmptyFieldMSG;
            }
            catch(Exception)
            {
                groupName = r_AccessDeniedMSG;
            }

            try
            {
                groupMembers = i_SelectedGroup.Members != null ? i_SelectedGroup.Members.Count.ToString() :
                                   r_EmptyFieldMSG;
            }
            catch(Exception)
            {
                groupMembers = r_AccessDeniedMSG;
            }

            try
            {
                groupPosts = i_SelectedGroup.WallPosts != null ? i_SelectedGroup.WallPosts.Count.ToString() :
                                 r_EmptyFieldMSG;
            }
            catch(Exception)
            {
                groupPosts = r_AccessDeniedMSG;
            }

            try
            {
                groupDescription = i_SelectedGroup.Description ?? r_EmptyFieldMSG;
            }
            catch(Exception)
            {
                groupDescription = r_AccessDeniedMSG;
            }

            try
            {
                groupOwner = i_SelectedGroup.Owner != null? i_SelectedGroup.Owner.Name : r_EmptyFieldMSG;
            }
            catch(Exception)
            {
                groupOwner = r_AccessDeniedMSG;
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
                    MessageBox.Show(exception.Message, "Error accured", 
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
