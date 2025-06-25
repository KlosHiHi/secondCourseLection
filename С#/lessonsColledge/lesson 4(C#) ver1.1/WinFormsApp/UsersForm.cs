using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Collections.ObjectModel;

namespace WinFormsApp
{
    public partial class UsersForm : TemplateForm
    {
        private UserService _userService;
        public UsersForm()
        {
            InitializeComponent();
            _userService = UserService.Instance;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            UserDataGridView.DataSource = _userService.AllUsers;
        }

        private void toRoleButton_Click(object sender, EventArgs e)
        {
            RoleForm form = new RoleForm();
            Navigate(this, form);
        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            if (UsersSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var data = JsonSerializer.Serialize(_userService.AllUsers,
                    new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) });
                try
                {
                    File.WriteAllText(UsersSaveFileDialog.FileName, data);
                    MessageBox.Show("Данные сохранены", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void LoadUserButton_Click(object sender, EventArgs e)
        {
            if (UsersOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var data = File.ReadAllText(UsersOpenFileDialog.FileName);
                    var users = JsonSerializer.Deserialize<List<User>>(data);
                    _userService.AllUsers = users ?? new List<User>();
                    MessageBox.Show("Данные загружены", "Успех");
                    UserDataGridView.DataSource = _userService.AllUsers;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }

        private void UserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserDataGridView.Columns[e.ColumnIndex].HeaderText == "Удалить")
            {
                var user = UserDataGridView.Rows[e.RowIndex].DataBoundItem as User;
                _userService.AllUsers.Remove(user);
                UserDataGridView.DataSource = null;
                UserDataGridView.DataSource = _userService.AllUsers;
            }
        }

        private void UserDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
