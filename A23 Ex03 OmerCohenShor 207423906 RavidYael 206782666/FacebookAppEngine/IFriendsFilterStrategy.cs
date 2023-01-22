using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public interface IFriendsFilterStrategy
    {
        bool DoesFriendMatchFilter(User i_Friend);
    }
}
