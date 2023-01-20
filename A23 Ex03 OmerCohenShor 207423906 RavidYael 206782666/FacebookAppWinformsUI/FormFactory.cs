using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.FormsUtils;
using BasicFacebookFeatures.SubForms;

namespace BasicFacebookFeatures
{
    public static class FormFactory
    {
        public enum eFormType
        {
            ProfileForm,
            GroupsForm,
            AlbumsForm,
            LikedPagesForm,
            PostsForm,
            MemoryGameForm,
            GrouperForm
        }

        public static Form CreateForm(eFormType i_FormType)
        {
            Form newForm;

            switch(i_FormType)
            {
                case eFormType.ProfileForm:
                    newForm = new FormProfile();
                    break;
                case eFormType.GroupsForm:
                    newForm = new FormGroups();
                    break;
                case eFormType.AlbumsForm:
                    newForm = new FormAlbums();
                    break;
                case eFormType.LikedPagesForm:
                    newForm = new FormLikedPages();
                    break;
                case eFormType.PostsForm:
                    newForm = new FormPosts();
                    break;
                case eFormType.MemoryGameForm:
                    newForm = new FormMemoryGame();
                    break;
                case eFormType.GrouperForm:
                    newForm = new FormGrouper();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(i_FormType), i_FormType, null);
            }

            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.BackColor = ColorsUtils.sr_MainColor;
            newForm.Visible = true;

            return newForm;
        }
    }
}
