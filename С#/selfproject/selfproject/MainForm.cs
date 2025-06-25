namespace selfproject
{
    public partial class MainForm : TemplateForm
    {
        public MainForm()
        {
            InitializeComponent();
            Design(this);
        }

        private void EditTextMenuItem_Click(object sender, EventArgs e)
        {
            TextFileForm form = new TextFileForm();
            form.ShowDialog();
        }
    }
}
