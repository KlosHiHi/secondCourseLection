using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labword23
{
    public partial class zadanie3 : TemplateForm
    {
        public zadanie3()
        {
            InitializeComponent();
            label1.Text = $"{DateTime.Now}";
        }

        private void zadanie3_Load(object sender, EventArgs e)
        {
            tempLab.Text = "Задание №3";
        }
    }
}
