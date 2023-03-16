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

            // Getting user input

            // `WriteLine` prints out a line of text, then goes on to the next line.
            // `Write()` will print out on the same line.
            Console.Write("Enter your name: ");

            // Using `ReadLine()` will run program and wait for user to make an input
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.Write("Enter your age: ");

            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", you are " + age);

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }
    }
}
