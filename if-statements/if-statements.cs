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

            // If Statements

                // The `!` operator can be referred to as the negation operator. Represents the opposite value of a variable.
                // The `&&` operator is used to test whether 2 or more cases all true. Known as the `AND` operator.
                // The `||` operator is used to test whether only 1 case is true. Known as the `OR` operator.

            bool isMale = false;
            bool isTall = true;

            if (isMale && isTall) {
                Console.WriteLine("You are a tall male");

            } else if (isMale && !isTall) {
                Console.WriteLine("You are a short male");

            } else if (!isMale && isTall) {
                Console.WriteLine("You are not a male, but you are tall");

            }
            else {
                Console.WriteLine("You are not male and not tall");

            }

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }
}
