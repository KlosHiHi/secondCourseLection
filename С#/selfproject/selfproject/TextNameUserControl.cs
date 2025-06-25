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
    public partial class ChangeFileNameUserControl : UserControl
    {
        public ChangeFileNameUserControl()
        {
            InitializeComponent();
        }

        private void FileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(FileNameTextBox.Text))
            {
                FileNameButton.Enabled = false;
            }
            else if (!String.IsNullOrWhiteSpace(FileNameTextBox.Text))
            {
                FileNameButton.Enabled = true;
            }
        }

        private void FileNameButton_Click(object sender, EventArgs e)
        {
            var NewName = FileNameTextBox.Text;
            Form.ActiveForm.Text = NewName;
        }
    }
}
