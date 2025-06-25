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
    public partial class BuyFlightTicketForm : Form
    {
        public BuyFlightTicketForm()
        {
            InitializeComponent();
            DateDepartureDateTimePicker.MinDate = DateTime.Now;
            ArrivalDateTimePicker.MinDate = DateTime.Now.AddDays(1);
        }

        private void OrderTicketButton_Click(object sender, EventArgs e)
        {
            if (CityArriveTextBox.Text == String.Empty || CityDepartTextBox.Text == String.Empty)
            {
                MessageBox.Show("Нужно выбрать город", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ArrivalDateTimePicker.Checked)
            {
                MessageBox.Show($"Билет: {DateDepartureDateTimePicker.Value.Day}.{DateDepartureDateTimePicker.Value.Month}.{DateDepartureDateTimePicker.Value.Year}" +
                    $" {CityDepartTextBox.Text} - {CityArriveTextBox.Text} \n" +
                    $"Обратный билет: {ArrivalDateTimePicker.Value.Day}.{ArrivalDateTimePicker.Value.Month}.{ArrivalDateTimePicker.Value.Year}" +
                    $" {CityArriveTextBox.Text} - {CityDepartTextBox.Text}", "Заказ обработан"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Билет: {DateDepartureDateTimePicker.Value.Day}.{DateDepartureDateTimePicker.Value.Month}.{DateDepartureDateTimePicker.Value.Year}" +
                    $" {CityDepartTextBox.Text} - {CityArriveTextBox.Text}",
                    "Заказ обработан", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DateDepartureDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ArrivalDateTimePicker.MinDate = DateDepartureDateTimePicker.Value.AddDays(1);
        }
    }
}
