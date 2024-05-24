using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Operation
    {
        protected string symbol;
        private string name;

        public Operation(string name, string symbol)
        {
            this.name = name;
            this.symbol = symbol;

        }
        public abstract Result Operate(int op1, int op2);
        public abstract Result Operate(double op1, double op2);

        public string GetName()
        {
            return this.name;
        }
        
        public void Print(string op1, string op2, Result result)
        {
            Console.Clear();
            Console.WriteLine($"{op1}{this.symbol}{op2} = {result.GetValue()}");
            Console.ReadLine();
        }
        
    }
}
