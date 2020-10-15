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
            Database.Init();
            dataGridView_Ucty.DataSource = Database.Ucty;
        }

        private void button_Transaction_Click(object sender, EventArgs e)
        {
            int cisloRadku = dataGridView_Ucty.CurrentRow.Index;
            Ucet u = Database.Ucty[cisloRadku];

            Transakce t = new Transakce();
            t.SetUcet(u);
            t.ShowDialog();
        }
    }
}
