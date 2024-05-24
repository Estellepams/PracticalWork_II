﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    public class Modulus : Operation
    {
        public Modulus(string name, string symbol) : base(name, symbol)
        {


        }

        public override Result Operate(int op1, int op2)
        {
            return new IntegerResult(op1 % op2);
        }
        public override Result Operate(double op1, double op2)
        {
            return null;
        }

        /*
        public override void Print(int op1, int op2, int result)
        {
            Console.WriteLine($"{op1} {this.symbol} {op2} = {result}");
        }
        */
    }
}
