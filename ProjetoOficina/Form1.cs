using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace ProjetoOficina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNtudo_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Database=oficina;Uid=root;Pwd=root;";
            //MySqlConnection connection = new MySqlConnection(ConnectionString);
            //connection.Open();
            //MySqlCommand cmd = connection.CreateCommand();
            //cmd.CommandText = "SELECT * FROM estoque";
            //MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //adap.Fill(ds);
            //TBLestoq.
                
            
        }

        private void BTNnovo_Click(object sender, EventArgs e)
        {
            FormNovoProd novo = new FormNovoProd();
            novo.Show();
        }
    }
}
