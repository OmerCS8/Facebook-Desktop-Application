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
    public partial class FormGrouper : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        private const int k_PictureBoxGroupSize = 100;
        private const bool k_PictureBoxGroupHasBorder = true;
        private PictureBoxBorderedAndNamed m_PictureBoxGroupCoworkers;
        private PictureBoxBorderedAndNamed m_PictureBoxGroupStudyTogether;
        private PictureBoxBorderedAndNamed m_PictureBoxGroupSameAge;
        private PictureBoxBorderedAndNamed m_PictureBoxGroupSameTeam;
        private PictureBoxBorderedAndNamed m_PictureBoxGroupSameCity;
        private PictureBoxBorderedAndNamed m_PictureBoxGroupSameStatus;
        private string m_CurrentGroupName = null;

        public FormGrouper()
        {
            InitializeComponent();
            initializeControlsLocations();
            initializeGroupsPictureBoxes();
        }

        private void initializeGroupsPictureBoxes()
        {
            createGroupsPictureBoxes();
            addClickLOgicToGroupPictureBoxes();
            addGroupsPictureBoxesToGroupsPanel();
        }

        private void addClickLOgicToGroupPictureBoxes()
        {
            m_PictureBoxGroupSameTeam.Click += pictureBoxGroupSameTeam_Click;
            m_PictureBoxGroupStudyTogether.Click += pictureBoxGroupStudyTogether_Click;
            m_PictureBoxGroupSameStatus.Click += pictureBoxGroupSameStatus_Click;
            m_PictureBoxGroupSameCity.Click += pictureBoxGroupSameCity_Click;
            m_PictureBoxGroupSameAge.Click += pictureBoxGroupSameAge_Click;
            m_PictureBoxGroupCoworkers.Click += pictureBoxGroupCoworkers_Click;
        }

        private void pictureBoxGroupCoworkers_Click(object sender, EventArgs e)
        {
            List<User> matchedFriends = r_UserManager.LoggedInUser.Friends.Where(
                user => checkIfHaveCommonEmployer(user.WorkExperiences, r_UserManager.LoggedInUserWorkExperiences)).ToList();

            setUsersToCheckedListBoxMatchedUsers(matchedFriends);
            m_CurrentGroupName = (sender as PictureBoxBorderedAndNamed)?.PictureName;
        }

        private void pictureBoxGroupSameAge_Click(object sender, EventArgs e)
        {
            List<User> matchedFriends = r_UserManager.LoggedInUser.Friends.Where(
                user => checkIfInSameAgeGroup(user.Birthday, r_UserManager.LoggedInUserBirthday)).ToList();

            setUsersToCheckedListBoxMatchedUsers(matchedFriends);
            m_CurrentGroupName = (sender as PictureBoxBorderedAndNamed)?.PictureName;
        }

        private void pictureBoxGroupSameCity_Click(object sender, EventArgs e)
        {
            List<User> matchedFriends = r_UserManager.LoggedInUser.Friends.Where(
                user => user.Location == r_UserManager.LoggedInUserLocation).ToList();

            setUsersToCheckedListBoxMatchedUsers(matchedFriends);
            m_CurrentGroupName = (sender as PictureBoxBorderedAndNamed)?.PictureName;
        }

        private void pictureBoxGroupSameStatus_Click(object sender, EventArgs e)
        {
            List<User> matchedFriends = r_UserManager.LoggedInUser.Friends.Where(
                user => user.RelationshipStatus == r_UserManager.LoggedInUserRelationshipStatus).ToList();

            setUsersToCheckedListBoxMatchedUsers(matchedFriends);
            m_CurrentGroupName = (sender as PictureBoxBorderedAndNamed)?.PictureName;
        }

        private void pictureBoxGroupStudyTogether_Click(object sender, EventArgs e)
        {
            List<User> matchedFriends = r_UserManager.LoggedInUser.Friends.Where(
                user => checkIfHaveCommonSchool(user.Educations, r_UserManager.LoggedInUserEducations)).ToList();

            setUsersToCheckedListBoxMatchedUsers(matchedFriends);
            m_CurrentGroupName = (sender as PictureBoxBorderedAndNamed)?.PictureName;
        }

        private void pictureBoxGroupSameTeam_Click(object sender, EventArgs e)
        {
            List<User> matchedFriends = r_UserManager.LoggedInUser.Friends.Where(
                user => checkIfHaveCommonFavoriteTeam(user.FavofriteTeams, r_UserManager.LoggedInUserFavoritesTeams)).ToList();

            setUsersToCheckedListBoxMatchedUsers(matchedFriends);
            m_CurrentGroupName = (sender as PictureBoxBorderedAndNamed)?.PictureName;
        }
        
        private bool checkIfHaveCommonSchool(Education[] i_FriendEducations, Education[] i_LoggedInUserEducations)
        {
            List<Page> userSchools = i_LoggedInUserEducations.Select(userEducation => userEducation.School).ToList();
            List<Page> friendSchools = i_FriendEducations.Select(userEducation => userEducation.School).ToList();

            return (userSchools.Intersect(friendSchools)).Count() != 0;
        }
       
        private bool checkIfInSameAgeGroup(string i_FriendBirthday, string i_LoggedInUserBirthday)
        {
            int friendBirthYear = DateTime.Parse(i_FriendBirthday).Year;
            int loggedInUserBirthYear = DateTime.Parse(i_LoggedInUserBirthday).Year;

            return Math.Abs(friendBirthYear - loggedInUserBirthYear) <= 3;
        }

        private bool checkIfHaveCommonEmployer(WorkExperience[] i_FriendWorkExperiences, WorkExperience[] i_LoggedInUserWorkExperiences)
        {
            List<Page> userEmployers = i_LoggedInUserWorkExperiences.Select(userExperience => userExperience.Employer).ToList();
            List<Page> friendEmployers = i_FriendWorkExperiences.Select(userExperience => userExperience.Employer).ToList();

            return (userEmployers.Intersect(friendEmployers)).Count() != 0;
        }

        private bool checkIfHaveCommonFavoriteTeam(Page[] i_FriendFavofriteTeams, Page[] i_LoggedInUserFavoritesTeams)
        {
            return (i_FriendFavofriteTeams.Intersect(i_LoggedInUserFavoritesTeams)).Count() != 0;
        }

        private void setUsersToCheckedListBoxMatchedUsers(List<User> i_matchedFriends)
        {
            checkedListBoxMatchedUsers.Items.Clear();
            foreach (User user in i_matchedFriends)
            {
                checkedListBoxMatchedUsers.Items.Add(user);
            }
        }

        private void addGroupsPictureBoxesToGroupsPanel()
        {
            flowLayoutPanelGroups.Controls.Add(m_PictureBoxGroupSameStatus);
            flowLayoutPanelGroups.Controls.Add(m_PictureBoxGroupCoworkers);
            flowLayoutPanelGroups.Controls.Add(m_PictureBoxGroupSameAge);
            flowLayoutPanelGroups.Controls.Add(m_PictureBoxGroupSameCity);
            flowLayoutPanelGroups.Controls.Add(m_PictureBoxGroupStudyTogether);
            flowLayoutPanelGroups.Controls.Add(m_PictureBoxGroupSameTeam);
        }

        private void createGroupsPictureBoxes()
        {
            m_PictureBoxGroupCoworkers = new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
            {
                PictureBackgroundImage = Properties.Resources.coworkers_logo,
                PictureName = "Same work"
            };
            m_PictureBoxGroupStudyTogether = new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
            {
                PictureBackgroundImage = Properties.Resources.students_logo,
                PictureName = "Same studies"
            };
            m_PictureBoxGroupSameAge = new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
            {
                PictureBackgroundImage = Properties.Resources.same_age_logo,
                PictureName = "Same age-group"
            };
            m_PictureBoxGroupSameTeam = new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
            {
                PictureBackgroundImage = Properties.Resources.same_team_logo,
                PictureName = "Same favorite team"
            };
            m_PictureBoxGroupSameCity = new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
            {
                PictureBackgroundImage = Properties.Resources.same_city_logo,
                PictureName = "Same city"
            };
            m_PictureBoxGroupSameStatus = new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
            {
                PictureBackgroundImage = Properties.Resources.Relationship_logo,
                PictureName = "Same status"
            };
        }

        private void initializeControlsLocations()
        {
            pictureBoxHeadline.Left = (panelHeader.Width - pictureBoxHeadline.Width) / 2;
            pictureBoxHeadline.Top = (panelHeader.Height - pictureBoxHeadline.Height) / 2;
        }

        private void buttonCrateGroup_Click(object sender, EventArgs e)
        {
            List<User> chosenUsersToFriendlist = checkedListBoxMatchedUsers.CheckedItems.OfType<User>().ToList();

            if (chosenUsersToFriendlist.Count() != 0)
            {
                FriendList friendList = r_UserManager.LoggedInUser.CreateFriendList(m_CurrentGroupName);
                friendList.AddMemeber(chosenUsersToFriendlist);
            }
            else
            {
                MessageBox.Show("Can not add an empty friend list!", "Empty friend-list",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
