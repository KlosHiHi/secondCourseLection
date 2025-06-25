namespace labwork26
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToSubFormButton_Click(object sender, EventArgs e)
        {
            SubNewsletterForm form = new SubNewsletterForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConversionToMetersForm form = new ConversionToMetersForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ToBuyFlightTicketFormButton_Click(object sender, EventArgs e)
        {
            BuyFlightTicketForm form = new BuyFlightTicketForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
