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

            // Building a Mad Libs game

              // multiple variables can be decalred and assigned as such
              string color, pluralNoun, celebrity;

              Console.Write("Enter a color: ");
              color = Console.ReadLine();

              Console.Write("Enter a pluralNoun: ");
              pluralNoun = Console.ReadLine();

              Console.Write("Enter a celebrity: ");
              celebrity = Console.ReadLine();

              Console.WriteLine('\n');

              Console.WriteLine("Roses are " + color);
              Console.WriteLine(pluralNoun + " are blue");
              Console.WriteLine("I love " + celebrity);

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }
    }
}
