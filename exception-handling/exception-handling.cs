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

            // Exception Handling

            /* Any code in the `try` section will be ran, if there's something that breaks,
               it will execute the code in the `catch` section. */

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }

            /* catch (Exception e)
                // This catch has a parameter `Exception e`.
            {
                Console.WriteLine(e.Message);
                // This is going to print the message from the event that was just executed.
                // ex: `Attempted to divide by zero.`
            } */

            // Exceptions can be specified per instance as such:

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
             //Code in the `finally` block will ALWAYS be executed
            {
                Console.WriteLine("Equation complete");
            }

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
