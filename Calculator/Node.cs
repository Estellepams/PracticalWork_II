using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Node
    {
        List<Operation> operations;

        public Node()
        {
            this.operations = new List<Operation>();

            this.operations.Add(new Add("Add", "+"));
            this.operations.Add(new subtract("Subtract", "-"));
            this.operations.Add(new Divide("Divide", "/"));
            this.operations.Add(new Multiply("Multiply", "*"));
            this.operations.Add(new Power("Power", "^"));
            this.operations.Add(new Modulus("Modulus", "%"));
        }
        public int Exit()
        {
            return this.operations.Count + 1;
        }

        public int PrintOperations()
        {
            Console.Clear();

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("-----------Activity VI----------------");
            Console.WriteLine("--------------------------------------");

            for (int i = 0; i < this.operations.Count; i++)
            {
                Console.WriteLine($" {i + 1}. {this.operations[i].GetName()}");
            }

            Console.WriteLine($" {this.Exit()}. Exit");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Enter the number of your option: ");
            Console.WriteLine();
            string tmp = Console.ReadLine();

            if (tmp == "") return this.Exit();

              int option;
            if (!int.TryParse(tmp, out option) || option < 1 || option > this.Exit())
            {
                return this.Exit();
            }

            return option;
        }
        private Boolean IsDecimalOperation(string op1, string op2)
        {
            bool DecimalOp = false;

            if (op2.Contains(".") || op2.Contains(".")) DecimalOp = true;
            if (op2.Contains(",") || op2.Contains(",")) DecimalOp = true;

            return DecimalOp;

        }

        public void PerformOperation(int op, string op1, string op2)
        {
            Result result ;
            if (IsDecimalOperation(op1, op2))
            {
                result = this.operations[op - 1].Operate(
                    Double.Parse(op1),
                    Double.Parse(op2));
            }
            else
            {
                result = this.operations[op - 1].Operate(
                    Int32.Parse(op1),
                    Int32.Parse(op2));
            }

            if (result != null)
            {
                this.operations[op - 1].Print(op1, op2, result);
            }
            else
            { Console.WriteLine("This operation cannot be perfomed."); }
        }
    }
}