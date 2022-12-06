using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    /// <summary>
    /// Este formulário apresenta em tela campos com a finalidade de cadastrar a nacionalidade para ser representada por meio de ID no formulário de cadastro quando solicitada.
    /// </summary>
    public partial class frmNacionalidades : Form
    {
        /// <summary>
        /// Método estancia NacionalidadeController()
        /// </summary>
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController(); 

        /// <summary>
        /// A lista recebe e armazena os dados de nacionalidades em tela.  
        /// </summary>
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades; 
        }

        /// <summary>
        /// A lista tem os dados carregados atualizados de nacionalidades em tela após cadastro, atualização ou exclusão.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
            {
                var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);

                if (salvou)
                {
                    MessageBox.Show("Nacionalidade incluída com sucesso");
                    txtDescricao.Text = string.Empty;

                    atualizaGrid();
                }

                else
                {
                    MessageBox.Show("Houve um erro ao salvar no banco de dados");

                }
            }

            else
            {
                MessageBox.Show("Digite um dado válido!");
            }
        }
        /// <summary>
        /// Método para atualizar os dados de nacionalidade e apresentar em lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizarNacionalidades_Click(object sender, EventArgs e)
        {
            
            var atualizarDado = _nacionalidadeController.AtualizarDado(int.Parse(txtId.Text), txtDescricao.Text.ToUpper());

            if (atualizarDado = true)
            {
                MessageBox.Show("Dado atualizado com sucesso", "Sucesso ao atualizar!" + MessageBoxIcon.Information + MessageBoxButtons.OK);
                atualizaGrid();
            }

            else
            {
                MessageBox.Show("Ocorreu um poblema ao atualizar o dado, tente novamente.", "Problema ao atualizar!!" + MessageBoxIcon.Error + MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Método para deletar os dados de nacionalidade e apresentar a lista atualizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletarNacionalidades_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _nacionalidadeController.Deletar(id);
                MessageBox.Show("Nacionalidade deletado com sucesso");
                txtDescricao.Text = string.Empty;
            atualizaGrid();
        }

        /// <summary>
        /// Tem a função de atualizar os dados e apresentar na Grid, null limpa os dados do DataGrid, o método 
        /// _nacionalidadeController.ObterTodasNacionalidades() apresenta a lista atualizada
        /// </summary>
        void atualizaGrid()
        {
            gvNacionalidades.DataSource = null;_nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
        }
    }
}
