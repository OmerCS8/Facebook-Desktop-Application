using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public sealed class FaceBookUserManager
    {
        private FaceBookUserManager()
        {
        }

        public static FaceBookUserManager GetFaceBookUserManagerInstance()
        {
            return sr_FaceBookUserManagerInstance;
        }

        private static readonly FaceBookUserManager sr_FaceBookUserManagerInstance = new FaceBookUserManager();
        private FacebookObjectCollection<Post> m_LoggedInUserPosts = null;
        private FacebookObjectCollection<Album> m_LoggedInUserAlbums = null;
        private FacebookObjectCollection<Page> m_LoggedInUserLikedPages = null;
        private FacebookObjectCollection<Group> m_LoggedInUserGroups = null;
        private FacebookObjectCollection<User> m_LoggedInUserFriends = null;
        private string m_LoggedInUserName = null;
        private Image m_LoggedInUserProfilePictureLarge = null;
        private Image m_LoggedInUserCoverImage = null;
        private int? m_LoggedInUserAge = null;
        private User.eGender? m_LoggedInUserGender = null;
        private string m_LoggedInUserBirthday = null;
        private string m_LoggedInUserEmail = null;
        private City m_LoggedInUserLocation = null;

        public User LoggedInUser { get; private set; }

        public bool CreateNewStatusAndReturnIfSucceeded(string i_StatusText)
        {
            bool didStatusCreationSucceed = false;
            if (LoggedInUser != null && i_StatusText != string.Empty)
            {
                LoggedInUser.PostStatus(i_StatusText);
                didStatusCreationSucceed = true;
            }

            return didStatusCreationSucceed;
        }

        public int? LoggedInUserAge
        {
            get
            {
                if (m_LoggedInUserAge == null && LoggedInUser != null)
                {
                    m_LoggedInUserAge = DateTime.Now.Year - DateTime.Parse(LoggedInUserBirthday).Year;
                }

                return m_LoggedInUserAge;
            }
        }

        public string LoggedInUserBirthday
        {
            get
            {
                if (m_LoggedInUserBirthday == null && LoggedInUser != null)
                {
                    m_LoggedInUserBirthday = LoggedInUser.Birthday;
                }

                return m_LoggedInUserBirthday;
            }
            private set
            {
                m_LoggedInUserBirthday = value;
            }
        }

        public User.eGender? LoggedInUserGender
        {
            get
            {
                if (m_LoggedInUserGender == null && LoggedInUser != null)
                {
                    m_LoggedInUserGender = LoggedInUser.Gender;
                }

                return m_LoggedInUserGender;
            }
            private set
            {
                m_LoggedInUserGender = value;
            }
        }

        public string LoggedInUserName
        {
            get
            {
                if (m_LoggedInUserName == null && LoggedInUser != null)
                {
                    m_LoggedInUserName = LoggedInUser.Name;
                }

                return m_LoggedInUserName;
            }
            private set
            {
                m_LoggedInUserName = value;
            }
        }

        public Image LoggedInUserProfilePictureLarge
        {
            get
            {
                if (m_LoggedInUserProfilePictureLarge == null && LoggedInUser != null)
                {
                    m_LoggedInUserProfilePictureLarge = LoggedInUser.ImageLarge;
                }

                return m_LoggedInUserProfilePictureLarge;
            }
            private set
            {
                m_LoggedInUserProfilePictureLarge = value;
            }
        }

        public Image LoggedInUserCoverImage
        {
            get
            {
                if (m_LoggedInUserCoverImage == null && LoggedInUser != null)
                {
                    Album coversAlbum = LoggedInUserAlbums.Find(i_Album => i_Album.Name == "Cover photos");
                    if(coversAlbum != null && coversAlbum.Photos.Count > 0)
                    {
                        m_LoggedInUserCoverImage = coversAlbum.Photos[0].ImageNormal;
                    }
                }

                return m_LoggedInUserCoverImage;
            }
            private set
            {
                m_LoggedInUserCoverImage = value;
            }
        }

        public string LoggedInUserEmail
        {
            get
            {
                if (m_LoggedInUserEmail == null && LoggedInUser != null)
                {
                    m_LoggedInUserEmail = LoggedInUser.Email;
                }

                return m_LoggedInUserEmail;
            }
            private set
            {
                m_LoggedInUserEmail = value;
            }
        }

        public City LoggedInUserLocation
        {
            get
            {
                if (m_LoggedInUserLocation == null && LoggedInUser != null)
                {
                    m_LoggedInUserLocation = LoggedInUser.Location;
                }

                return m_LoggedInUserLocation;
            }
            private set
            {
                m_LoggedInUserLocation = value;
            }
        }

        public FacebookObjectCollection<User> LoggedInUserFriends
        {
            get
            {
                if (m_LoggedInUserFriends == null && LoggedInUser != null)
                {
                    m_LoggedInUserFriends = LoggedInUser.Friends;
                }

                return m_LoggedInUserFriends;
            }
            private set
            {
                m_LoggedInUserFriends = value;
            }
        }

        public FacebookObjectCollection<Post> LoggedInUserPosts
        {
            get
            {
                if (m_LoggedInUserPosts == null && LoggedInUser != null)
                {
                    m_LoggedInUserPosts = LoggedInUser.Posts;
                }

                return m_LoggedInUserPosts;
            }
            private set
            {
                m_LoggedInUserPosts = value;
            }
        }

        public FacebookObjectCollection<Album> LoggedInUserAlbums
        {
            get
            {
                if (m_LoggedInUserAlbums == null && LoggedInUser != null)
                {
                    m_LoggedInUserAlbums = LoggedInUser.Albums;
                }

                return m_LoggedInUserAlbums;
            }
            private set
            {
                m_LoggedInUserAlbums = value;
            }
        }

        public FacebookObjectCollection<Page> LoggedInUserLikedPages
        {
            get
            {
                if (m_LoggedInUserLikedPages == null && LoggedInUser != null)
                {
                    m_LoggedInUserLikedPages = LoggedInUser.LikedPages;
                }

                return m_LoggedInUserLikedPages;
            }
            private set
            {
                m_LoggedInUserLikedPages = value;
            }
        }

        public FacebookObjectCollection<Group> LoggedInUserGroups
        {
            get
            {
                if (m_LoggedInUserGroups == null && LoggedInUser != null)
                {
                    m_LoggedInUserGroups = LoggedInUser.Groups;
                }

                return m_LoggedInUserGroups;
            }
            private set
            {
                m_LoggedInUserGroups = value;
            }
        }

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
