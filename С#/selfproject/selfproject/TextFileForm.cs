using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selfproject
{
    public partial class TextFileForm : TemplateForm
    {
        private string _defaultPath = "C:\\QOPTex\\";
        private long _amountOfChar = 0;
        private long _amountOfCharWithoutSpace = 0;
        public TextFileForm()
        {
            InitializeComponent();
        }

        private void CreateFChildMenuItem_Click(object sender, EventArgs e)
        {
            TextFormRichTextBox.Text = "";
            this.Text = "Безымянный";
        }

        private void SaveFChildMenuItem_Click(object sender, EventArgs e)
        {
            if (TextFormSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filename = TextFormSaveFileDialog.FileName;
                    File.WriteAllText(filename, TextFormRichTextBox.Text);
                    this.Text = Path.GetFileName(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка сохранения", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OpenFChildMenuItem_Click(object sender, EventArgs e)
        {
            if (TextFormOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filename = TextFormOpenFileDialog.FileName;
                    TextFormRichTextBox.Text = File.ReadAllText(filename);
                    this.Text = Path.GetFileName(filename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При открытии файла произошла ошибка", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseFChildMenuItem_Click(object sender, EventArgs e)
        {
            if (TextFormRichTextBox.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    var path = _defaultPath + ((this.Text.Contains(".txt")) ? this.Text : this.Text + ".txt");

                    if (!Directory.Exists(_defaultPath)) { Directory.CreateDirectory(_defaultPath); }

                    if (!File.Exists(path)) { File.Create(path); }

                    else { File.WriteAllText(path, TextFormRichTextBox.Text); }

                    File.WriteAllText(path, TextFormRichTextBox.Text);
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else { this.Close(); }
        }

        private void DefPathForSaveFChildMenuItem_Click(object sender, EventArgs e)
        {
            if (TextFormFolderDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _defaultPath = TextFormFolderDialog.SelectedPath + "\\";
                    TextFormSaveFileDialog.InitialDirectory = _defaultPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void FontChildMenuItem_Click(object sender, EventArgs e)
        {
            if (TextFormFontDialog.ShowDialog() == DialogResult.OK)
            {
                try { TextFormRichTextBox.Font = TextFormFontDialog.Font; }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void ForeColorChildMenuItem_Click(object sender, EventArgs e)
        {
            if (TextFormColorDialog.ShowDialog() == DialogResult.OK)
            {
                try { TextFormRichTextBox.ForeColor = TextFormColorDialog.Color; }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void ForeColorContextMenuItem_Click(object sender, EventArgs e)
        {
            if (TextFormColorDialog.ShowDialog() == DialogResult.OK)
            {
                try { TextFormRichTextBox.ForeColor = TextFormColorDialog.Color; }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void FontContextMenuItem_Click(object sender, EventArgs e)
        {
            if (TextFormFontDialog.ShowDialog() == DialogResult.OK)
            {
                try { TextFormRichTextBox.Font = TextFormFontDialog.Font; }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void TextFileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TextFormRichTextBox.Text != String.Empty)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    var path = _defaultPath + ((this.Text.Contains(".txt")) ? this.Text : this.Text + ".txt");

                    if (!Directory.Exists(_defaultPath)) { Directory.CreateDirectory(_defaultPath); }

                    if (!File.Exists(path))
                    {
                        File.Create(path);
                        File.WriteAllText(path, TextFormRichTextBox.Text);
                    }
                    else { File.WriteAllText(path, TextFormRichTextBox.Text); }

                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            else { this.Close(); }
        }
        private void FileNameChildMenuItem_Click(object sender, EventArgs e)
        {
            if (ChangeFileNameUserControl.Visible)
            {
                ChangeFileNameUserControl.Visible = false;
            }
            else if (!ChangeFileNameUserControl.Visible)
            {
                ChangeFileNameUserControl.Visible = true;
            }
        }

        private void TextFormRichTextBox_TextChanged(object sender, EventArgs e)
        {
            var length = TextFormRichTextBox.Text.Length;
            AmountOfCharStatusLabel.Text = $"Символы: {length}";
            var lengthWSpace = TextFormRichTextBox.Text.Replace(" ", "").Length;
            AmountOfCharWitoutSpaceStatusLabel.Text = $"Символы (без пробелов): {lengthWSpace}";
        }
    }
}
