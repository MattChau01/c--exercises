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

            // Getters and Setters

            /*
               Getters
               Setters
            */

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            shrek.Rating = "Cat";

            Console.WriteLine("User's actual input for Avengers movie rating: " + avengers.Rating);
            Console.WriteLine("Avengers movie viewer rating: " + avengers.Rating);
            Console.WriteLine("\n");
            Console.WriteLine("User's actual input for Shrek movie rating: " + shrek.Rating);
            Console.WriteLine("Shrek movie viewer rating: " + shrek.Rating);

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
