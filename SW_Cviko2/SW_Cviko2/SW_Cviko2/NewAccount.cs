using Microsoft.SqlServer.Server;
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
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void button_AddClient_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
            {
                throw new MyGenericException("Chybí Jméno");
            }
            else
            {
                
                Database.Ucty.Add(new Ucet(textBox_Name.Text, (float)numericUpDown_Zustatek.Value, (float)numericUpDown_Kontokorent.Value));
            }
        }
    }
}
