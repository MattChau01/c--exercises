using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Short cut for comment: type out text/command/etc then press "ctrl" + "k" + "c"
            // This writes a line of text to the console.
            Console.WriteLine("Half Triangle");
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.WriteLine(" ");

            Console.WriteLine("Full Triangle");
            Console.WriteLine("   /\\ ");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" /    \\");
            Console.WriteLine("/______\\");

            // This keeps the console window open. Press the 'enter' key to exit the console.
            Console.ReadLine();
        }
    }
}
