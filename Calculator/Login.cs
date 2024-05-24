using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Calculator
{
    public partial class Login : Form
    {
        private UserManagement userManagement;
        public Login()
        {
            InitializeComponent();

            

            userManagement = new UserManagement();

            Singin.Click += Singin_Click;
            RPassword.LinkClicked += linkLabel1_LinkClicked;

            Controls.Add(Username);
            Controls.Add(Password);
            Controls.Add(Singin);
            //Controls.Add(Register);
            Controls.Add(RPassword);
        }

        /*
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =DB_Practicalwork_II1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        */

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var recovery = new PassworsRecovery();
            recovery.Show();
        }

        private void Singin_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            var user = userManagement.AuthenticateUser(username, password);

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                var calculatorForm = new Calculator(user);
                calculatorForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            Password.Text = "";
            Username.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }
    }
}

/*con.Open();
string login = "SELECT * FROM Table_users WHERE username= '" + Username.Text+"' and password= '"+Password.Text+"'";
cmd = new OleDbCommand(login,con);
OleDbDataReader dr = cmd.ExecuteReader();

if(dr.Read() == true)
{
    new Calculator().Show();
    this.Hide();
}
else
{
    MessageBox.Show("Invalid Usernamme or Password, Please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
    Username.Text = "";
    Password.Text = "";
    Username.Focus();
}
*/