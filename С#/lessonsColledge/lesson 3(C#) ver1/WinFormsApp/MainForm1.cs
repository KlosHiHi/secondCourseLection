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
            MainForm1 formF = new MainForm1();
            RegistrationForm form = new RegistrationForm();
            Navigate(formF, form);
        }
    }
}
