using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Cviko2
{
    [Serializable()]
    public class Ucet : INotifyPropertyChanged
    {

        public string Majitel { get; set; }
        private float _zustatek = 0;
        public float Zustatek
        {
            get
            {
                return _zustatek;
            }
            set
            {
                _zustatek = value;
                OnPropertyChanged("Zustatek");
            }
        }
        public float Kontokorent { get; set; } = 10000;


        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        /// <param name="m">majitel</param>
        public Ucet(string m)
        {
            this.Majitel = m;
        }
        /// <summary>
        /// Konstruktor třídy
        /// </summary>
        /// <param name="m">majitel</param>
        /// <param name="z">zustatek</param>
        /// <param name="k">kontokorent</param>
        public Ucet(string m, float z, float k)
        {
            this.Majitel = m;
            this.Zustatek = z;
            this.Kontokorent = k;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="v">Vstup</param>
        public void Vloz(float v)
        {
            if (v >= 0)
                this.Zustatek += v;
            else
                throw new MyGenericException("Vstup nesmí být záporné číslo");
        }
        public void Vyber(float v)
        {
            if (v >= 0)
            {
                if (this.Kontokorent > 0)
                {
                    if (v <= (Zustatek + Kontokorent))
                    {
                        this.Zustatek -= v;
                    }
                    else
                        throw new MyOtherEx("Není dostatečný zůstatek a vyčerpali jste kontokorent");
                }
                if (this.Kontokorent == 0)
                {
                    if (v <= Zustatek)
                        this.Zustatek -= v;
                    else {
                        throw new MyGenericException("Není dostatečný zůstatek");
                        throw new MyOtherEx("");
                }
                }
            }
            else
                throw new MyGenericException("Vstup nesmí být záporné číslo");


            //   if (v >= 0)
            //   {
            //       if (v < Zustatek)
            //           this.Zustatek -= v;
            //       else
            //           throw new MyGenericException("Není dostatečný zůstatek");
            //   }
            //   else
            //       throw new MyGenericException("Vstup nesmí být záporné číslo");
        }
        public float DisponabilniZustatek()
        {
            return this.Kontokorent + this.Zustatek;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string property = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }


}
