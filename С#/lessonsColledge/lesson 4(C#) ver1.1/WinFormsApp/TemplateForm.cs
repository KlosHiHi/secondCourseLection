using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class TemplateForm : Form
    {
        protected string _title;
        public TemplateForm()
        {
            InitializeComponent();
            timeLabel.Text = $"{DateTime.Now}";
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 1000;
            timer.Start();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = $"{DateTime.Now}";
        }

        public void SetStyle(Control elements)
        {
            foreach (Control control in elements.Controls)
            {
                if (control is Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetStyle(control);
            }
        }

        public void Navigate(Form formForm, Form formTo)
        {
            Hide();

            formTo.ShowDialog();

            Show();
        }
    }
}
