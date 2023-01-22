using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine.FriendsFilterStrategies
{
    public class CityFilterStrategy : IFriendsFilterStrategy
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;

        public bool DoesFriendMatchFilter(User i_Friend)
        {
            bool isSameCity = false;

            if(i_Friend.Location != null && r_UserManager.LoggedInUserLocation != null)
            {
                isSameCity = i_Friend.Location == r_UserManager.LoggedInUserLocation;
            }

            return isSameCity;
        }
    }
}
