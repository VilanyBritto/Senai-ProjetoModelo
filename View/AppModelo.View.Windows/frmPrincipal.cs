using AppModelo.View.Windows.Cadastro;
using AppModelo.View.Windows.Listas;
using System;
using System.Windows.Forms;


namespace AppModelo.View.Windows
{
    /// <summary>
    /// Após carregar a tela de login, o próximo passo é a tela principal que contém o menustrip com menu CADASTRO onde contém os submenus para acessar as 
    /// telas de: FUNCIONÁRIO, NACIONALIDADE E NATURALIDADE. 
    /// </summary>
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este método private void novoFuncionárioToolStripMenuItem_Click em tela, representa o submenu funcionário dentro do menu CADASTRO na qual 
        /// permite acessar a tela de FUNCIONÁRIO para cadastrar ou atualizasr dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void novoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        /// <summary>
        /// Este método private void nacionalidadeToolStripMenuItem_Click em tela, dentro do menu CADASTRO, permite acessar o submenu nacionalidade para 
        /// cadastrar,atualizar ou deletar dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nacionalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// Este método private void naturalidadeToolStripMenuItem_Click em tela, dentro do menu CADASTRO, permite acessar o submenu naturalidade para 
        /// cadastrar,atualizar ou deletar dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidades();
            form.MdiParent = this;
            form.Show();
        }

        /// <summary>
        ///  Este método dentro do formulário principal, abre o formulário com a lista dos funcionários cadastrados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void listaFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmListaFuncionarios();
            form.MdiParent = this;
            form.Show();
        }
    }
}
