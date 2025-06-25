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
            MessageBox.Show("���������� �������", "", MessageBoxButtons.OK);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try 
            {
                Formula(X, Z, A, B);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AnswerLabel.ForeColor = Color.Red;
                AnswerText = $"�����: ������";
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
                throw new Exception("����������� ��������� �� ������ ���� ����� ����");
            }
            if (Z == 0)
            {
                throw new Exception("������ �� ���� ������");
            }
            if (B <= 0)
            {
                throw new Exception("�������� ��������� ������ ���� ������ ����");
            }
            if (A <= 0 || A == 1)
            {
                throw new Exception("��������� ��������� ������ ���� ������ 0 � �� ����� 1");
            }

            AnswerLabel.ForeColor = Color.Black;
            AnswerText = $"�����: y = {Math.Round(((Math.Sqrt(X + 3) / Z) + Math.Log(B, A)) * 100000) / 100000}";
        }

    }
}
