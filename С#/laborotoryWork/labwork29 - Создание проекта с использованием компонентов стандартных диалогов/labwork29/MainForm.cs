using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace labwork29
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            if (MainOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var Otext = File.ReadAllText(MainOpenFileDialog.FileName);
                    TextFileRichTextBox.Text = Otext ?? " ";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            if (MainSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var Stext = TextFileRichTextBox.Text;
                    File.WriteAllText(MainSaveFileDialog.FileName, Stext);
                    MessageBox.Show("Успех", "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ChangeColorMenuItem_Click(object sender, EventArgs e)
        {
            if (MainColorDialog.ShowDialog() == DialogResult.OK)
            {
                TextFileRichTextBox.ForeColor = MainColorDialog.Color;
            }
        }

        private void ChangeFontMenuItem_Click(object sender, EventArgs e)
        {
            if (MainFontDialog.ShowDialog() == DialogResult.OK)
            {
                TextFileRichTextBox.Font = MainFontDialog.Font;
            }
        }

        private void DefaultFolderMenuItem_Click(object sender, EventArgs e)
        {
            if(MainFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                MainSaveFileDialog.InitialDirectory = MainFolderBrowserDialog.SelectedPath;
            }
        }
    }
}
