using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine.FriendsFilterStrategies
{
    public class StatusFilterStrategy : IFriendsFilterStrategy
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;

        public bool DoesFriendMatchFilter(User i_Friend)
        {
            bool isSameStatus = false;

            if(i_Friend.RelationshipStatus != null && r_UserManager.LoggedInUserRelationshipStatus != null)
            {
                isSameStatus = i_Friend.RelationshipStatus == r_UserManager.LoggedInUserRelationshipStatus;
            }

            return isSameStatus;
        }
    }
}
