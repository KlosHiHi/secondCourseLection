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
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        public void Design(Form form)
        {
            form.BackColor = this.BackColor;
            form.ForeColor = this.ForeColor;
            form.Icon = this.Icon;
        }

        public void Navigate(Form form, Form form1)
        {
            form.Hide();
            form1.ShowDialog();
            form.Show();
        }
    }
}
