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

            // Working with strings

                // special character: `\n` creates a new line
                // `\` (backslash) can be used as an escape character

                // Adding the `+` concatenates strings together.
                string phrase = "Giraffe Academy" + " is cool.";
                Console.WriteLine(phrase);


                // METHODS:

                // The `.length` method of a variable specifies the total character count in the string.
                Console.WriteLine("length of the variable `phrase`: " + phrase.Length);

                // The `.ToUpper` method of a variable makes all characters upper cased.
                Console.WriteLine("ToUpper `phrase`: " + phrase.ToUpper());

                // The `.ToLower` method of a variable makes all characters lower cased.
                Console.WriteLine("ToLower `phrase`: " + phrase.ToLower());

                // The `.Contains()` method of a variable prints a boolean value whether the variable
                // contains the specific string/int/ value.
                Console.WriteLine("Contains('Giraffe') `phrase`: " + phrase.Contains("Giraffe"));

                // Using `[]` brackets and specifying an index, will print out the character of the specified index.
                Console.WriteLine("`phrase` at the index of 0: " + phrase[0]);

                // The `IndexOf()` method will print if a string contains a value AND the index where the key FIRST starts at
                Console.WriteLine("IndexOf('Academy') in `phrase`: " + phrase.IndexOf("Academy"));

                // The `Substring()` method will grab a piece of the string and prints to the screen.
                // parameters: (`index of`, `length of characters you want`)
                Console.WriteLine("SubString(8) in `phrase`: " + phrase.Substring(8, 7));

                // Keeps console open until pressed "enter" on keyboard to close.
                Console.ReadLine();
        }
    }
}
