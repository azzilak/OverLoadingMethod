using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingMethod
{
    public class Numbers
    {
        public int FindMinimum (int number1, int number2) 
        {
            return Math.Min(number1, number2);
        }

        public int FindMinimum (params int [] values)
        {
            return Enumerable.Min(values);
        }

        public int FindMaximum (int number1, int number2)
        {
            return Math.Max(number1, number2);
        }

        public int FindMaximum (params int [] values)
        {
            return Enumerable.Max(values);
        }
    }
}
