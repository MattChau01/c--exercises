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

            // Variables

            // `string` declares a string, or text
            string characterName = "Nate";

            // `int` declares an integer, or number
            int characterAge;
            characterAge = 25;


            Console.WriteLine("There once was a man named " + characterName );
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Jason";
            characterAge = 28;

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            // Keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }
    }
}
