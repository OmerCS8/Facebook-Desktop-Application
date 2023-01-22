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
using FacebookAppEngine.FriendsFilterStrategies;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormGrouper : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        private const int k_PictureBoxGroupSize = 100;
        private const bool k_PictureBoxGroupHasBorder = true;
        private readonly Dictionary<PictureBoxBorderedAndNamed, IFriendsFilterStrategy> r_GroupsAndFilterStrategies;
        private readonly FriendsFilterer r_FriendsFilterer;
        private string m_CurrentGroupName;
        public FormGrouper()
        {
            InitializeComponent();
            r_GroupsAndFilterStrategies = new Dictionary<PictureBoxBorderedAndNamed, IFriendsFilterStrategy>();
            r_FriendsFilterer = new FriendsFilterer();
            initializeControlsLocations();
            initializeGroupsPictureBoxes();
        }

        private void initializeGroupsPictureBoxes()
        {
            createGroupsPictureBoxesAndFilterStrategies();
            addClickLogicToGroupPictureBoxes();
            addGroupsPictureBoxesToGroupsPanel();
        }

        private void addClickLogicToGroupPictureBoxes()
        {
            foreach(PictureBoxBorderedAndNamed groupPictureBox in r_GroupsAndFilterStrategies.Keys)
            {
                groupPictureBox.AddOnClickAction(pictureBoxGroup_Click);
            }
        }

        private void pictureBoxGroup_Click(object sender, EventArgs e)
        {
            IEnumerable<User> matchedFriends = new List<User>();

            if(sender is PictureBoxBorderedAndNamed chosenGroupPicture)
            {
                r_FriendsFilterer.FilterStrategy = r_GroupsAndFilterStrategies[chosenGroupPicture];
                matchedFriends = r_FriendsFilterer.GetMatchingFriends(r_UserManager.LoggedInUserFriends);
            }

            setUsersToCheckedListBoxMatchedUsers(matchedFriends);
            m_CurrentGroupName = (sender as PictureBoxBorderedAndNamed)?.PictureName;
        }

        private void setUsersToCheckedListBoxMatchedUsers(IEnumerable<User> i_MatchedFriends)
        {
            checkedListBoxMatchedUsers.Items.Clear();
            foreach (User user in i_MatchedFriends)
            {
                checkedListBoxMatchedUsers.Items.Add(user);
            }
        }

        private void addGroupsPictureBoxesToGroupsPanel()
        {
            foreach (PictureBoxBorderedAndNamed groupPictureBox in r_GroupsAndFilterStrategies.Keys)
            {
                flowLayoutPanelGroups.Controls.Add(groupPictureBox);
            }
        }

        private void createGroupsPictureBoxesAndFilterStrategies()
        {
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
                    {
                        PictureBackgroundImage = Properties.Resources.coworkers_logo,
                        PictureName = "Same work"
                    },
                new JobFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
                    {
                        PictureBackgroundImage = Properties.Resources.students_logo,
                        PictureName = "Same studies"
                    },
                new StudyFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
                    {
                        PictureBackgroundImage = Properties.Resources.same_age_logo,
                        PictureName = "Same age-group"
                    },
                new AgeFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
                    {
                        PictureBackgroundImage = Properties.Resources.same_team_logo,
                        PictureName = "Same favorite team"
                    },
                new TeamFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
                    {
                        PictureBackgroundImage = Properties.Resources.same_city_logo,
                        PictureName = "Same city"
                    },
                new CityFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBorderedAndNamed(k_PictureBoxGroupSize, k_PictureBoxGroupHasBorder)
                    {
                        PictureBackgroundImage = Properties.Resources.Relationship_logo,
                        PictureName = "Same status"
                    },
                new StatusFilterStrategy());
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
                FriendList friendList = r_UserManager.CreateFriendList(m_CurrentGroupName);
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
