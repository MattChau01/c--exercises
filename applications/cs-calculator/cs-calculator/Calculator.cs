using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_calculator
{
    internal class Calculator
    {
        public static double Calculate(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                case "%":
                    result = num1 % num2;
                    break;
                default:
                    break;
            }
            return result;
        }

    }
}
