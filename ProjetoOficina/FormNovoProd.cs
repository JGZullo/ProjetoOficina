using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOficina
{
    public partial class FormNovoProd : UserControl
    {
        public FormNovoProd()
        {
            InitializeComponent();
        }

        private void BTNcancel_Click(object sender, EventArgs e)
        {
            TXTnome.Text = null;
            TXTcodigo.Text = null;
            TXTaplic.Text = null;
            TXTqtd.Text = null;
            this.Hide();
        }

        private void BTNadd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
