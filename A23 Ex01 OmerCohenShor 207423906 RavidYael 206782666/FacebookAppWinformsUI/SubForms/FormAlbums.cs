using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookAppEngine;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormAlbums : Form
    {
        private readonly int r_AlbumCoverSize = 90;
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        public FormAlbums()
        {
            InitializeComponent();
            setSplitterToScreenMiddle();
            setAlbums();
        }

        private void setSplitterToScreenMiddle()
        {
            splitContainerAlbumsPhotos.SplitterDistance = splitContainerAlbumsPhotos.Width / 2;
        }

        private void setAlbums()
        {
            FacebookObjectCollection<Album> userAlbums = r_UserManager.LoggedInUserAlbums;
            foreach(Album currentAlbum in userAlbums)
            {
                PictureBox albumCoverPictureBox = new PictureBox();
                albumCoverPictureBox.Size = new Size(r_AlbumCoverSize, r_AlbumCoverSize);
                try
                {
                    albumCoverPictureBox.BackgroundImage = currentAlbum.CoverPhoto.ImageNormal;
                }
                catch (Exception)
                {
                    albumCoverPictureBox.BackgroundImage = Properties.Resources.default_Album_Image;
                }

                albumCoverPictureBox.Visible = true;
                albumCoverPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                flowLayoutPanelAlbums.Controls.Add(albumCoverPictureBox);

            }
        }
    }
}
