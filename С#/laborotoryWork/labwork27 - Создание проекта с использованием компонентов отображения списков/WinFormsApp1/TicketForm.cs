﻿using System;
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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (ToPlaceComboBox.Text != String.Empty)
            {
                MessageBox.Show($"Билет: Архангельск — {ToPlaceComboBox.Text}", "Успешный заказ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ошибка", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
