namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            TicketForm SendToTicket = new TicketForm();
            this.Hide();
            SendToTicket.ShowDialog();
            this.Show();
        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            CourseForm SendToCourse = new CourseForm();
            this.Hide();
            SendToCourse.ShowDialog();
            this.Show();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            ListForm SendToList = new ListForm();
            this.Hide();        
            SendToList.ShowDialog();    
            this.Show();
        }
    }
}
