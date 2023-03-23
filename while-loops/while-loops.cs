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

            // While Loops

                // `do while` loop will execute code inside the loop once before it checks for the condition.
                // `while` loops will keep executing code as long as the condition is still true.

            Console.WriteLine("`do while` loop: ");

            int index = 6;

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);


            Console.WriteLine("\n");

            Console.WriteLine("Countdown timer with `while` loop: ");

            int countdown = 10;

            while (countdown >= 0)
            {
                Console.WriteLine(countdown);
                countdown--;
            }

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
