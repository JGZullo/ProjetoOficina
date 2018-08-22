using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOficina
{
    public partial class Novo : Form
    {
        public Novo()
        {
            InitializeComponent();
        }

        protected static string host = "localhost";
        protected static string database = "db";
        protected static string userId = "root";
        protected static string userPwd = "root";
        protected static string ConnectionString = "Server=" + host +
                                                 ";Database=" + database +
                                                 ";Uid=" + userId + ";Pwd=" + userPwd + ";";

        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        

        private void Novo_Load(object sender, EventArgs e)
        {
            LSTrecente.View = View.Details;
            LSTrecente.Columns.Add("Nome", 230);
            LSTrecente.Columns.Add("Código", 110);
            LSTrecente.Columns.Add("Quantidade", 80);
            LSTrecente.Columns.Add("Bandeja", 80);
            LSTrecente.Columns.Add("Corredor", 80);
            LSTrecente.Columns.Add("Prateleira", 80);

            ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
            LSTrecente.ListViewItemSorter = lvwColumnSorter;
        }

        private void BTNvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LBKajuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NovoAjuda FormNovoAjuda = new NovoAjuda();
            FormNovoAjuda.Owner = this;
            FormNovoAjuda.Show();
        }

        private void Novo_FormClosed(object sender, FormClosedEventArgs e)
        {
            BTNnovo.Enabled = true;
        }

        private void BTNnovo_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sql = "INSERT INTO estoque (nome, codigo, quantidade, bandeja, corredor," +
                         "prateleira, aplicacao) VALUES " +
                         "('"+TXTnovoNome.Text+"','"+TXTnovoCod.Text+"','"+TXTnovoQtd.Text+"','"+TXTnovoBandej.Text+
                         "','"+TXTnovoCorred.Text+"','"+TXTnovoPratel.Text+"','"+TXTnovoAplic.Text+"');";
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();


            reader.Close();
            cmd.Dispose();
            connection.Close();
        }
    }
}
