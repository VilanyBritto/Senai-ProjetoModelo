using AppModelo.View.Windows.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFuncionario = new frmCadastroFuncionario();
            // formFuncionario.MdiParent = this;
            formFuncionario.Show();
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNacionalidades = new frmNacionalidades();
             formNacionalidades.MdiParent = this;
            formNacionalidades.Show();
        }

        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNaturalidades = new frmNaturalidades();
            formNaturalidades.MdiParent = this;
            formNaturalidades.Show();
        }
    }
}

