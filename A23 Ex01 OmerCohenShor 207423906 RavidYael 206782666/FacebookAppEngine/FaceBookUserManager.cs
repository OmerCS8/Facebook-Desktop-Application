using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        public static FaceBookUserManager Instance()
        {
            return sr_FaceBookUserManagerInstance;
        }

        private static readonly FaceBookUserManager sr_FaceBookUserManagerInstance = new FaceBookUserManager();
        private readonly AppSettings r_UserAppSettings = AppSettings.LoadAppSettingsFromFileOrCreateIfDoesNotExist();
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
        private long? m_LoggedInUserNumberOfPhotos = null;
        private WorkExperience[] m_LoggedInUserWorkExperiences = null;
        private Page[] m_LoggedInUserFavoritesTeams = null;
        private User.eRelationshipStatus? m_LoggedInUserRelationshipStatus = null;
        private Education[] m_LoggedInUserEducations = null;

        public User LoggedInUser { get; private set; }

        public bool DoesUserWantToRememberHim
        {
            get
            {
                return r_UserAppSettings.DoesUserWantToRememberHim;
            }
            set
            {
                r_UserAppSettings.DoesUserWantToRememberHim = value;
            }
        }

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

        public bool UserLogInAndReturnIfSucceeded()
        {
            bool didLogInSucceed = false;
            LoginResult loginResult = null;

            loginResult = FacebookService.Login(
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
                "pages_read_user_content");

            if (loginResult.LoggedInUser != null)
            {
                didLogInSucceed = true;
                LoggedInUser = loginResult.LoggedInUser;
                r_UserAppSettings.UserAccessToken = loginResult.AccessToken;
            }

            return didLogInSucceed;
        }

        public bool TryLogInIfUserIsRememberedAndReturnIfSucceeded()
        {
            LoginResult loginResult = null;
            bool didLogInSucceed = false;

            if (r_UserAppSettings.DoesUserWantToRememberHim && !string.IsNullOrEmpty(r_UserAppSettings.UserAccessToken))
            {
                loginResult = FacebookService.Connect(r_UserAppSettings.UserAccessToken);
                if (loginResult.LoggedInUser != null)
                {
                    didLogInSucceed = true;
                    LoggedInUser = loginResult.LoggedInUser;
                }
            }

            return didLogInSucceed;
        }

        public void UserLogOut()
        {
            FacebookService.Logout();
            r_UserAppSettings.UserAccessToken = null;
            clearCache();
        }

        private void clearCache()
        {
            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                if (propertyInfo.SetMethod.IsPrivate && Nullable.GetUnderlyingType(propertyInfo.PropertyType) != null)
                {
                    propertyInfo.SetValue(this, null);
                }
            }
        }

        public void SaveSettingsChanges()
        {
            r_UserAppSettings.SaveAppSettingsToFile();
        }

        public List<Image> GetRandomImagesFromUserAlbums(int i_NumberOfImages)
        {
            FacebookObjectCollection<Album> userAlbums = LoggedInUserAlbums;
            List<Image> randomImages = new List<Image>();
            Album chosenAlbum;
            Image chosenPhotoImage;
            Random randomMaker = new Random();

            for (int i = 0; i < i_NumberOfImages; i++)
            {
                chosenAlbum = userAlbums[randomMaker.Next(userAlbums.Count)];
                if (chosenAlbum.Photos.Count == 0)
                {
                    i--;
                }
                else
                {
                    chosenPhotoImage = (chosenAlbum.Photos[randomMaker.Next(chosenAlbum.Photos.Count)].ImageNormal);
                    if (randomImages.Contains(chosenPhotoImage))
                    {
                        i--;
                    }
                    else
                    {
                        randomImages.Add(chosenPhotoImage);
                        randomImages.Add(chosenPhotoImage);
                    }
                }
            }

            return randomImages.OrderBy(i_Image => randomMaker.Next()).ToList();
        }

        //-------------------------------------------Cached properties---------------------------------------

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
            private set
            {
                m_LoggedInUserAge = value;
            }
        }

        public WorkExperience[] LoggedInUserWorkExperiences
        {
            get
            {
                if (m_LoggedInUserWorkExperiences == null && LoggedInUser != null)
                {
                    m_LoggedInUserWorkExperiences = LoggedInUser.WorkExperiences;
                }

                return m_LoggedInUserWorkExperiences;
            }
            private set
            {
                m_LoggedInUserWorkExperiences = value;
            }
        }
        
        public Page[] LoggedInUserFavoritesTeams
        {
            get
            {
                if (m_LoggedInUserFavoritesTeams == null && LoggedInUser != null)
                {
                    m_LoggedInUserFavoritesTeams = LoggedInUser.FavofriteTeams;
                }

                return m_LoggedInUserFavoritesTeams;
            }
            private set
            {
                m_LoggedInUserFavoritesTeams = value;
            }
        }
        
        public long? LoggedInUserNumberOfPhotos
        {
            get
            {
                if (m_LoggedInUserNumberOfPhotos == null && LoggedInUser != null)
                {
                    m_LoggedInUserNumberOfPhotos = 0;
                    foreach(Album album in LoggedInUserAlbums)
                    {
                        m_LoggedInUserNumberOfPhotos += album.Count;
                    }
                }

                return m_LoggedInUserNumberOfPhotos;
            }
            private set
            {
                m_LoggedInUserNumberOfPhotos = value;
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

        public User.eRelationshipStatus? LoggedInUserRelationshipStatus 
        {
            get
            {
                if (m_LoggedInUserRelationshipStatus == null && LoggedInUser != null)
                {
                    m_LoggedInUserRelationshipStatus = LoggedInUser.RelationshipStatus;
                }

                return m_LoggedInUserRelationshipStatus;
            }
            private set
            {
                m_LoggedInUserRelationshipStatus = value;
            }
        }

        public Education[] LoggedInUserEducations
        {
            get
            {
                if (m_LoggedInUserEducations == null && LoggedInUser != null)
                {
                    m_LoggedInUserEducations = LoggedInUser.Educations;
                }

                return m_LoggedInUserEducations;
            }
            private set
            {
                m_LoggedInUserEducations = value;
            }
        }
    }
}
