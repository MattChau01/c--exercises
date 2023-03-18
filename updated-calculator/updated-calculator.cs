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

            // Updated Calculator

            Console.Write("Enter a number: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");

            string op = Console.ReadLine();

            Console.Write("Enter a number: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else
            {
                Console.WriteLine("Invalid operator");
            }

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
