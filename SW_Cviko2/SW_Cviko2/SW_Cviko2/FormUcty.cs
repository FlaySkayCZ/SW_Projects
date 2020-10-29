using SW_Cviko2.Properties;
using System;
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
    public partial class FormUcty : Form
    {
        public FormUcty()
        {
            InitializeComponent();
            Database.Deserialize_My();
            dataGridView_Ucty.DataSource = Database.Ucty;
        }

        private void button_Transaction_Click(object sender, EventArgs e)
        {
            if (dataGridView_Ucty.Rows.Count != 0)
            {
                int cisloRadku = dataGridView_Ucty.CurrentRow.Index;
                Ucet u = Database.Ucty[cisloRadku];

                Transakce t = new Transakce();
                t.SetUcet(u);
                t.ShowDialog();
            }
            else
                throw new MyGenericException("Není vybrán žádný řadek");

        }
        private void FormUcty_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Serialize_My();
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {

            string filtr = textBox_Filter.Text;
            if (filtr == "")
                dataGridView_Ucty.DataSource = Database.Ucty;
            if (filtr != "")
            {
                dataGridView_Ucty.DataSource = Database.FiltrujDleMajitele(filtr);

                if (dataGridView_Ucty.Rows.Count == 0)
                {
                    MessageBox.Show("Filtr nic nenašel");
                    dataGridView_Ucty.DataSource = Database.Ucty;
                }
            }
        }

        private void button_NewAccount_Click(object sender, EventArgs e)
        {
            var m = new NewAccount();
            m.Show();
        }

        private void button_deleteAccount_Click(object sender, EventArgs e)
        {
            if (dataGridView_Ucty.Rows.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Jste si jisti že chcete smazat tento řádek", "Smazání účtu", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    dataGridView_Ucty.Rows.Remove(dataGridView_Ucty.CurrentRow);

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
                throw new MyGenericException("Není vybrán žádný řadek");

        }
    }
}
