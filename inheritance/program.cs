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

            // Inheritance

                // One class will inherit all functionality of another class

            Console.WriteLine("Chef One: ");
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            Console.WriteLine("\n");

            // `ItalianChef` is a 'sub class' of the 'super class' `Chef`. `ItalianChef` inherits all
            // functionality inside the `Chef` class on top of additional methods declared in the `ItalianChef` class.
            Console.WriteLine("Chef Two: ");
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
