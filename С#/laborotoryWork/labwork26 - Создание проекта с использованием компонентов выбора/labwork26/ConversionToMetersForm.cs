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
    public partial class ConversionToMetersForm : Form
    {
        public ConversionToMetersForm()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double ConvertVal = 0;
            if (InchesRadioButton.Checked)
            {
                ConvertVal = Math.Round(((double)StartValNumericUpDown.Value * 0.0254) * 1000) / 1000;
                FinalValueLable.Text = $"Результат: {ConvertVal} метр(ов)";
            }
            else if (KilometersRadioButton.Checked)
            {
                ConvertVal = Math.Round(((double)StartValNumericUpDown.Value * 1000) *1000) / 1000;
                FinalValueLable.Text = $"Результат: {ConvertVal} метр(ов)";
            }
            else if (FeetRadioButton.Checked)
            {
                ConvertVal = Math.Round(((double)StartValNumericUpDown.Value * 0.3048) * 1000) / 1000;
                FinalValueLable.Text = $"Результат: {ConvertVal} метр(ов)";
            }
            else if (SantimetersRadioButton.Checked)
            {
                ConvertVal = Math.Round(((double)StartValNumericUpDown.Value / 100) * 1000) / 1000;
                FinalValueLable.Text = $"Результат: {ConvertVal} метр(ов)";
            }
        }
    }
}
