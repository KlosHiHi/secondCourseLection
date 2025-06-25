using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork33
{
    public partial class NoteForm : Form
    {
        private string _fileName = "Notes.txt";
        public NoteForm()
        {
            InitializeComponent();
        }
        private void WriteTextButton_Click(object sender, EventArgs e)
        {
            //bool exsFile = false;
            //var i = Properties.Settings.Default.quantity;
            var text = $"{DateTime.Now}" + $"\n{NotesTextBox.Text}" + "\n\n";
            if (File.Exists(_fileName))
            {
                File.AppendAllText(_fileName, text);
            }
            else
            {
                MessageBox.Show("Будет создан новый файл с заметками!");
                File.AppendAllText(_fileName, text);
                //_fileName = $"Notes{i}.txt";
                //Properties.Settings.Default.quantity++;
                //exsFile = true;
            }

            //while (!exsFile)
            //{
            //    if (File.Exists(_fileName))
            //    {
            //        MessageBox.Show("Будет создан новый файл с заметками!");
            //        exsFile = true;
            //    }
            //    else { exsFile = false; }

            //    if (exsFile) { _fileName = $"Notes{i}.txt"; }

            //    i++;
            //}

            //if (exsFile)
            //{
            //    File.WriteAllText(_fileName, NotesTextBox.Text);
            //}
        }

    }
}
