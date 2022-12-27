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
        private const int k_AlbumCoverSize = 90;
        private const int k_PhotoSize = 150;
        private const int k_ShownPhotoHeight = 400;
        private Image m_ChosenPhoto;
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        public FormAlbums()
        {
            InitializeComponent();
            setSplitterLocationAndAddColor();
            setAlbums();
        }

        private void setSplitterLocationAndAddColor()
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
                PictureBoxBorderedAndNamed albumCoverPictureBox = new PictureBoxBorderedAndNamed(k_AlbumCoverSize, true);

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
            linkLabelPhotoLink.Visible = false;
            foreach (Photo currentPhoto in i_SelectedAlbum.Photos)
            {
                labelChosenPhotoName.Text = "Selected photo:";
                PictureBoxBorderedAndNamed albumPhotoPictureBox = new PictureBoxBorderedAndNamed(k_PhotoSize, false);
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
                linkLabelPhotoLink.Text = clickedPhotoPictureBox.PictureName;
                linkLabelPhotoLink.Visible = true;
                m_ChosenPhoto = clickedPhotoPictureBox.PictureBackgroundImage;
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

        private void linkLabelPhotoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form photoForm = new Form();
            int photoWidthWitImageProportion = (k_ShownPhotoHeight * m_ChosenPhoto.Width) / m_ChosenPhoto.Height;

            photoForm.Size = new Size(photoWidthWitImageProportion, k_ShownPhotoHeight);
            photoForm.BackgroundImage = m_ChosenPhoto;
            photoForm.BackgroundImageLayout = ImageLayout.Stretch;
            photoForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            photoForm.StartPosition = FormStartPosition.CenterScreen;
            photoForm.Show();
        }
    }
}
