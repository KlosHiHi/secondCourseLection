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
        private Settings _settings;
        protected string _title;
        public TemplateForm()
        {
            InitializeComponent();
            _settings = Settings.Instance;
            _settings.ColorChanged += Settings_ColorChanged;
        }

        private void Settings_ColorChanged(object? sender, EventArgs e)
        {
            BackColor = _settings.Color;
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            BackColor = _settings.Color;
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
