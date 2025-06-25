using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork28
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DataButton_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void PetButton_Click(object sender, EventArgs e)
        {
            PetsForm form = new PetsForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ToShopFormButton_Click(object sender, EventArgs e)
        {
            ShopForm form = new ShopForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
