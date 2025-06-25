using System.Drawing.Text;

namespace labwork30
{
    public partial class MainForm : Form
    {
        private int _quantityOfChar = 0;
        InstalledFontCollection ifc = new InstalledFontCollection();
        public MainForm()
        {
            InitializeComponent();
            StatusLabelTimeNow.Text = DateTime.Now.ToString();
            StatusLabelQuantityOfCharEmpty.Text = $"{_quantityOfChar} символов";
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

        private void ColorStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainColorDialog.ShowDialog() == DialogResult.OK)
            {
                MainRichTextBox.ForeColor = MainColorDialog.Color;
            }
            else { return; }
        }

        private void FontStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainFontDialog.ShowDialog() == DialogResult.OK)
            {
                MainRichTextBox.Font = MainFontDialog.Font;
            }
            else { return; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TimeTimer.Start();
            FontFamily[] families = ifc.Families;
            foreach (FontFamily family in families)
            {
                TSToolStripListOfFont.Items.Add(family.Name);
            }
            UpdateTimeAndChar();
        }

        private void ChangeFontButton_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Font = new Font($"{TSToolStripChangeFont.Text}", 11);
            TSToolStripChangeFont.Text = "";
        }

        private void ChangeFontButtonTwo_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Font = new Font($"{TSToolStripListOfFont.SelectedItem}", 11);
        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            UpdateTimeAndChar();
        }

        private void UpdateTimeAndChar()
        {
            StatusLabelTimeNow.Text = DateTime.Now.ToString();
            StatusLabelQuantityOfCharEmpty.Text = $"{(MainRichTextBox.Text.Count())} символ(ов) с учётом пробелов";
            StatusLabelQuantityOfChar.Text = $"{MainRichTextBox.Text.Replace(" ", "").Count()} символ(ов) без учёта пробела";
        }

        private void MainForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            TimeTimer.Stop();
        }
    }
}
