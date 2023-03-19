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

            // Object Methods

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            /* Using the `HasHonors()` method from the `Student.cs` class to check whether a student
             is on the Honors Roll. */
            Console.WriteLine("Student 1 on the Honor Roll? " + student1.HasHonors());
            Console.WriteLine("Student 2 on the Honor Roll? " + student2.HasHonors());

            Console.WriteLine("\n");

            Console.WriteLine("Student 1 passing? " + student1.Passing());
            Console.WriteLine("Student 2 passing? " + student2.Passing());

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
