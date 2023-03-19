using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Book
    // `class`: specification for a new data type
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
            // `public Book` is the `constructor` for this class.
            // A `constructor` is a special method inside the class that will
            // be called when an object is being created from that class.
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
