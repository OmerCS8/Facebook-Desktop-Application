using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public sealed class FaceBookUserManager
    {
        private static readonly FaceBookUserManager sr_FaceBookUserManagerInstance = new FaceBookUserManager();

        private FaceBookUserManager()
        {
        }

        public static FaceBookUserManager GetFaceBookUserManagerInstance()
        {
            return sr_FaceBookUserManagerInstance;
        }
        public User LoggedInUser { get; private set; }

        public bool UserLogInAndReturnIfSucceeded()
        {
            bool didLogInSucceed = false;
            LoginResult loginResult = FacebookService.Login(
                "522656449734305",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_access_member_info",
                "publish_to_groups",
                "pages_manage_posts",
                "pages_read_user_content"
            );
            if(loginResult.LoggedInUser != null)
            {
                didLogInSucceed = true;
                LoggedInUser = loginResult.LoggedInUser;
            }

            return didLogInSucceed;
        }

        public void UserLogOut()
        {
            FacebookService.Logout();
            LoggedInUser = null;
        }

    }
}
