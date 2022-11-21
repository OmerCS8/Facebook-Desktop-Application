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
        private FacebookObjectCollection<Post> m_UserPosts = null;
        private FacebookObjectCollection<Album> m_UserAlbums = null;
        private FacebookObjectCollection<Page> m_UserPages = null;
        private FacebookObjectCollection<Group> m_UserGroups = null;
        private string m_LoggedInUserName = null;
        private Image m_ProfilePicLarge = null;
        private Image m_CoverImage = null;
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
        public Image ProfilePicLarge
        {
            get
            {
                if (m_ProfilePicLarge == null && LoggedInUser != null)
                {
                    m_ProfilePicLarge = LoggedInUser.ImageLarge;
                }

                return m_ProfilePicLarge;
            }
            private set
            {
                m_ProfilePicLarge = value;
            }
        }
        public Image CoverImage
        {
            get
            {
                if (m_CoverImage == null && LoggedInUser != null)
                {
                    Album coversAlbum = UserAlbums.Find(i_Album => i_Album.Name == "Cover photos");
                    if(coversAlbum != null && coversAlbum.Photos.Count > 0)
                    {
                        m_CoverImage = coversAlbum.Photos[0].ImageNormal;
                    }
                }

                return m_CoverImage;
            }
            private set
            {
                m_CoverImage = value;
            }
        }

        public FacebookObjectCollection<Post> UserPosts
        {
            get
            {
                if(m_UserAlbums == null && LoggedInUser != null)
                {
                    m_UserPosts = LoggedInUser.Posts;
                }

                return m_UserPosts;
            }
            private set
            {
                m_UserPosts = value;
            }
        }
        public FacebookObjectCollection<Album> UserAlbums
        {
            get
            {
                if (m_UserAlbums == null && LoggedInUser != null)
                {
                    m_UserAlbums = LoggedInUser.Albums;
                }

                return m_UserAlbums;
            }
            private set
            {
                m_UserAlbums = value;
            }
        }
        public FacebookObjectCollection<Page> UserPages
        {
            get
            {
                if (m_UserPages == null && LoggedInUser != null)
                {
                    m_UserPages = LoggedInUser.LikedPages;
                }

                return m_UserPages;
            }
            private set
            {
                m_UserPages = value;
            }
        }
        public FacebookObjectCollection<Group> UserGroups
        {
            get
            {
                if (m_UserGroups == null && LoggedInUser != null)
                {
                    m_UserGroups = LoggedInUser.Groups;
                }

                return m_UserGroups;
            }
            private set
            {
                m_UserGroups = value;
            }
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
