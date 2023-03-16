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

            // Arrays

              // Arrays will hold multiple values in a single variable.
              // Decalre the type of variable (string/int/double), followed by `[]`, a variable name,
              // an assignment operator, `{ `elements here` }`
              int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

              Console.WriteLine("`luckyNumber` at the index of 3: " + luckyNumbers[3]);

              // The values can be reassigned as such:

              luckyNumbers[0] = 99;

              Console.WriteLine("`luckyNumber` at the index of 0: " + luckyNumbers[0]);

              Console.WriteLine("\n");

              // If the values in an array is not yet known. Below, we can assign `new string[`parameter`]` to
              // the array `friends`. The parameter will hold the number of values this array can hold.
              string[] friends = new string[5];

              friends[0] = "Jim";
              friends[1] = "Kelly";
              friends[2] = "Matt";
              friends[3] = "Derek";
              friends[4] = "Teddy";

              Console.WriteLine("`friends` at the index of 2: " + friends[2]);

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }
    }
}
