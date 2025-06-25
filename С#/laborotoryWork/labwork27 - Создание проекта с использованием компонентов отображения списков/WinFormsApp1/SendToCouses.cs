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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (CourseCheckedListBox.CheckedItems.Count > 0)
            {
                int i;
                string courses = "";
                for (i = 0; i < CourseCheckedListBox.CheckedItems.Count; i++)
                {
                    courses = courses + CourseCheckedListBox.CheckedItems[i].ToString() + "\n";
                }
                MessageBox.Show($"Вы выбрали следующие курсы:\n{courses}", "Курсы выбраны", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show($"Курсы обязательны для заполнения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
