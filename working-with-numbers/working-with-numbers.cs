using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespace is the `draft project`
namespace Giraffe
{
    // class is a `container` for code
    internal class Program
    {
        // `Main` is a method/function
        static void Main(string[] args)
        {

            // Working with numbers

            int multiply = (5 * 8);
            Console.WriteLine("Value of `multiply`: " + multiply);

            // The `%` special character represents `modulus` or `modulo`.
            // Prints out the remainder of the 2 numbers.
            int remainder = (5 % 2);
            Console.WriteLine("Value of `remainder`: " + remainder);

            // Using `double` instead of `int` becuase of decimal values.
            double addDecimals = 4.2 + 6.3;
            Console.WriteLine("Value of `addDecimals`: " + addDecimals);

            // Using `++` will increment and `--` will decrement a value by 1.
            int increment = 9;
            increment++;
            Console.WriteLine("Value of `increment`: " + increment);

            // The `Math` operator can be used with methods for math operations.

              // The `Abs()` method will return an absolute value of a number.
              Console.WriteLine("The `Abs()` method of the Math operator:  " + Math.Abs(-40));

              // The `Pow()` method will return the value of an exponential number.
              // Takes 2 parameters, (`base number`, `to the nth power`)
              Console.WriteLine("The `Pow()` method of the Math operator:  " + Math.Pow(3,2));

              // The `Sqrt()` method will return the square root of a number.
              Console.WriteLine("The `Sqrt()` method of the Math operator:  " + Math.Sqrt(100));

              // The `Max()` method will print the largest integer out of 2 given parameters.
              Console.WriteLine("The `Max()` method of the Math operator:  " + Math.Max(1, 5));

              // The `Min()` method will print out the smallest integer out of 2 given parameters.
              Console.WriteLine("The `Min()` method of the Math operator:  " + Math.Min(-5, 8));

              // The `Round()` method will return a rounded number.
              // ex: (4.1) -> (4)
              // ex: (4.7) -> (5)
              Console.WriteLine("The `Round()` method of the Math operator:  " + Math.Round(55.6));

            // Keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }
    }
}
