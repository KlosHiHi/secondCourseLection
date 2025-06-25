namespace labwork30
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseChildMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateChildMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Text = "";
            this.Text = "Безымянный";
        }

        private void OpenChildMenuItem_Click(object sender, EventArgs e)
        {
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fileName = MainOpenFileDialog.FileName;
                    this.Text = fileName ?? "Файл";
                    MainRichTextBox.Text = File.ReadAllText(fileName) ?? " ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveChildMenuItem_Click(object sender, EventArgs e)
        {
            if (MainSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fileName2 = MainSaveFileDialog.FileName;
                    File.WriteAllText(fileName2, MainRichTextBox.Text);
                    this.Text = fileName2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NigthThemeChildMenuItem_Click(object sender, EventArgs e)
        {
            if (NigthThemeChildMenuItem.Checked)
            { 
                MainMenuStrip.BackColor = Color.Black;
                MainMenuStrip.ForeColor = Color.White;
                MainRichTextBox.BackColor = Color.Black;
                MainRichTextBox.ForeColor = Color.White;
                SaveChildMenuItem.BackColor = Color.Black;
                SaveChildMenuItem.ForeColor = Color.White;
                OpenChildMenuItem.BackColor = Color.Black;
                OpenChildMenuItem.ForeColor = Color.White;
                CreateChildMenuItem.BackColor = Color.Black;
                CreateChildMenuItem.ForeColor = Color.White;
                CloseChildMenuItem.BackColor = Color.Black;
                CloseChildMenuItem.ForeColor = Color.White;
                NigthThemeChildMenuItem.BackColor = Color.Black;
                NigthThemeChildMenuItem.ForeColor = Color.White;
            }
            else
            {
                MainMenuStrip.BackColor = Color.White;
                MainMenuStrip.ForeColor = Color.Black;
                MainRichTextBox.BackColor = Color.OldLace;
                MainRichTextBox.ForeColor = Color.Black;
                SaveChildMenuItem.BackColor = Color.White;
                SaveChildMenuItem.ForeColor = Color.Black;
                OpenChildMenuItem.BackColor = Color.White;
                OpenChildMenuItem.ForeColor = Color.Black;
                CreateChildMenuItem.BackColor = Color.White;
                CreateChildMenuItem.ForeColor = Color.Black;
                CloseChildMenuItem.BackColor = Color.White;
                CloseChildMenuItem.ForeColor = Color.Black;
                NigthThemeChildMenuItem.BackColor = Color.White;
                NigthThemeChildMenuItem.ForeColor = Color.Black;
            }
        }

        private void ToStrangeFormMenuItem_Click(object sender, EventArgs e)
        {            
            StrangeForm form = new StrangeForm();
            form.ShowDialog();
            this.Show();
        }
    }
}
