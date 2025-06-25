using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MainForm : TemplateForm
    {
        private AuthorizationForm _authorizationForm;
        public AuthorizationForm AuthorizationForm 
        {
            get
            {
                bool isNull = _authorizationForm == null || _authorizationForm.IsDisposed;
                return isNull ? _authorizationForm = new AuthorizationForm() { MdiParent = this } : _authorizationForm;
            }
        }

        private RegistrationForm _registrationForm;
        public RegistrationForm RegistrationForm
        {
            get
            {
                bool isNull = _registrationForm == null || _registrationForm.IsDisposed;
                return isNull ? _registrationForm = new RegistrationForm() { MdiParent = this } : _registrationForm;
            }
        }
        private ColorForm _colorForm;
        public ColorForm ColorForm
        {
            get
            {
                bool isNull = _colorForm == null || _colorForm.IsDisposed;
                return isNull ? _colorForm = new ColorForm() { MdiParent = this } : _colorForm;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            SetStyle(this);
        }
        private void toAuthorizationButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm.MdiParent = this;
            AuthorizationForm.Show();
        }

        private void toRegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm.MdiParent = this;
            RegistrationForm.Show();
        }

        private void toColorFormButton_Click(object sender, EventArgs e)
        {
            ColorForm.MdiParent = this;
            ColorForm.Show();
        }

        private void CurrentTimeTimer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            CurrentTimeTimer.Start();
            UpdateTime();
        }

        private void UpdateTime()
        {
            DayTimeStatusLabel.Text = DateTime.Now.ToString();
        }

        private void MainForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentTimeTimer.Stop();
        }
    }
}
