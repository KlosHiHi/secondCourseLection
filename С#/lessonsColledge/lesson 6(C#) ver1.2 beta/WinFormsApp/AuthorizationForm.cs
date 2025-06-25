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
        private UserService _userService;
        public AuthorizationForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
            SetStyle(this);
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (_userService.Authorize(loginTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Добро пожаловать!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsersForm form = new UsersForm();
                Navigate(this, form);
                Close();
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
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}