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

            // Building a guessing game

            string secretWord = "giraffe";

            string guess = "";

            int guessCount = 0;

            int guessLimit = 3;

            bool outOfGuesses = false;

            // WITH A `DO WHILE` LOOP

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            } while (guess != secretWord && !outOfGuesses);

            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
            Console.WriteLine("You Win!");
            }

            // WITH A `WHILE` LOOP

            //while (guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {

            //    Console.Write("Enter guess: ");
            //    guess = Console.ReadLine();
            //    guessCount++;

            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }
            //}

            //if (outOfGuesses)
            //{
            //    Console.Write("You Lose!");
            //}
            //else
            //{
            //    Console.Write("You Win!");
            //}

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
