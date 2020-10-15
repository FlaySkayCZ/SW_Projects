using SW_Cviko2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_Cviko2
{
    public static class Database
    {
        public static BindingList<Ucet> Ucty { get; set; }
                    = new BindingList<Ucet>();



        public static void Init() {
            Ucty.Add(new Ucet("Pepa Novák"));
            Ucty.Add(new Ucet("Franta Malý", 15000 ,0));
        }

    }
}
