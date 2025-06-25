namespace labwork35
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToFirstFormDialogButton_Click(object sender, EventArgs e)
        {
            FirstForm form = new FirstForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ToFirstFormButton_Click(object sender, EventArgs e)
        {
            FirstForm form = new FirstForm();
            this.Hide();
            form.Show();
            this.Show();
        }

        private void ToSecondMDIFormButton_Click(object sender, EventArgs e)
        {
            SecondFormMDI form = new SecondFormMDI();
            form.ShowDialog();
            this.Hide();
            this.Show();
        }
    }
}
