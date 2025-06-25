using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text != String.Empty)
            {
                FirstListBox.Items.Add(InputTextBox.Text);
            }
            else
            {
                return;
            }
        }

        private void ChooseElementRigthButton_Click(object sender, EventArgs e)
        {
            SecondListBox.Items.Add(FirstListBox.SelectedItem.ToString());
            FirstListBox.Items.Remove(FirstListBox.SelectedItem);
        }

        private void ChooseElementLeftButton_Click(object sender, EventArgs e)
        {
            FirstListBox.Items.Add(SecondListBox.SelectedItem.ToString());
            SecondListBox.Items.Remove(SecondListBox.SelectedItem);
        }

        private void AllElemtnsRightButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FirstListBox.Items.Count; i += 1)
                SecondListBox.Items.Add((string)FirstListBox.Items[i]);

            FirstListBox.Items.Clear();

        }
        private void AllElemtnsLeftButton_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < SecondListBox.Items.Count;i += 1)
                FirstListBox.Items.Add((string)SecondListBox.Items[i]);

            SecondListBox.Items.Clear();
        }
    }
}
