using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNeki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo je prva osoba:");
            Osoba Prva = new Osoba("Dusan", "Popovic", "040700412345", 2004);
            Console.WriteLine(Prva);
            Console.ReadKey();
        }
    }
}
