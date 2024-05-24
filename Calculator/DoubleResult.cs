using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DoubleResult : Result
    {
        private double value;

        public DoubleResult(double val)
        {
            value = val;
        }

        public override object GetValue()
        {
            return value;
        }
    }
}
