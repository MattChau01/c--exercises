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

            // If Statements (continued)

                // Comparison operators:
                // `>` greater than
                // `<` less than
                // `>=` greater than or equal to
                // `<=` less than or equal to
                // `!=` not equal to

            Console.WriteLine("Max number is: " + (GetMax2(20, 10)));

            Console.WriteLine("Max number is: " + (GetMax3(30, 25, 99)));

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

        static int GetMax2(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            } else
            {
                result = num2;
            }

            return result;
        }

        static int GetMax3(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
        }

    }
}
