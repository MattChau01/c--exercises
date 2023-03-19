using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Movie
    {

        // `public` - anyone or any program can use this
        // `private` - only the code nested inside the class can use this data

        public string title;
        public string director;
        private string rating;

        // Constructor here
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        // GETTER / SETTER
        public string Rating
        {
            get { return rating; }
            // `get` allows us to GET a private value
            set {
                // `set` will SET rules for users to assign a value
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "Not a valid movie rating";
                }
            }
        }

    }
}
