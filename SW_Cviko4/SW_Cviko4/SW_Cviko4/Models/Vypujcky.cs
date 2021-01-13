using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Cviko4.Models
{
    class Vypujcky
    {
        public Vypujcky(string jmeno, string prijmeni, int rok)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.RokNarození = rok;
        }

        public Vypujcky()
        {
        }

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int RokNarození { get; set; }

        
    }
}
