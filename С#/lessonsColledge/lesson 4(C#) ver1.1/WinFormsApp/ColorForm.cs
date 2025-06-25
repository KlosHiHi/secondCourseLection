using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ColorForm : TemplateForm
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void Color_ValueChanged(object sender, EventArgs e)
        {
            if (sender is TrackBar)
            {
                redNumericUpDown.Value = redTrackBar.Value;
                greenNumericUpDown.Value = greenTrackBar.Value;
                blueNumericUpDown.Value = blueTrackBar.Value;
            }
            else
            {
                redTrackBar.Value = (int)redNumericUpDown.Value;
                greenTrackBar.Value = (int)greenNumericUpDown.Value;
                blueTrackBar.Value = (int)blueNumericUpDown.Value;
            }
            BackColor = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {
            ColorComboBox.DataSource = typeof(Color).GetProperties()
                .Where(x => x.PropertyType == typeof(Color))
                .Select(x => x.GetValue(null)).ToList();
            //Рефлекция. Системный класс Color был разобран и получили все значения Color
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var color = (Color)ColorComboBox.SelectedItem != Color.Transparent ? (Color)ColorComboBox.SelectedItem : Color.White;
            redTrackBar.Value = color.R;
            greenTrackBar.Value = color.G;
            blueTrackBar.Value = color.B;
        }

        private void SelectColorButton_Click(object sender, EventArgs e)
        {
            if(SelectColorDialog.ShowDialog() == DialogResult.OK)
            {
                redTrackBar.Value = SelectColorDialog.Color.R;
                greenTrackBar.Value = SelectColorDialog.Color.G;
                blueTrackBar.Value = SelectColorDialog.Color.B;
            }
        }
    }
}
