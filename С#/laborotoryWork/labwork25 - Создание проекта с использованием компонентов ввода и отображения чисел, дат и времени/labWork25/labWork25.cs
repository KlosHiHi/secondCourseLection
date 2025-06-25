namespace labWork25
{
    public partial class labWork25 : Form
    {
        public labWork25()
        {
            InitializeComponent();
        }

        private void labWork25_Load(object sender, EventArgs e)
        {
            BirthDateTimePicker.MaxDate = DateTime.Now;
        }

        private void BirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var Age = 0;
            if (DateTime.Now.Month <= BirthDateTimePicker.Value.Month)
            {
                Age = DateTime.Now.Year - BirthDateTimePicker.Value.Year + 1; 
            }
            else if (DateTime.Now.Month >= BirthDateTimePicker.Value.Month && DateTime.Now.Year > BirthDateTimePicker.Value.Year && DateTime.Now.Date >= BirthDateTimePicker.Value.Date)
            {
                Age = DateTime.Now.Year - BirthDateTimePicker.Value.Year;
            }
            AgeLabel.Text = $"Возраст: {Age}";
        }

        private void TemperatureTrackBar_Scroll(object sender, EventArgs e)
        {
            TemperatureLabel.Text = $"Температура: {TemperatureTrackBar.Value} градусов цельсия";
        }
        private void RadiusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SquareLabel.Text = $"Площадь: {Math.Round(4 * Math.PI * (float)RadiusNumericUpDown.Value * (float)RadiusNumericUpDown.Value * 100) / 100}";
            VolumeLabel.Text = $"Объём: {Math.Round(Math.PI * Math.Pow((float)RadiusNumericUpDown.Value, 3) * 4 / 3 * 100) / 100}";
        }
    }
}
