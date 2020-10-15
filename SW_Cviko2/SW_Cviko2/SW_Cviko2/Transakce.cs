using System;
using SW_Cviko2.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Cviko2
{
    public partial class Transakce : Form
    {
        private Ucet _u;

        public void SetUcet(Ucet u)
        {
            this._u = u;
        }

        public Transakce()
        {
            InitializeComponent();
        }

        private void button_Transaction_Click(object sender, EventArgs e)
        {

            int item = comboBox1.SelectedIndex;
            decimal castka = numericUpDown1.Value;
            try
            {
                switch (item)
                {
                    case 0:

                        this._u.Vloz((float)castka);
                        this.Close();
                        break;
                    case 1:
                        this._u.Vyber((float)castka);
                        this.Close();
                        break;
                    default:
                        break;

                }
            }
            catch (MyGenericException ex)
            {

                MessageBox.Show(ex.Message);
            }






        }
    }
}