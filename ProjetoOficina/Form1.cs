using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM estoque";
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            
                
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LSTestoq.View = View.Details;
            LSTestoq.Columns.Add("Código", 110);
            LSTestoq.Columns.Add("Nome", 230);
            LSTestoq.Columns.Add("Quantidade", 110);
            LSTestoq.Columns.Add("Bandeja", 230);
            LSTestoq.Columns.Add("Corredor", 230);
            LSTestoq.Columns.Add("Prateleira", 220);
        }
    }
}
