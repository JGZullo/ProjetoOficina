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
    public partial class Inicial : Form
    {

        private static string host = "localhost";
        private static string database = "db";
        private static string userId = "root";
        private static string userPwd = "root";
        private static string ConnectionString = "Server=" + host + 
                                                 ";Database=" + database +
                                                 ";Uid=" + userId + ";Pwd=" + userPwd + ";";

        public Inicial()
        {
            InitializeComponent();
        }

        private void BTNtudo_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM estoque";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            LSTestoq.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetInt32(2).ToString());
                item.SubItems.Add(reader.GetString(3));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetString(6));
                LSTestoq.Items.Add(item);
            }

            reader.Close();
            cmd.Dispose();
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LSTestoq.View = View.Details;
            LSTestoq.Columns.Add("Nome", 230);
            LSTestoq.Columns.Add("Código", 110);
            LSTestoq.Columns.Add("Quantidade", 80);
            LSTestoq.Columns.Add("Bandeja", 80);
            LSTestoq.Columns.Add("Corredor", 80);
            LSTestoq.Columns.Add("Prateleira", 80);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fechar;
            fechar = MessageBox.Show("Deseja mesmo sair? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (fechar == DialogResult.No)
                e.Cancel = true;
        }
        
        private void BTNsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LSTestoq_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = LSTestoq.SelectedItems[0];
            //label aplicação
            LBLaplic.Text = item.SubItems[6].Text;
            //group box atualizar dados
            TXTatzNome.Text = item.SubItems[0].Text;
            TXTatzCod.Text = item.SubItems[1].Text;
            TXTatzQtd.Text = item.SubItems[2].Text;
            TXTatzBandej.Text = item.SubItems[3].Text;
            TXTatzCorred.Text = item.SubItems[4].Text;
            TXTatzPratel.Text = item.SubItems[5].Text;
            TXTatzAplic.Text = item.SubItems[6].Text;
        }

        private void BTNnovo_Click(object sender, EventArgs e)
        {
            Novo FormNovo = new Novo();
            FormNovo.Owner = this;
            FormNovo.Show();
        }

        private void LBKajuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicialAjuda FormInicialAjuda = new InicialAjuda();
            FormInicialAjuda.Owner = this;
            FormInicialAjuda.Show(); 
        }
    }
}
