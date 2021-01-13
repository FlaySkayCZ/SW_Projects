using System;
using System.Windows.Forms;

namespace SW_Cviko4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Database.Init();
            dataGridView_Sklad.DataSource = Database.Sklad;
           
            dataGridView_Zakaznici.DataSource = Database.Zakaznici;
        }

        private void buttonx_Vratit(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();

            dataGridView_Sklad.Rows.Add(dataGridView_Vypujceno.CurrentRow);
            dataGridView_Vypujceno.Rows.Remove(dataGridView_Vypujceno.CurrentRow);
            dataGridView_Sklad.Update();
            dataGridView_Vypujceno.Update();
                
        }

        

        private void buttonx_Vypujcit(object sender, EventArgs e)
        {
            dataGridView_Sklad.BeginEdit(true);
            dataGridView_Vypujceno.Rows.Add(dataGridView_Sklad.SelectedRows);
            dataGridView_Vypujceno.EndEdit();
            
            dataGridView_Sklad.Update();
            dataGridView_Vypujceno.Update();
        }
        private void From1_FormClosed(object sender, System.EventArgs e)
        {
            Database.Serializuj();
        }
    }
}