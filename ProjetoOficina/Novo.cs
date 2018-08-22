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

        ListViewColumnSorter lvwColumnSorter;
        DialogResult messageBox;
        

        private void Novo_Load(object sender, EventArgs e)
        {
            ActiveControl = TXTnovoNome;

            LSTrecente.View = View.Details;
            LSTrecente.Columns.Add("Nome", 100);
            LSTrecente.Columns.Add("Código", 80);
            LSTrecente.Columns.Add("Quantidade", 80);
            LSTrecente.Columns.Add("Bandeja", 80);
            LSTrecente.Columns.Add("Corredor", 80);
            LSTrecente.Columns.Add("Prateleira", 80);
            LSTrecente.Columns.Add("Aplicação", 130);

            lvwColumnSorter = new ListViewColumnSorter();
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
            
        }

        private void BTNnovo_Click(object sender, EventArgs e)
        {
            tentarCadastro();
        }

        private void tentarCadastro()
        {
            if ((TXTnovoNome.Text.Equals("") || TXTnovoNome.Text == null) || (TXTnovoCod.Text.Equals("") || TXTnovoCod.Text == null))
                messageBox = MessageBox.Show("Os campos 'Nome' e 'Código' não podem estar vazios.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if ((TXTnovoBandej.Text.Equals("") || TXTnovoBandej.Text == null) || (TXTnovoCorred.Text.Equals("") || TXTnovoCorred.Text == null) || (TXTnovoPratel.Text.Equals("") || TXTnovoPratel.Text == null) || (TXTnovoAplic.Text.Equals("") || TXTnovoAplic.Text == null))
                {
                    messageBox = MessageBox.Show("Um dos campos de cadastro está vazio. Cadastrar um produto desta forma pode trazer problemas para encontrá-lo no sistema, no futuro.\n" +
                                                 "Deseja continuar mesmo assim?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (messageBox == DialogResult.Yes)
                    {
                        cadastrar();
                    }
                    else
                    {
                        messageBox = MessageBox.Show("A operação foi cancelada.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    cadastrar();
            }
        }

        private void cadastrar()
        {
            try
            {
                connection = new MySqlConnection(ConnectionString);
                connection.Open();

                string sql = "INSERT INTO estoque (nome, codigo, quantidade, bandeja, corredor," +
                             "prateleira, aplicacao) VALUES " +
                             "('" + TXTnovoNome.Text + "','" + TXTnovoCod.Text + "','" + NMCqtd.Value.ToString() + "','" + TXTnovoBandej.Text +
                             "','" + TXTnovoCorred.Text + "','" + TXTnovoPratel.Text + "','" + TXTnovoAplic.Text + "');";

                cmd = new MySqlCommand(sql, connection);
                reader = cmd.ExecuteReader();

                ListViewItem item = new ListViewItem(TXTnovoNome.Text);
                item.SubItems.Add(TXTnovoCod.Text);
                item.SubItems.Add(NMCqtd.Value.ToString());
                item.SubItems.Add(TXTnovoBandej.Text);
                item.SubItems.Add(TXTnovoPratel.Text);
                item.SubItems.Add(TXTnovoAplic.Text);
                item.SubItems.Add(TXTnovoCorred.Text);
                LSTrecente.Items.Add(item);

                TXTnovoNome.Clear(); TXTnovoCod.Clear(); NMCqtd.Value = 0; TXTnovoBandej.Clear();
                TXTnovoPratel.Clear(); TXTnovoAplic.Clear(); TXTnovoCorred.Clear();

                reader.Close();
                cmd.Dispose();
                connection.Close();

                messageBox = MessageBox.Show("O cadastro foi realizado com sucesso.", "Mensagem do Sistema", MessageBoxButtons.OK);
                ActiveControl = TXTnovoNome;
            }
            catch (MySqlException e)
            {
                messageBox = MessageBox.Show("Erro de cadastro: " + e.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LSTrecente_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.LSTrecente.Sort();
        }

        private void BTNlimpar_Click(object sender, EventArgs e)
        {
            LSTrecente.Clear();
        }

        
    }
}
