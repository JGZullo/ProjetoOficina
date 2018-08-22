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

        string atzNome; string atzCod; string atzQtd; string atzBandej; string atzCorred; string atzPratel; string atzAplic;

        private void LSTestoq_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = LSTestoq.SelectedItems[0];
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
            string msgDadosAtualizados = "";
            if (!TXTatzNome.Text.Equals(atzNome))
                msgDadosAtualizados += "Nome\n";
            if (!TXTatzCod.Text.Equals(atzCod))
                msgDadosAtualizados += "Código\n";
            if (!TXTatzQtd.Text.Equals(atzQtd))
                msgDadosAtualizados += "Quantidade\n";
            if (!TXTatzBandej.Text.Equals(atzBandej))
                msgDadosAtualizados += "Bandeja\n";
            if (!TXTatzCorred.Text.Equals(atzCorred))
                msgDadosAtualizados += "Corredor\n";
            if (!TXTatzPratel.Text.Equals(atzPratel))
                msgDadosAtualizados += "Prateleira\n";
            if (!TXTatzAplic.Text.Equals(atzAplic))
                msgDadosAtualizados += "Aplicação\n";

            if (!msgDadosAtualizados.Equals(""))
            {
                atualizar = MessageBox.Show("Você irá atualizar os seguintes dados: \n" + msgDadosAtualizados +
                                            "Deseja continuar?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (atualizar == DialogResult.Yes)
                {
                    //código para atualizar banco de dados vai aqui


                    atualizar = MessageBox.Show("Os dados foram alterados com sucesso.", "Mensagem do Sistema", MessageBoxButtons.OK);
                }
                else
                    atualizar = MessageBox.Show("Não houve alteração nos dados do produto.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                atualizar = MessageBox.Show("Não houve alteração nos dados do produto.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
    }
}
