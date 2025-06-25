using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainForm1 : TemplateForm
    {
        public MainForm1()
        {
            InitializeComponent();
            SetStyle(this);
        }
        private void toAuthorizationButton_Click(object sender, EventArgs e)
        {
            MainForm1 formF = new MainForm1();
            AuthorizationForm form = new AuthorizationForm();
            Navigate(formF, form);
        }

        private void toRegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            Navigate(this, form);
        }

        private void toColorFormButton_Click(object sender, EventArgs e)
        {
            ColorForm form = new ColorForm();
            Navigate(this, form);
        }
    }
}
