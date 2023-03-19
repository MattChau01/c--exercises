using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Song
    {
        // normal attributes:
        public string title;
        public string artist;
        public int duration;

        //static attributes:
            // the static attribute can only be accessed through the entire class.
            // ex: will have to write `Console.WriteLine(Song.songCount);`
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            // increments the `songCount` each time an instance/object of the class is created
            songCount++;
        }

        public int getSongCount()
            // We can call this on the Program as a method of the object that was just created to find the `songCount`.
            // ex: `Console.WriteLine(kashmir.getSongCount());`
        {
            return songCount;
        }

    }
}
