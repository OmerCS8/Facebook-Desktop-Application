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
        private Group m_SelectedGroup = null;
        public FormGroups()
        {
            InitializeComponent();
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
                }
            }
        }

        private void setGroupDetails(Group i_SelectedGroup)
        {
            labelName.Text = $"Group name: {i_SelectedGroup.Name}";
        }
    }
}
