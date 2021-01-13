using System.Xml.Serialization;

namespace SW_Cviko4
{
    [XmlInclude(typeof(Dvd)), XmlInclude(typeof(Cd))]
    public abstract class Disk
    {
        public string Nazev { get; set; }
        public string Zanr { get; set; }
        public int CenaVypujcky { get; set; }

        public Disk(string nazev, string zanr, int cena)
        {
            this.Nazev = nazev;
            this.Zanr = zanr;
            this.CenaVypujcky = cena;
        }

        public class Dvd : Disk
        {
            public bool Pristupny { get; set; }
            public string Reziser { get; set; }

            public Dvd(string nazev, string zanr, int cena, string reziser) : base(nazev, zanr, cena)
            {
                this.Reziser = reziser;
            }

            
        }

        public class Cd : Disk
        {
            public string Interpret { get; set; }

            public Cd(string nazev, string zanr, int cena, string interpret) : base(nazev, zanr, cena)
            {
                this.Interpret = interpret;
            }

            
        }
    }
}