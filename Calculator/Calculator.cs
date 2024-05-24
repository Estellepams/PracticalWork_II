using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        private UserManagement userManagement;
        private User user;
        public Calculator(User user)
        {
            InitializeComponent();

            this.user = user;
            userManagement = new UserManagement();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button12.Text;
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text + button10.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            option = "+";
            op1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            option = "-";
            op1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "*";
           op1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "/";
            op1 = int.Parse(Display.Text);

            Display.Clear();

        }


        private void button17_Click(object sender, EventArgs e)
        {
            Node node = new Node();

            int option = node.PrintOperations();

            while (option >= 1 && option < node.Exit())
            {
                Console.Clear();
                Console.Write("Insert the value of the first operand: ");

                string op1 = Console.ReadLine();

                Console.Clear();
                Console.Write("Insert the value of the second operand: ");
                string op2 = Console.ReadLine();

                node.PerformOperation(
                    option,
                    op1,
                    op2);

                option = node.PrintOperations();
            }

            Display.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            option = "mod";
            op1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            option = "^";
            op1 = int.Parse(Display.Text);

            Display.Clear();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
