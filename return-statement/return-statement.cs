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

            // Return Statement

            int cubedNumber = cube(5);

            Console.WriteLine(cubedNumber);

            string greeting = SayHi("Matt");

            Console.WriteLine(greeting);

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

        // The return statment in this method is `int`. This will return an integer

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static string SayHi(string name)
        {
            string phrase = "Hello " + name + "!";
            return phrase;
        }
    }
}
