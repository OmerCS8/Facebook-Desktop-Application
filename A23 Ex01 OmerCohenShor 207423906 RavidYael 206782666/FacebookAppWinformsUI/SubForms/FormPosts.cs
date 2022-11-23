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
    public partial class FormPosts : Form
    {
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.GetFaceBookUserManagerInstance();
        public FormPosts()
        {
            InitializeComponent();
            buttonAddComment.BackColor = ColorsUtils.sr_ButtonsChosenColor;
            buttonNewStatus.BackColor = ColorsUtils.sr_ButtonsChosenColor;
            setPosts();
        }

        private void setPosts()
        {
            FacebookObjectCollection<Post> userPosts = r_UserManager.LoggedInUserPosts;
            foreach(Post currentPost in userPosts)
            {
                ListViewItem listViewItem = new ListViewItem(currentPost.Id);
                listViewItem.SubItems.Add(currentPost.Message ?? "---");
                listViewItem.SubItems.Add(currentPost.Caption ?? "---");
                listViewItem.SubItems.Add(currentPost.Description ?? "---");
                listViewItem.SubItems.Add(currentPost.CreatedTime.ToString());
                listViewPosts.Items.Add(listViewItem);
            }
        }

        private void listViewPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewPosts.SelectedIndices.Count == 1)
            {
                Post selected = r_UserManager.LoggedInUserPosts[listViewPosts.SelectedIndices[0]];
                listBoxComments.DisplayMember = "Message";
                listBoxComments.DataSource = selected.Comments;
                buttonAddComment.Enabled = true;
                listBoxComments.Enabled = true;
            }
            else
            {
                buttonAddComment.Enabled = false;
                listBoxComments.Enabled = false;
                listBoxComments.Items.Clear();
            }

        }
    }
}
