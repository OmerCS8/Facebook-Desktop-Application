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
        // -------------------------------------- Singleton Instance --------------------------------------

        private FaceBookUserManager()
        {
        }

        private static FaceBookUserManager UserManager { get; set; }

        public static FaceBookUserManager Instance
        {
            get
            {
                if (UserManager == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (UserManager == null)
                        {
                            UserManager = new FaceBookUserManager();
                        }
                    }
                }

                return UserManager;
            }
        }

        // ----------------------------------------- Logged in user  --------------------------------------

        private User LoggedInUser { get; set; }
        public event Action UserLoggedIn;
        public event Action UserLoggedOut;

        public void UserLogIn()
        {
            LoginResult loginResult;

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
                LoggedInUser = loginResult.LoggedInUser;
                r_UserAppSettings.UserAccessToken = loginResult.AccessToken;
                onLogin();
            }
            else
            {
                onLogout();
            }
        }

        public void TryLogInIfUserIsRemembered()
        {
            LoginResult loginResult;

            if (r_UserAppSettings.DoesUserWantToRememberHim && !string.IsNullOrEmpty(r_UserAppSettings.UserAccessToken))
            {
                loginResult = FacebookService.Connect(r_UserAppSettings.UserAccessToken);
                if (loginResult.LoggedInUser != null)
                {
                    LoggedInUser = loginResult.LoggedInUser;
                    onLogin();
                }
                else
                {
                    onLogout();
                }
            }
            else
            {
                onLogout();
            }
        }

        public void UserLogOut()
        {
            FacebookService.Logout();
            r_UserAppSettings.UserAccessToken = null;
            clearCache();
            onLogout();
        }

        private void onLogin()
        {
            UserLoggedIn?.Invoke();
        }

        private void onLogout()
        {
            UserLoggedOut?.Invoke();
        }

        // ------------------------------------------ App settings ----------------------------------------

        private readonly AppSettings r_UserAppSettings = AppSettings.LoadAppSettingsFromFileOrCreateIfDoesNotExist();
        
        public bool DoesUserWantToRememberHim
        {
            get => r_UserAppSettings.DoesUserWantToRememberHim;
            set => r_UserAppSettings.DoesUserWantToRememberHim = value;
        }

        public void SaveSettingsChanges()
        {
            r_UserAppSettings.SaveAppSettingsToFile();
        }

        // ------------------------------------------ User actions ----------------------------------------

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

        public FriendList CreateFriendList(string i_FriendListName)
        {
            return LoggedInUser.CreateFriendList(i_FriendListName);
        }

        // --------------------------------------------- Locks --------------------------------------------


        private static readonly object sr_InstanceLock = new object();
        private readonly object r_LoggedInUserPostsLock = new object();
        private readonly object r_LoggedInUserAlbumsLock = new object ();
        private readonly object r_LoggedInUserLikedPagesLock = new object();
        private readonly object r_LoggedInUserGroupsLock = new object();
        private readonly object r_LoggedInUserFriendsLock = new object();
        private readonly object r_LoggedInUserNameLock = new object();
        private readonly object r_LoggedInUserProfilePictureLargeLock = new object();
        private readonly object r_LoggedInUserCoverImageLock =new object();
        private readonly object r_LoggedInUserAgeLock = new object();
        private readonly object r_LoggedInUserGenderLock = new object();
        private readonly object r_LoggedInUserBirthdayLock = new object();
        private readonly object r_LoggedInUserEmailLock = new object();
        private readonly object r_LoggedInUserLocationLock = new object();
        private readonly object r_LoggedInUserNumberOfPhotosLock = new object();
        private readonly object r_LoggedInUserWorkExperiencesLock = new object();
        private readonly object r_LoggedInUserFavoritesTeamsLock = new object();
        private readonly object r_LoggedInUserRelationshipStatusLock = new object();
        private readonly object r_LoggedInUserEducationsLock = new object();


        // --------------------------------------------- Cache --------------------------------------------

        private void clearCache()
        {
            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                if(propertyInfo.PropertyType != typeof(FaceBookUserManager))
                {
                    if(propertyInfo.SetMethod.IsPrivate)
                    {
                        propertyInfo.SetValue(this, null);
                    }
                }
            }
        }

        private void getObjectFromFacebookToCacheIfNeeded<T>(ref T i_ObjectToGet, object i_Locker, Func<T> i_FacebookGetFunc)
        {
            if(i_ObjectToGet == null && LoggedInUser != null)
            {
                lock(i_Locker)
                {
                    if(i_ObjectToGet == null)
                    {
                        i_ObjectToGet = i_FacebookGetFunc.Invoke();
                    }
                }
            }
        }

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

        public int? LoggedInUserAge
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<int?>(ref m_LoggedInUserAge, r_LoggedInUserAgeLock,
                    () => DateTime.Now.Year - DateTime.Parse(LoggedInUserBirthday).Year);

                return m_LoggedInUserAge;
            }
            private set => m_LoggedInUserAge = value;
        }

        public WorkExperience[] LoggedInUserWorkExperiences
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<WorkExperience[]>(
                    ref m_LoggedInUserWorkExperiences, r_LoggedInUserWorkExperiencesLock,
                    () => LoggedInUser.WorkExperiences);

                return m_LoggedInUserWorkExperiences;
            }
            private set => m_LoggedInUserWorkExperiences = value;
        }
        
        public Page[] LoggedInUserFavoritesTeams
        {

            get
            {
                getObjectFromFacebookToCacheIfNeeded<Page[]>(ref m_LoggedInUserFavoritesTeams, r_LoggedInUserFavoritesTeamsLock,
                    () => LoggedInUser.FavofriteTeams);

                return m_LoggedInUserFavoritesTeams;
            }
            private set => m_LoggedInUserFavoritesTeams = value;
        }
        
        public long? LoggedInUserNumberOfPhotos
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<long?>(ref m_LoggedInUserNumberOfPhotos, r_LoggedInUserNumberOfPhotosLock,
                    () => LoggedInUserAlbums.Sum(i_Album => i_Album.Count));

                return m_LoggedInUserNumberOfPhotos;
            }
            private set => m_LoggedInUserNumberOfPhotos = value;
        }

        public string LoggedInUserBirthday
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<string>(ref m_LoggedInUserBirthday, r_LoggedInUserBirthdayLock,
                    () => LoggedInUser.Birthday);

                return m_LoggedInUserBirthday;
            }
            private set => m_LoggedInUserBirthday = value;
        }

        public User.eGender? LoggedInUserGender
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<User.eGender?>(ref m_LoggedInUserGender, r_LoggedInUserGenderLock,
                    () => LoggedInUser.Gender);

                return m_LoggedInUserGender;
            }
            private set => m_LoggedInUserGender = value;
        }

        public string LoggedInUserName
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<string>(ref m_LoggedInUserName, r_LoggedInUserNameLock,
                    () => LoggedInUser.Name);

                return m_LoggedInUserName;
            }
            private set => m_LoggedInUserName = value;
        }

        public Image LoggedInUserProfilePictureLarge
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<Image>(
                    ref m_LoggedInUserProfilePictureLarge, r_LoggedInUserProfilePictureLargeLock,
                    () => LoggedInUser.ImageLarge);

                return m_LoggedInUserProfilePictureLarge;
            }
            private set => m_LoggedInUserProfilePictureLarge = value;
        }

        public Image LoggedInUserCoverImage
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<Image>(
                    ref m_LoggedInUserCoverImage, r_LoggedInUserCoverImageLock,
                    () => LoggedInUserAlbums.FirstOrDefault(i_Album => i_Album.Name == "Cover photos")?.Photos
                        .FirstOrDefault()?.ImageNormal);

                return m_LoggedInUserCoverImage;
            }
            private set => m_LoggedInUserCoverImage = value;
        }

        public string LoggedInUserEmail
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<string>(
                    ref m_LoggedInUserEmail, r_LoggedInUserEmailLock, () => LoggedInUser.Email);

                return m_LoggedInUserEmail;
            }
            private set => m_LoggedInUserEmail = value;
        }

        public City LoggedInUserLocation
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<City>(
                    ref m_LoggedInUserLocation, r_LoggedInUserLocationLock, () => LoggedInUser.Location);

                return m_LoggedInUserLocation;
            }
            private set => m_LoggedInUserLocation = value;
        }

        public FacebookObjectCollection<User> LoggedInUserFriends
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<FacebookObjectCollection<User>>(
                    ref m_LoggedInUserFriends, r_LoggedInUserFriendsLock,
                    () => LoggedInUser.Friends);

                return m_LoggedInUserFriends;
            }
            private set => m_LoggedInUserFriends = value;
        }

        public FacebookObjectCollection<Post> LoggedInUserPosts
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<FacebookObjectCollection<Post>>(
                    ref m_LoggedInUserPosts, r_LoggedInUserPostsLock, () => LoggedInUser.Posts);

                return m_LoggedInUserPosts;
            }
            private set => m_LoggedInUserPosts = value;
        }

        public FacebookObjectCollection<Album> LoggedInUserAlbums
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<FacebookObjectCollection<Album>>(
                    ref m_LoggedInUserAlbums, r_LoggedInUserAlbumsLock, () => LoggedInUser.Albums);

                return m_LoggedInUserAlbums;
            }
            private set => m_LoggedInUserAlbums = value;
        }

        public FacebookObjectCollection<Page> LoggedInUserLikedPages
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<FacebookObjectCollection<Page>>(
                    ref m_LoggedInUserLikedPages, r_LoggedInUserLikedPagesLock, () => LoggedInUser.LikedPages);

                return m_LoggedInUserLikedPages;
            }
            private set => m_LoggedInUserLikedPages = value;
        }

        public FacebookObjectCollection<Group> LoggedInUserGroups
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<FacebookObjectCollection<Group>>(
                    ref m_LoggedInUserGroups, r_LoggedInUserGroupsLock, () => LoggedInUser.Groups);

                return m_LoggedInUserGroups;
            }
            private set => m_LoggedInUserGroups = value;
        }

        public User.eRelationshipStatus? LoggedInUserRelationshipStatus 
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<User.eRelationshipStatus?>(
                    ref m_LoggedInUserRelationshipStatus, r_LoggedInUserRelationshipStatusLock,
                    () => LoggedInUser.RelationshipStatus);

                return m_LoggedInUserRelationshipStatus;
            }
            private set => m_LoggedInUserRelationshipStatus = value;
        }

        public Education[] LoggedInUserEducations
        {
            get
            {
                getObjectFromFacebookToCacheIfNeeded<Education[]>(
                    ref m_LoggedInUserEducations, r_LoggedInUserEducationsLock, () => LoggedInUser.Educations);

                return m_LoggedInUserEducations;
            }
            private set => m_LoggedInUserEducations = value;
        }

    }
}
