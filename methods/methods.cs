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

            // Methods

            // *** Methods are similar to `functions` in JavaScript ***

            // The `SayHi` method is being called in the `Main` container to print the line to console.
            SayHi("Matt", 24);
            SayHi("Jane", 25);
            SayHi("Tiff", 26);

            Console.WriteLine("\n");

            Farewell("Matt");
            Farewell("Jane");
            Farewell("Tiff");

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

        // `void` = is a return type, `void` will specifically NOT return any information
        // `SayHi` is a new name for a new method. Use capital for first letter
        // Methods can take in parameter(s) to pass values in.

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static void Farewell(string name)
        {
            Console.WriteLine("Nice to meet you " + name + ". See you later!");
        }
    }
}
