using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.FormsUtils;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormAlbums : Form
    {
        private readonly int r_AlbumCoverSize = 90;
        private readonly int r_PhotoSize = 150;
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        public FormAlbums()
        {
            InitializeComponent();
            setSplitterToScreenMiddleAndAddColor();
            setAlbums();
        }

        private void setSplitterToScreenMiddleAndAddColor()
        {
            splitContainerAlbumsPhotos.Panel1.BackColor = ColorsUtils.sr_MainColor;
            splitContainerAlbumsPhotos.Panel2.BackColor = ColorsUtils.sr_MainColor;
            splitContainerAlbumsPhotos.BackColor = ColorsUtils.sr_TopBarColor;
            splitContainerAlbumsPhotos.SplitterDistance = splitContainerAlbumsPhotos.Width / 2;
        }

        private void setAlbums()
        {
            FacebookObjectCollection<Album> userAlbums = r_UserManager.LoggedInUserAlbums;
            foreach(Album currentAlbum in userAlbums)
            {
                AlbumPictureBox albumCoverPictureBox = new AlbumPictureBox(r_AlbumCoverSize, true);
                try
                {
                    albumCoverPictureBox.PictureBackgroundImage = currentAlbum.CoverPhoto.ImageNormal;
                }
                catch (Exception)
                {
                    albumCoverPictureBox.PictureBackgroundImage = Properties.Resources.default_Album_Image;
                }

                albumCoverPictureBox.PictureName = currentAlbum.Name;
                albumCoverPictureBox.AddOnClickAction(this.albumCoverPictureBox_Clicked);
                flowLayoutPanelAlbums.Controls.Add(albumCoverPictureBox);
            }
        }

        private void setAlbumPhotos(Album i_SelectedAlbum)
        {
            flowLayoutPanelPhotos.Controls.Clear();
            foreach(Photo currentPhoto in i_SelectedAlbum.Photos)
            {
                labelChosenPhotoName.Text = "Selected photo:";
                AlbumPictureBox albumPhotoPictureBox = new AlbumPictureBox(r_PhotoSize, false);
                try
                {
                    albumPhotoPictureBox.PictureBackgroundImage = currentPhoto.ImageNormal;
                }
                catch(Exception)
                {
                    albumPhotoPictureBox.PictureBackgroundImage = Properties.Resources.default_Album_Image;
                }

                albumPhotoPictureBox.PictureName = currentPhoto.PictureNormalURL;
                albumPhotoPictureBox.AddOnClickAction(this.albumPhotoPictureBox_Clicked);
                flowLayoutPanelPhotos.Controls.Add(albumPhotoPictureBox);
            }
        }

        private void albumPhotoPictureBox_Clicked(object i_Sender, EventArgs i_E)
        {
            AlbumPictureBox clickedPhotoPictureBox = getClickedAlbumPictureBoxFromSender(i_Sender);
            if(clickedPhotoPictureBox != null)
            {
                labelChosenPhotoName.Text = $"Selected photo: {clickedPhotoPictureBox.PictureName}";
            }
        }

        private void albumCoverPictureBox_Clicked(object i_Sender, EventArgs i_E)
        {
            AlbumPictureBox clickedAlbumPictureBox = getClickedAlbumPictureBoxFromSender(i_Sender);
            string albumName;
            Album selectedAlbum;

            if(clickedAlbumPictureBox != null)
            {
                albumName = clickedAlbumPictureBox.PictureName;
                labelChosenAlbumName.Text = $"Selected album: {albumName}";
                selectedAlbum = r_UserManager.LoggedInUserAlbums.Find(i_Album => i_Album.Name == albumName);
                if(selectedAlbum != null && selectedAlbum.Photos.Count > 0)
                {
                    setAlbumPhotos(selectedAlbum);
                }
            }
        }

        private static AlbumPictureBox getClickedAlbumPictureBoxFromSender(object i_Sender)
        {
            AlbumPictureBox clickedAlbumPictureBox = null;
            if(i_Sender.GetType() == typeof(AlbumPictureBox))
            {
                clickedAlbumPictureBox = i_Sender as AlbumPictureBox;
            }
            else if(i_Sender.GetType() == typeof(PictureBox))
            {
                clickedAlbumPictureBox = (i_Sender as PictureBox)?.Parent as AlbumPictureBox;
            }
            else if(i_Sender.GetType() == typeof(Label))
            {
                clickedAlbumPictureBox = (i_Sender as Label)?.Parent as AlbumPictureBox;
            }

            return clickedAlbumPictureBox;
        }
    }
}
