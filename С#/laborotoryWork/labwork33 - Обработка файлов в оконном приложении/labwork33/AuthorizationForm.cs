using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork33
{
    public partial class AuthorizationForm : Form
    {
        public string[] _logins;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            _logins = File.ReadAllLines("logins.txt");
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            bool check = false;

            foreach(string l in _logins)
            {
                if (l == LoginTextBox.Text)
                {
                    MessageBox.Show("Добро пожаловать!");
                    this.Close();
                    check = true;
                    break;
                }
            } 

            if (!check) { MessageBox.Show("Вам тут не рады!"); }

        }
    }
}
