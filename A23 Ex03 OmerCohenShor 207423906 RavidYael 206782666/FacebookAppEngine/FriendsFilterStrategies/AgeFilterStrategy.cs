using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine.FriendsFilterStrategies
{
    public class AgeFilterStrategy : IFriendsFilterStrategy
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;

        public bool DoesFriendMatchFilter(User i_Friend)
        {
            return checkIfInSameAgeGroup(i_Friend.Birthday, r_UserManager.LoggedInUserBirthday);
        }

        private bool checkIfInSameAgeGroup(string i_FriendBirthday, string i_LoggedInUserBirthday)
        {
            int friendBirthYear = DateTime.Parse(i_FriendBirthday).Year;
            int loggedInUserBirthYear = DateTime.Parse(i_LoggedInUserBirthday).Year;

            return Math.Abs(friendBirthYear - loggedInUserBirthYear) <= 3;
        }
    }

}
