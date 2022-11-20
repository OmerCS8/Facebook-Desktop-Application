using System.Windows.Forms;

namespace BasicFacebookFeatures.SubForms
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            this.BackColor = this.Parent.BackColor;
            InitializeComponent();
        }
    }
}
