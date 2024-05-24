using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class IntegerResult : Result
    {
        private int value;

        public IntegerResult(int val)
        {
            value = val;
        }

        public override object GetValue()
        {
            return value;
        }
    }
}
