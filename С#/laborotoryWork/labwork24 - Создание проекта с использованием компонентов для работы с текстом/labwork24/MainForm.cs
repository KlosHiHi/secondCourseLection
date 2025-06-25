namespace labwork24
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm form = new RegistrationForm();
            Hide();
            form.ShowDialog();
            Show();
        }
    }
}
