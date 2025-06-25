namespace labword23
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Добро пожаловать - {DateTime.Now}", "Приветствие", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("", "Заркытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TemplateForm form = new TemplateForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zadanie3 form = new zadanie3();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zadanie4 form = new zadanie4();
            form.ShowDialog();
        }
    }
}
