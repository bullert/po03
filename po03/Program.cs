using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po03
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("imie", "nazwisko");

            Console.WriteLine(string.Format("Imie: {0}\nNazwisko: {1}", student.Imie, student.Nazwisko));
            Console.ReadKey();
        }
    }
}
