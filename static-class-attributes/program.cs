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

            // Static Class Attributes

            // `static` - a attribute in a class that is shared between instances and objects of the class.
            // static attributes are the same for all objects in the same class.

            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.WriteLine(kashmir.getSongCount());

            // `ReadLine()` keeps console open until pressed "enter" on keyboard to close.
            Console.ReadLine();
        }

    }

}
