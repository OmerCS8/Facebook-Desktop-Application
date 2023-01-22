using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine.FriendsFilterStrategies
{
    public class TeamFilterStrategy : IFriendsFilterStrategy
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        public bool DoesFriendMatchFilter(User i_Friend)
        {
            return checkIfHaveCommonFavoriteTeam(i_Friend.FavofriteTeams, r_UserManager.LoggedInUserFavoritesTeams);
        }

        private bool checkIfHaveCommonFavoriteTeam(Page[] i_FriendFavoriteTeams, Page[] i_LoggedInUserFavoritesTeams)
        {
            return (i_FriendFavoriteTeams.Intersect(i_LoggedInUserFavoritesTeams)).Count() != 0;
        }

    }
}
