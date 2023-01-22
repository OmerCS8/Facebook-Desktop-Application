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
            bool isSameJob = false;

            if(i_FriendWorkExperiences != null && i_LoggedInUserWorkExperiences != null)
            {
                IEnumerable<Page> userEmployers =
                    i_LoggedInUserWorkExperiences.Select(i_UserExperience => i_UserExperience.Employer);
                IEnumerable<Page> friendEmployers =
                    i_FriendWorkExperiences.Select(i_UserExperience => i_UserExperience.Employer);
                isSameJob = (userEmployers.Intersect(friendEmployers)).Count() != 0;
            }

            return isSameJob;
        }
    }
}
