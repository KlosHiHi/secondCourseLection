using System.Windows.Forms;

namespace labwork33
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToNoteFormButton_Click(object sender, EventArgs e)
        {
            NoteForm form = new NoteForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ToAuthButton_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ToShopFormButton_Click(object sender, EventArgs e)
        {
            ShopForm form = new ShopForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
