using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork26
{
    public partial class SubNewsletterForm : Form
    {
        public SubNewsletterForm()
        {
            InitializeComponent();
        }

        private void AcceptToSubСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AcceptToSubButton.Enabled = AcceptToSubСheckBox.Checked;
        }
    }
}
