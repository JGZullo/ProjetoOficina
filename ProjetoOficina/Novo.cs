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

        private void Novo_Load(object sender, EventArgs e)
        {

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
    }
}
