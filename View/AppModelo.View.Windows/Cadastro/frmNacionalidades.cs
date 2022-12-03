using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController(); 
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades; 
        }

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

        private void btnDeletarNacionalidades_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _nacionalidadeController.Deletar(id);
                MessageBox.Show("Nacionalidade deletado com sucesso");
                txtDescricao.Text = string.Empty;
            atualizaGrid();
        }

        void atualizaGrid()
        {
            gvNacionalidades.DataSource = null;
            gvNacionalidades.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
        }
    }
}
