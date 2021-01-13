using System.ComponentModel;

namespace SW_Cviko4
{
    public class Zakaznik
    {
        public Zakaznik(string jmeno, string prijmeni, int rok)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.RokNarození = rok;
        }

        public Zakaznik()
        {
        }

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int RokNarození { get; set; }

        public BindingList<Disk> Vypujcky = new BindingList<Disk>();
    }
}