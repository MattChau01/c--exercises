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

            // Constructors

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            /* `new Book()` is calling the `constructor` method defined in `Books.cs`
             With the `constructor` defined in `Book.cs`, a user can assign values directly via
             the parameter, rather than defining individually like below: */

            /*book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400; */

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine("\n");

            Book book2 = new Book("Lord of the Rings", "Tolkein", 700);

            /*book2.title = "Lord of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700; */

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
