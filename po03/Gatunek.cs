using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po03
{
    abstract class Gatunek
    {
        private readonly string brzmienie;

        protected Gatunek(string brzmienie)
        {
            this.brzmienie = brzmienie;
        }

        public void Play()
        {
            Console.WriteLine(string.Format("brzmienie {0}", brzmienie));
        }
    }
}
