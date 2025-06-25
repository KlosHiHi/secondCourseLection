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
    public partial class RoleForm : TemplateForm
    {
        private UserService _userService;
        public RoleForm()
        {
            InitializeComponent();
            SetStyle(this);
            _userService = UserService.Instance;
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            _userService.Users.ForEach(u => usersListBox.Items.Add(u));
            _userService.Admins.ForEach(a => adminsListBox.Items.Add(a));
        }

        private void ToAdminButton_Click(object sender, EventArgs e)
        {
            var item = usersListBox.SelectedItem as User;
            if (item != null)
            {
                item.Role = Role.Administrator;
                usersListBox.Items.Remove(item);
                adminsListBox.Items.Add(item);
            }
        }

        private void ToUserButton_Click(object sender, EventArgs e)
        {
            var item = adminsListBox.SelectedItem as User;

            if (item != null)
            {
                item.Role = Role.User;
                adminsListBox.Items.Remove(item);
                usersListBox.Items.Add(item);
            }
        }
    }
}
