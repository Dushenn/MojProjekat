using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNeki
{
    class Osoba
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string jmbg { get; set; }
        public int godiste;

        public Osoba(string im, string pre, string j, int god)
        {
            ime = im;
            prezime = pre;
            jmbg = j;
            godiste = god;
        }
        public int Godine()
        {
            return DateTime.Today.Year - godiste;
        }

        public override string ToString()
        {
            return ime + " " + prezime + " (" + Godine() + ", " + jmbg + ")";
        }
    }
}
