using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookAppEngine;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormGrouper : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        public FormGrouper()
        {
            InitializeComponent();
            initializeControlsLocations();
            initializeGroupsPictureBoxes();
        }

        private void initializeGroupsPictureBoxes()
        {
            pictureBoxGroupCoworkers.PictureBackgroundImage = Properties.Resources.coworkers_logo;
            pictureBoxGroupCoworkers.PictureName = "Same work";
            pictureBoxGroupStudyTogether.PictureBackgroundImage = Properties.Resources.students_logo;
            pictureBoxGroupStudyTogether.PictureName = "Same studies";
            pictureBoxGroupSameAge.PictureBackgroundImage = Properties.Resources.same_age_logo;
            pictureBoxGroupSameAge.PictureName = "Same age-group";
            pictureBoxGroupSameTeam.PictureBackgroundImage = Properties.Resources.same_team_logo;
            pictureBoxGroupSameTeam.PictureName = "Same favorite team";
            pictureBoxGroupSameCity.PictureBackgroundImage = Properties.Resources.same_city_logo;
            pictureBoxGroupSameCity.PictureName = "Same city";
            pictureBoxGroupSameStatus.PictureBackgroundImage = Properties.Resources.Relationship_logo;
            pictureBoxGroupSameStatus.PictureName = "Same status";
        }

        private void initializeControlsLocations()
        {
            pictureBoxHeadline.Left = (panelHeader.Width - pictureBoxHeadline.Width) / 2;
            pictureBoxHeadline.Top = (panelHeader.Height - pictureBoxHeadline.Height) / 2;
        }
    }
}
