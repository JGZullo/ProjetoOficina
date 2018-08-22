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
            AtualizarTabelaCompleta();
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
            AtualizarTabelaCompleta();
        }

        private void AtualizarTabelaCompleta()
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

        private void AtualizarTabelaLinha(string primaryKey)
        {
            LSTestoq.Items.RemoveByKey(primaryKey);
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM estoque WHERE codigo= '" + primaryKey + "';";
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
                LSTestoq.Items.Insert(LSTestoq.Items.Count, item);
            }


            reader.Close();
            cmd.Dispose();
            connection.Close();
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

        string atzNome = ""; string atzCod = ""; string atzQtd = ""; string atzBandej = "";
        string atzCorred = ""; string atzPratel = ""; string atzAplic = "";
        ListViewItem item;

        private void LSTestoq_MouseClick(object sender, MouseEventArgs e)
        {
            item = LSTestoq.SelectedItems[0];
            //label aplicação
            LBLaplic.Text = item.SubItems[6].Text;
            //group box atualizar dados
            atzNome = TXTatzNome.Text = item.SubItems[0].Text;
            atzCod = TXTatzCod.Text = item.SubItems[1].Text;
            atzQtd = TXTatzQtd.Text = item.SubItems[2].Text;
            atzBandej = TXTatzBandej.Text = item.SubItems[3].Text;
            atzCorred = TXTatzCorred.Text = item.SubItems[4].Text;
            atzPratel = TXTatzPratel.Text = item.SubItems[5].Text;
            atzAplic = TXTatzAplic.Text = item.SubItems[6].Text;
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

        private void BTNatualizar_Click(object sender, EventArgs e)
        {
            DialogResult atualizar;
            if (LSTestoq.SelectedItems.Count == 1)
            {
                string msgDadosAtualizados = "";
                string dadosSql = "";
                if (!TXTatzNome.Text.Equals(atzNome))
                {
                    msgDadosAtualizados += "Nome\n";
                    dadosSql += "nome= '" + TXTatzNome.Text + "'";
                }

                if (!TXTatzCod.Text.Equals(atzCod))
                {
                    if (!dadosSql.Equals(""))
                        dadosSql += ",";

                    dadosSql += "codigo= '" + TXTatzCod.Text + "'";
                    msgDadosAtualizados += "Código\n";
                }
                if (!TXTatzQtd.Text.Equals(atzQtd))
                {
                    if (!dadosSql.Equals(""))
                        dadosSql += ",";

                    dadosSql += "quantidade= " + Convert.ToInt32(TXTatzQtd.Text);
                    msgDadosAtualizados += "Quantidade\n";
                }

                if (!TXTatzBandej.Text.Equals(atzBandej))
                {
                    if (!dadosSql.Equals(""))
                        dadosSql += ",";

                    dadosSql += "bandeja= '" + TXTatzBandej.Text + "'";
                    msgDadosAtualizados += "Bandeja\n";
                }

                if (!TXTatzCorred.Text.Equals(atzCorred))
                {
                    if (!dadosSql.Equals(""))
                        dadosSql += ",";

                    dadosSql += "corredor= '" + TXTatzCorred.Text + "'";
                    msgDadosAtualizados += "Corredor\n";
                }

                if (!TXTatzPratel.Text.Equals(atzPratel))
                {
                    if (!dadosSql.Equals(""))
                        dadosSql += ",";

                    dadosSql += "prateleira= '" + TXTatzPratel.Text + "'";
                    msgDadosAtualizados += "Prateleira\n";
                }

                if (!TXTatzAplic.Text.Equals(atzAplic))
                {
                    if (!dadosSql.Equals(""))
                        dadosSql += ",";

                    dadosSql += "aplicacao= '" + TXTatzAplic.Text + "'";
                    msgDadosAtualizados += "Aplicação\n";
                }

                
                if (!msgDadosAtualizados.Equals(""))
                {
                    atualizar = MessageBox.Show("Você irá atualizar os seguintes dados: \n" + msgDadosAtualizados +
                                                "Deseja continuar?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (atualizar == DialogResult.Yes)
                    {
                        item = LSTestoq.SelectedItems[0];
                        MySqlConnection connection = new MySqlConnection(ConnectionString);
                        connection.Open();
                        string sql = "UPDATE estoque SET " + dadosSql + " WHERE codigo= '" + item.SubItems[1].Text + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        reader.Close();
                        cmd.Dispose();
                        connection.Close();

                        AtualizarTabelaLinha(item.SubItems[1].Text);
                        atualizar = MessageBox.Show("Os dados foram alterados com sucesso.\n" + sql, "Mensagem do Sistema", MessageBoxButtons.OK);
                    }
                    else
                        atualizar = MessageBox.Show("Não houve alteração nos dados do produto.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    atualizar = MessageBox.Show("Não houve alteração nos dados do produto.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                atualizar = MessageBox.Show("Selecione um produto da tabela 'Estoque' para atualizar.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TXTproc_Click(object sender, EventArgs e)
        {

        }

        private void TXTproc_Leave(object sender, EventArgs e)
        {

        }

        private void TXTproc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
