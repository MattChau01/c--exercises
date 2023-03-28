using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The italian chef makes pasta");
        }

        // overiding method: specialDish
        // the `override` will overwrite the `virtual` class declared in the super class
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
