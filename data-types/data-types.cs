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

            // Data Types

            // A `string` will print out any form or size of text. Uses double quotation marks.
            string phrase = "Hello World";

            Console.WriteLine("Value of string: " + phrase);

            // A `char` will print a single character, such as a letter grade. It will not
            // take any more than 1 character.
            char grade = 'A';

            Console.WriteLine("Value of `char`: " + grade);

            // `int` represents an integer. It will take a number without any quotation marks.
            int age = 30;

            Console.WriteLine("Value of `int`: " + age);

            //There are 3 types of data that can represent a decimal:
            // `float`, `double`, `decimal`.
            // float is least accurate and decimal is most accurate.
            double gpa = 4.0;

            Console.WriteLine("Value of `double`: " + gpa);

            // a `boolean` value represents a 'true' or 'false'.
            bool isMale = true;

            Console.WriteLine("Value of `bool`: " + isMale);

            // Keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }
    }
}
