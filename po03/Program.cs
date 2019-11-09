using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po03
{
    class Program
    {
        static Player player;
        static void Main(string[] args)
        {
            player = new Player();

            for (;;)
            {
                if (!showMenu()) break;
            }
        }

        static bool showMenu()
        {
            Console.WriteLine("1. Odtwórz wszystkie utwory.");
            Console.WriteLine("2. Dodaj utwor.");
            Console.WriteLine("3. Usun utwor.");
            Console.WriteLine("3. Wyjdź");

            string input = Console.ReadLine();
            int index;
            if (!int.TryParse(input, out index))
            {
                Console.WriteLine("Błędne dane wejściowe.");
                return true;
            }

            if (index < 1 || index > 4)
            {
                Console.WriteLine("Liczba z poza zakresu.");
                return true;
            }

            switch (index)
            {
                case 1: PlayAllSongs(); break;
                case 2: AddSong(); break;
                case 3: RemoveSong(); break;
            }

            return false;
        }

        static void PlayAllSongs()
        {
            player.PlayAllSongs();
        }

        static void AddSong()
        {
            Console.WriteLine("Podaj utwór.");
            string utwor;
            Console.WriteLine("Podaj wykonawce.");
            string wykonawca;
            Console.WriteLine("Podaj gatunek.");
            string gatunek;        
        }

        static void RemoveSong()
        {

        }

        static void Exit()
        {

        }
    }
}
