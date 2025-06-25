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
    public partial class AuthorizationForm : TemplateForm
    {
        string _login = "admin";
        string _password = "qwerty";

        public AuthorizationForm()
        {
            InitializeComponent();
            SetStyle(this);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == _login && passwordTextBox.Text == _password)
            {
                MessageBox.Show("Добро пожаловать!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Доступ запрещён!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                //passwordTextBox.PasswordChar = '\0';
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                //passwordTextBox.PasswordChar = '*';
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}