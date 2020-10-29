using SW_Cviko2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SW_Cviko2
{
    public static class Database
    {
        private static readonly string fileName = "ucty.bin";
        public static BindingList<Ucet> Ucty { get; set; }
                    = new BindingList<Ucet>();

        public static BindingList<Ucet> FiltrujDleMajitele(string majitel)
        {
            var vysledek = from u in Ucty
                           where u.Majitel.Contains(majitel)
                           select u;
            return new BindingList<Ucet>(vysledek.ToList());
        }

        public static void Serialize_My()
        {
            using (Stream s = File.Open(fileName, FileMode.Create))
            {
                BinaryFormatter b = new BinaryFormatter();
                b.Serialize(s, Ucty);
            }

        }
        public static void Deserialize_My()
        {
            using (Stream s = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter b = new BinaryFormatter();
                Ucty = (BindingList<Ucet>)b.Deserialize(s);
            }
        }


    }
}

