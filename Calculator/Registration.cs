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
    public partial class Registration : Form
    {
        private UserManagement userManagement;
        public Registration()
        {
            InitializeComponent();

            Register.Click += Register_Click;
            Controls.Add(Name);
            Controls.Add(Email);
            Controls.Add(Username);
            Controls.Add(Password);
            Controls.Add(CPassword);
            Controls.Add(Policy);
            Controls.Add(Register);

        }


        /*OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =DB_Practicalwork_II1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();*/

        private void Registration_Load(object sender, EventArgs e)
        {
            //Name = new TextBox() { PlaceholderText = "Name", Location = new Point(10, 10) };
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(Policy.Checked)
            {

            }
            else
            {
                MessageBox.Show("Accept the Policy", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (!Policy.Checked)
            {
                MessageBox.Show("You must agree to the protection policy.");
                return;
            }

            string name = Name.Text;
            string email = Email.Text;
            string username = Username.Text;
            string password = Password.Text;
            string confirmPassword = CPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            var user = new User { Name = name, Username = username, Password = password, OperationsExecuted = 0 };

            if (!user.IsValidPassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long, including one upper and one lower case letter, one number, and one special symbol.");
                return;
            }

            if (userManagement.RegisterUser(user))
            {
                MessageBox.Show("Registration successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Name.Text = "";
            Username.Text = "";
            Email.Text = "";
            Password.Text = "";
            CPassword.Text = "";
            Username.Focus();
        }
    }


}
/*
  if (!Policy.Checked)
            {
                MessageBox.Show("You must agree to the protection policy.");
                return;
            }
            if (Name.Text == "" && Username.Text == "" && Email.Text == "" && Password.Text =="" && CPassword.Text == "")
            {
                MessageBox.Show("There is an Empty field", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (Password.Text == CPassword.Text)
            {
                
                con.Open();
                string register = "INSERT INTO Table_users VALUES('" + Name.Text + "','" + Username.Text + "','" + Email + "','" + Password + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                Name.Text = "";
                Username.Text = "";
                Email.Text = "";
                Password.Text = "";
                CPassword.Text = "";


                MessageBox.Show("Your Account has been created", "Registrationsuccesfull", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Password doesn't match try again", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password.Text = "";
                CPassword.Text = "";
                Password.Focus();
            }
 */