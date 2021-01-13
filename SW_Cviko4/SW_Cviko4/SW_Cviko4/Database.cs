using System.ComponentModel;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SW_Cviko4
{
    public static class Database
    {
        public static BindingList<Zakaznik> Zakaznici { get; private set; } = new BindingList<Zakaznik>();
        public static BindingList<Disk> Sklad { get; private set; } = new BindingList<Disk>();
        public static BindingList<Disk> Vypujcky { get; private set; } = new BindingList<Disk>();
        public static void Init()
        {
            Zakaznici.Add(new Zakaznik("Pepe", "Novy", 1998));
            Zakaznici.Add(new Zakaznik("Nene", "Starý", 2010));
            Zakaznici.Add(new Zakaznik("Josef", "Levý", 1900));
            Sklad.Add(new Disk.Cd("CD1", "Hudba1", 100, "Hudebník1"));
            Sklad.Add(new Disk.Dvd("DVD1", "Fantasy", 100, "Reziser1"));
            Sklad.Add(new Disk.Cd("CD2", "Hudba2", 100, "Hudebník2"));
            Sklad.Add(new Disk.Dvd("DVD1", "Sci-fi", 100, "Reziser2"));
        }

        public static void Serializuj<T>(BindingList<T> list, string file)
        {
            using (Stream s = File.Open(file, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<T>));
                XmlWriter writer = new XmlTextWriter(s, Encoding.UTF8);
                serializer.Serialize(writer, list);
            }
        }

        public static void Serializuj()
        {
            Serializuj(Sklad, "Sklad.xml");
            Serializuj(Zakaznici, "Zakaznici.xml");

        }
        public static BindingList<T> Deserializuj<T>(string file)
        {
            using (Stream s = File.Open(file, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BindingList<T>));
                return (BindingList<T>)serializer.Deserialize(s);
            }
        }
        public static void Deserializuj()
        {
            Sklad = Deserializuj<Disk>("Sklad.xml");
            Zakaznici = Deserializuj<Zakaznik>("Zakaznici.xml");
        }

    }
}