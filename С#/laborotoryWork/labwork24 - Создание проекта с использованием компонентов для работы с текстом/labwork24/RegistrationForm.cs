using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork24
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            bool LoginEmpty = true, PasswordEmpty = true, PasswordMatch = true;

            if (loginTextBox.Text != String.Empty) LoginEmpty = false;
            if (PasswordTextBox.Text != String.Empty) PasswordEmpty = false;
            if (PasswordTextBox.Text == repeatPasswordTextBox.Text) PasswordMatch = false;

            if (!LoginEmpty && !PasswordEmpty && !PasswordMatch)
            {
                PasswordTextBox.BackColor = Color.White;
                MessageBox.Show($"{loginTextBox.Text} вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (LoginEmpty)
            {
                loginTextBox.BackColor = Color.OrangeRed;
                MessageBox.Show("Логин не должен быть пустым", "Ошибка Заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            else if (PasswordEmpty)
            {
                PasswordTextBox.BackColor = Color.OrangeRed;
                MessageBox.Show("Пароль не должен быть пустым", "Ошибка Заполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordMatch)
            {
                PasswordTextBox.BackColor = Color.OrangeRed;
                repeatPasswordTextBox.BackColor = Color.OrangeRed;
                MessageBox.Show("Пароль не совпадает", "Ошибка Заполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            loginTextBox.BackColor = Color.White;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.White;
        }

        private void repeatPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            repeatPasswordTextBox.BackColor = Color.White;
        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space) { return; }
            else { e.Handled = true; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                repeatPasswordTextBox.UseSystemPasswordChar = false;
            }
            else 
            {  
                PasswordTextBox.UseSystemPasswordChar = true;
                repeatPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
