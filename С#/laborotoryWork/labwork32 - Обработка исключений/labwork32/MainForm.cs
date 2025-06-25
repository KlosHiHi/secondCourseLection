namespace labwork32
{
    public partial class MainForm : Form
    {
        public int X = 0;
        public int Z = 0;
        public int A = 0;
        public int B = 0;
        public string AnswerText = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Вычисление формулы", "", MessageBoxButtons.OK);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try 
            {
                Formula(X, Z, A, B);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AnswerLabel.ForeColor = Color.Red;
                AnswerText = $"Ответ: оШибкА";
            }

            AnswerLabel.Text = AnswerText;
        }

        public void Formula(int X, int Z, int A, int B)
        {
            X = (int)SetXNumericUpDown.Value;
            Z = (int)SetZNumericUpDown.Value;
            A = (int)SetANumericUpDown.Value;
            B = (int)SetBNumericUpDown.Value;

            if (X < -3)
            {
                throw new Exception("Подкоренное выражение не должно быть равно нулю");
            }
            if (Z == 0)
            {
                throw new Exception("Делить на ноль нельзя");
            }
            if (B <= 0)
            {
                throw new Exception("Аргумент логарифма должен быть больше нуля");
            }
            if (A <= 0 || A == 1)
            {
                throw new Exception("Основание логарифма должно быть больше 0 и не равно 1");
            }

            AnswerLabel.ForeColor = Color.Black;
            AnswerText = $"Ответ: y = {Math.Round(((Math.Sqrt(X + 3) / Z) + Math.Log(B, A)) * 100000) / 100000}";
        }

    }
}
