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

            // Building an Exponent Method

            Console.WriteLine("Get the value of 3 to the power of 2");
            Console.WriteLine(GetPower(3, 2));

            Console.WriteLine("\n");

            Console.WriteLine("Get the value of 5 to the power of 3");
            Console.WriteLine(GetPower(5, 3));

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

        static int GetPower(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

    }

}
