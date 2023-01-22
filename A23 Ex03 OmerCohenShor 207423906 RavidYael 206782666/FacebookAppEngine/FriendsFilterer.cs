using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public class FriendsFilterer
    {
        public IFriendsFilterStrategy FilterStrategy { get; set; }

        public IEnumerable<User> GetMatchingFriends(IEnumerable<User> i_Friends)
        {
            return i_Friends.Where(i_User => FilterStrategy.DoesFriendMatchFilter(i_User));
        }
    }
}
