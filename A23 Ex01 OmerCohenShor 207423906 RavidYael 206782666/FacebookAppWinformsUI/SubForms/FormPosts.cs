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
        private readonly FaceBookUserManager r_UserManager = FaceBookUserManager.Instance;
        private const string k_EmptyFieldMsg = "-None-";
        private const string k_AccessDeniedMsg = "Access Denied!";
        private Post m_SelectedPost = null;

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
                ListViewItem listViewItem = new ListViewItem(currentPost.CreatedTime.ToString());

                listViewItem.SubItems.Add(currentPost.Message ?? k_EmptyFieldMsg);
                listViewItem.SubItems.Add(currentPost.Caption ?? k_EmptyFieldMsg);
                listViewItem.SubItems.Add(currentPost.Description ?? k_EmptyFieldMsg);
                listViewItem.SubItems.Add(currentPost.Id);
                listViewPosts.Items.Add(listViewItem);
            }

            listViewPosts.Sort();
        }

        private void listViewPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewPosts.SelectedItems.Count == 1)
            {
                m_SelectedPost = r_UserManager.LoggedInUserPosts.Find(i_Post => i_Post.Id == listViewPosts.SelectedItems[0].SubItems[4].Text);
                if (m_SelectedPost != null)
                {
                    listBoxComments.DataSource = m_SelectedPost.Comments;
                    buttonAddComment.Enabled = true;
                    richTextBoxNewComment.Enabled = true;
                }
            }
            else
            {
                buttonAddComment.Enabled = false;
                richTextBoxNewComment.Enabled = false;
                listBoxComments.DataSource = null;
                m_SelectedPost = null;
            }
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            if (richTextBoxNewComment.TextLength > 0)
            {
                try
                {
                    m_SelectedPost?.Comment(richTextBoxNewComment.Text);
                    richTextBoxNewComment.Clear();
                    MessageBox.Show("Comment was Added", "succeed",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, k_AccessDeniedMsg,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Can not post an empty comment!", "Empty comment",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNewStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (r_UserManager.CreateNewStatusAndReturnIfSucceeded(richTextBoxNewStatus.Text))
                {
                    richTextBoxNewComment.Clear();
                    MessageBox.Show("Comment was Added", "succeed",
                        MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MessageBox.Show("Can not post an empty status!", "Empty status",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, k_AccessDeniedMsg,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
