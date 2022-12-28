using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private readonly Dictionary<Album, FlowLayoutPanel> r_ImagesPanels = new Dictionary<Album, FlowLayoutPanel>();
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        public FormAlbums()
        {
            InitializeComponent();
            setSplitterLocationAndAddColor();
            new Thread(setAlbums){IsBackground = true}.Start();
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
                if(!flowLayoutPanelAlbums.IsDisposed)
                {
                    flowLayoutPanelAlbums.Invoke(new Action(() => flowLayoutPanelAlbums.Controls.Add(albumCoverPictureBox)));
                }
            }
        }

        private void setAlbumPhotos(Album i_SelectedAlbum)
        {
            bool isFirstCallToAlbum = !r_ImagesPanels.ContainsKey(i_SelectedAlbum);
            FlowLayoutPanel imagesPanel = getAlbumImagesPanel(i_SelectedAlbum);

            if(!panelPhotos.IsDisposed)
            {
                panelPhotos.Invoke(new Action(() => panelPhotos.Controls.Clear()));
                panelPhotos.Invoke(new Action(() => panelPhotos.Controls.Add(imagesPanel)));
                linkLabelPhotoLink.Invoke(new Action((() => linkLabelPhotoLink.Text = string.Empty)));
            }

            if(isFirstCallToAlbum)
            {
                foreach(Photo currentPhoto in i_SelectedAlbum.Photos)
                {
                    PictureBoxBorderedAndNamed albumPhotoPictureBox =
                        new PictureBoxBorderedAndNamed(k_PhotoSize, false);
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
                    if(!imagesPanel.IsDisposed)
                    {
                        imagesPanel.Invoke(new Action(() => imagesPanel.Controls.Add(albumPhotoPictureBox)));
                    }
                }
            }
        }

        private FlowLayoutPanel getAlbumImagesPanel(Album i_SelectedAlbum)
        {
            if(!r_ImagesPanels.ContainsKey(i_SelectedAlbum))
            {
                r_ImagesPanels.Add(i_SelectedAlbum, new FlowLayoutPanel(){Dock = DockStyle.Fill, AutoScroll = true});
            }

            return r_ImagesPanels[i_SelectedAlbum];
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
                    new Thread(() => setAlbumPhotos(selectedAlbum)){ IsBackground = true }.Start();
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
