using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Calculator
{
    public partial class PassworsRecovery : Form
    {
        private UserManagement userManagement;

        public PassworsRecovery()
        {
        }

        public PassworsRecovery(UserManagement usermManagement)
        {
            InitializeComponent();

            
            this.userManagement = userManagement;

            Recover.Click += Recover_Click;

            Controls.Add(Name);
            Controls.Add(Username);
            Controls.Add(Password);
            Controls.Add(CPassword);
            Controls.Add(Recover);
        }
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Recover_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string name = Name.Text;
            var user = userManagement.GetUserByUsername(username);

            if (user != null && user.Name == name)
            {
                MessageBox.Show("Password recovery successful! Your password is: " + user.Password);
            }
            else
            {
                MessageBox.Show("Invalid username or name.");
            }
        }
    }
}
