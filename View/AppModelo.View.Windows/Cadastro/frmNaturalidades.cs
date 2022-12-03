using AppModelo.Controller.Cadastros;
using AppModelo.Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    public partial class frmNaturalidades : Form
    {    
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();

        public frmNaturalidades()
        {
            InitializeComponent();
           // txtId.Enabled = false;

           gvNaturalidades.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            //var listaDeNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
           // gvNaturalidades.DataSource = listaDeNaturalidades;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "")
            {
                var charEhNumero = Helpers.Componentes.CharEhNumero(txtDescricao.Text);

                if (charEhNumero)
                {
                    errorProvider1.SetError(txtDescricao, "Naturalidade não pode conter números");
                    txtDescricao.Focus();
                    return;

                }

                string descricao = txtDescricao.Text.ToUpper();

                var salvou = _naturalidadeController.Cadastrar(descricao, chkAtivo.Checked);

                MessageBox.Show("Naturalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;

                atualizaGrid();
            }
            else
            {
                MessageBox.Show("Digite um dado válido!");
            }
        }

        private void btnAtualizarNaturalidade_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var atualizarDado = _naturalidadeController.AtualizarDado(id, txtDescricao.Text.ToUpper());

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

        private void btnDeletarNaturalidade_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletou = _naturalidadeController.Deletar(id);
            if (deletou)
            {
                MessageBox.Show("Dado deletado com sucesso!", "Naturalidade deletada", MessageBoxButtons.OK, MessageBoxIcon.Information);
               gvNaturalidades.DataSource = _naturalidadeController.ObterTodasNaturalidades();
               txtDescricao.Text = string.Empty;

               atualizaGrid();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao deletar uma naturalidade", "naturalidade não deletada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        void atualizaGrid()
        {
            gvNaturalidades.DataSource = null;
            gvNaturalidades.DataSource = _naturalidadeController.ObterTodasNaturalidades();
        }
    }
}
