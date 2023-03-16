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

            // Building a calculator

            // Converting a string into a number
            // Use `Convert` operator with a method `ToInt` to convert a string into a number

              int num = Convert.ToInt32("45");
              Console.WriteLine("`num` plus 6: " + (num + 6));

              Console.WriteLine("\n");

            // Using user input to calculate

              Console.Write("Enter a number: ");
              int num1 = Convert.ToInt32(Console.ReadLine());

              Console.Write("Enter a number: ");
              int num2 = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Sum of `num1` and `num2`: " + (num1 + num2));

              Console.WriteLine("\n");

            // If adding decimals, use `ToDouble` rather than `ToInt`

              Console.Write("Enter a number: ");
              double num3 = Convert.ToDouble(Console.ReadLine());

              Console.Write("Enter a number: ");
              double num4 = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("Sum of `num3` and `num4`: " + (num3 + num4));

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }
    }
}
