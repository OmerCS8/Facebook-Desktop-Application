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
        private readonly Dictionary<PictureBoxBordered, IFriendsFilterStrategy> r_GroupsAndFilterStrategies;
        private readonly FriendsFilterer r_FriendsFilterer;
        private string m_CurrentGroupName;
        public FormGrouper()
        {
            InitializeComponent();
            r_GroupsAndFilterStrategies = new Dictionary<PictureBoxBordered, IFriendsFilterStrategy>();
            r_FriendsFilterer = new FriendsFilterer();
            pictureBoxHeadline.Left = (panelHeader.Width - pictureBoxHeadline.Width) / 2;
            pictureBoxHeadline.Top = (panelHeader.Height - pictureBoxHeadline.Height) / 2;
            initializeGroupsPictureBoxes();
        }

        private void initializeGroupsPictureBoxes()
        {
            createGroupsPictureBoxesAndFilterStrategies();
            foreach (PictureBoxBordered groupPictureBox in r_GroupsAndFilterStrategies.Keys)
            {
                groupPictureBox.Click += pictureBoxGroup_Click;
                flowLayoutPanelGroups.Controls.Add(groupPictureBox);
            }
        }

        private void pictureBoxGroup_Click(object sender, EventArgs e)
        {
            IEnumerable<User> matchedFriends;

            if (sender is PictureBoxBordered chosenGroupPicture)
            {
                r_FriendsFilterer.FilterStrategy = r_GroupsAndFilterStrategies[chosenGroupPicture];
                matchedFriends = r_FriendsFilterer.GetMatchingFriends(r_UserManager.LoggedInUserFriends);
                setUsersToCheckedListBoxMatchedUsers(matchedFriends);
                if(chosenGroupPicture.InnerPictureBox is PictureBoxNamed innerPicture)
                {
                    m_CurrentGroupName = innerPicture.PictureName;
                }
            }
        }

        private void setUsersToCheckedListBoxMatchedUsers(IEnumerable<User> i_MatchedFriends)
        {
            checkedListBoxMatchedUsers.Items.Clear();
            foreach (User user in i_MatchedFriends)
            {
                checkedListBoxMatchedUsers.Items.Add(user);
            }
        }

        private void createGroupsPictureBoxesAndFilterStrategies()
        {
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBordered(
                    new PictureBoxNamed(
                        new PictureBox() { BackgroundImage = Properties.Resources.coworkers_logo },
                        "Same job")),
                new JobFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBordered(
                    new PictureBoxNamed(
                        new PictureBox() { BackgroundImage = Properties.Resources.students_logo },
                        "Same studies")),
                new StudyFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBordered(
                    new PictureBoxNamed(
                        new PictureBox() { BackgroundImage = Properties.Resources.same_age_logo },
                        "Same age-group")),
                new AgeFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBordered(
                    new PictureBoxNamed(
                        new PictureBox() { BackgroundImage = Properties.Resources.same_team_logo },
                        "Same favorite team")),
                new TeamFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBordered(
                    new PictureBoxNamed(
                        new PictureBox() { BackgroundImage = Properties.Resources.same_city_logo },
                        "Same city")),
                new CityFilterStrategy());
            r_GroupsAndFilterStrategies.Add(
                new PictureBoxBordered(
                    new PictureBoxNamed(
                        new PictureBox() { BackgroundImage = Properties.Resources.Relationship_logo },
                        "Same status")),
                new StatusFilterStrategy());
        }

        private void buttonCrateGroup_Click(object sender, EventArgs e)
        {
            List<User> chosenUsersToFriendList = checkedListBoxMatchedUsers.CheckedItems.OfType<User>().ToList();

            if (chosenUsersToFriendList.Any())
            {
                try
                {
                    FriendList friendList = r_UserManager.CreateFriendList(m_CurrentGroupName);
                    friendList.AddMemeber(chosenUsersToFriendList);
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Could not create the friend list!", "permissions Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can not add an empty friend list!", "Empty friend-list",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
