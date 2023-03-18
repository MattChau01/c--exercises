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

            // Switch statements

                // Checks multiple conditions. In some cases, switch statements are much clearer than `if statements`.
                // This exercise will convert numbers into days of the week.

            Console.WriteLine("The day of the week at number 0: " + GetDay(0));
            // Should print `Sunday`
            Console.WriteLine("The day of the week at number 4: " + GetDay(4));
            // Should print `Thursday`
            Console.WriteLine("The day of the week at number 10: " + GetDay(10));
            // Should print `Invalid Day Number`

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

        static string GetDay (int dayNum)
        {
            string dayName;

            switch (dayNum)
            // `switch` takes in a value and check if that value is equal to any variables.
            {
                case 0:
                // In the case that dayNum = 0, will run the folling code.
                    dayName = "Sunday";
                    break;
                    // Breaks out of the structure. Similar to a `return` in JS, will exit out of iteration.
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                // `default` is used like an `else` when a match expression does NOT match any other case pattern.
                // In this case, will be used for a error message.
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }

    }

}
