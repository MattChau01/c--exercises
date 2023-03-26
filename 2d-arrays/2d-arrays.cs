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

            // 2D Arrays

                // using a comma `,` inside a bracket `[]` will indicate how the number of dimensions in the array

            int[,] numberGrid = {
                { 1, 2 },
                { 3, 4 },
                { 5, 6 }
            };

            // You can do the following when you don't know how many elements will go inside the array.
                // in the bracket for `new int`, it is telling that there will be 2 elements with 3 elements inside it.

            int[,] myArray = new int[2, 3];


            Console.WriteLine("Value of numberGrid at indexes [1, 1]: ");
            Console.WriteLine(numberGrid[1, 1]);

            Console.WriteLine("Value of numberGrid at indexes [2, 0]: ");
            Console.WriteLine(numberGrid[2, 0]);

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
