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
                PictureBoxBorderedAndNamed albumCoverPictureBox = new PictureBoxBorderedAndNamed(r_AlbumCoverSize, true);
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
            foreach (Photo currentPhoto in i_SelectedAlbum.Photos)
            {
                labelChosenPhotoName.Text = "Selected photo:";
                PictureBoxBorderedAndNamed albumPhotoPictureBox = new PictureBoxBorderedAndNamed(r_PhotoSize, false);
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
            if(i_Sender is PictureBoxBorderedAndNamed clickedPhotoPictureBox)
            {
                labelChosenPhotoName.Text = $"Selected photo: {clickedPhotoPictureBox.PictureName}";
            }
        }

        private void albumCoverPictureBox_Clicked(object i_Sender, EventArgs i_E)
        {
            string albumName;
            Album selectedAlbum;

            if(i_Sender is PictureBoxBorderedAndNamed clickedAlbumPictureBox)
            {
                albumName = clickedAlbumPictureBox.PictureName;
                labelChosenAlbumName.Text = $"Selected album: {albumName}";
                selectedAlbum = r_UserManager.LoggedInUserAlbums.Find(i_Album => i_Album.Name == albumName);
                if(selectedAlbum != null)
                {
                    setAlbumPhotos(selectedAlbum);
                }
            }
        }
    }
}
