using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine.FriendsFilterStrategies
{
    public class JobFilterStrategy : IFriendsFilterStrategy
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        public bool DoesFriendMatchFilter(User i_Friend)
        {
            return checkIfHaveCommonEmployer(i_Friend.WorkExperiences, r_UserManager.LoggedInUserWorkExperiences);
        }

        private bool checkIfHaveCommonEmployer(WorkExperience[] i_FriendWorkExperiences, WorkExperience[] i_LoggedInUserWorkExperiences)
        {
            List<Page> userEmployers = i_LoggedInUserWorkExperiences.Select(i_UserExperience => i_UserExperience.Employer).ToList();
            List<Page> friendEmployers = i_FriendWorkExperiences.Select(i_UserExperience => i_UserExperience.Employer).ToList();

            return (userEmployers.Intersect(friendEmployers)).Count() != 0;
        }
    }
}
