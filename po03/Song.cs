using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po03
{
    class Song
    {
        private string tytul;
        private string wykonawca;
        private Gatunek gatunek;

        public Song(string tytul, string wykonawca, Gatunek gatunek)
        {
            this.tytul = tytul;
            this.wykonawca = wykonawca;
            this.gatunek = gatunek;
        }

        public void Play()
        {
            Console.WriteLine(string.Format("Tytuł: {0}", tytul));
            Console.WriteLine(string.Format("Wykonawca: {0}", wykonawca));
            gatunek.Play();
        }
    }
}
