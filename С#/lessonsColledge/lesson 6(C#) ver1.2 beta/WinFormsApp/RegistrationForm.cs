using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class RegistrationForm : TemplateForm
    {
        private UserService _userService;
        public RegistrationForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
        }

        private void connfirmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            registrationButton.Enabled = connfirmCheckBox.Checked;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            if (String.IsNullOrEmpty(loginTextBoxReg.Text))
            {
                builder.AppendLine("Логин не должен быть пустым");
            }
            if (String.IsNullOrEmpty(passwordTextBoxReg.Text))
            {
                builder.AppendLine("Пароль не должен быть пустым");
            }
            if (passwordRepTextBoxReg.Text != passwordTextBoxReg.Text)
            {
                builder.AppendLine("Пароль не совпадает");
            }
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpper = new Regex(@"[A-ZА-Я]+");
            var hasLower = new Regex(@"[a-zа-я]+");
            var hasMin8char = new Regex(@".{8,}");

            if (!hasNumber.IsMatch(passwordTextBoxReg.Text))
            {
                builder.AppendLine("Пароль должен содержать цифру");
            }
            if (!hasUpper.IsMatch(passwordTextBoxReg.Text))
            {
                builder.AppendLine("Пароль должен содержать символ в верхнем регистре");
            }
            if (!hasLower.IsMatch(passwordTextBoxReg.Text))
            {
                builder.AppendLine("Пароль должен содержать символ в нижнем регистре");
            }
            if (!hasMin8char.IsMatch(passwordTextBoxReg.Text))
            {
                builder.AppendLine("Пароль должен содержать минимум 8 символов.");
            }

            var isValidEmail = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");

            if (!isValidEmail.IsMatch(eMailTextBoxReg.Text))
            {
                builder.AppendLine("Указан некорректный Email");
            }

            if (!RegCaptcha.IsCorrectText(Text))
            {
            }

            if (builder.Length > 0)
            {
                MessageBox.Show(builder.ToString(), "Ошибка 42", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();

            user.Login = loginTextBoxReg.Text;
            user.Password = passwordTextBoxReg.Text;
            user.Email = eMailTextBoxReg.Text;
            user.BirthDate = birthDayDateTimePickerReg.Value;
            user.FullName = fullNameTextBoxReg.Text;
            user.Gender = maleRadioButton.Checked ? Gender.Male : Gender.Female;

            _userService.Registrate(user);

            MessageBox.Show($"{user.Login}, Вы зарегистрированы");
        }

        private void RenewButton_Click(object sender, EventArgs e)
        {
            RegCaptcha.Renew();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            RegCaptcha.Renew();
        }
    }
}
