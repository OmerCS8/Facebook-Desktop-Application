using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine.FriendsFilterStrategies
{
    public class StudyFilterStrategy : IFriendsFilterStrategy
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        public bool DoesFriendMatchFilter(User i_Friend)
        {
            return checkIfHaveCommonSchool(i_Friend.Educations, r_UserManager.LoggedInUserEducations);
        }

        private bool checkIfHaveCommonSchool(Education[] i_FriendEducations, Education[] i_LoggedInUserEducations)
        {
            List<Page> userSchools = i_LoggedInUserEducations.Select(i_UserEducation => i_UserEducation.School).ToList();
            List<Page> friendSchools = i_FriendEducations.Select(i_UserEducation => i_UserEducation.School).ToList();

            return (userSchools.Intersect(friendSchools)).Count() != 0;
        }

    }
}
