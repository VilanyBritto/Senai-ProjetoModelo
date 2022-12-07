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

namespace AppModelo.View.Windows.Listas
{  
    public partial class frmListaFuncionarios : Form
    {
        public int id { get; set; }
        public FuncionarioEntity funcionario { get; set; }

        private FuncionarioController _FuncionarioController = new FuncionarioController();
        public frmListaFuncionarios()
        {
            InitializeComponent();

            
        }

        private void frmListaFuncionarios_Load(object sender, EventArgs e)
        {
            var listaDeFuncionarios = _FuncionarioController.ObterTodosFuncionarios();
            gvCarregarListaFuncionario.DataSource = listaDeFuncionarios;
        }

        private void gvCarregarListaFuncionario_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                FuncionarioEntity f = new FuncionarioEntity();
                f.Id = id;
                f.Bairro = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
                f.Cep = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["cep"].Value.ToString();
                f.Complemento = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
                f.Cpf = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
                f.Nome_Completo = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["nome_completo"].Value.ToString();
                f.Data_Nascimento = Convert.ToDateTime(gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["data_nascimento"].Value);
                f.Email = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["email"].Value.ToString();
                f.Logradouro = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["logradouro"].Value.ToString();
                f.Municipio = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["municipio"].Value.ToString();
                f.Uf = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["uf"].Value.ToString();
                f.Nacionalidade = Convert.ToInt16(gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["nacionalidade"].Value);
                f.Naturalidade = Convert.ToInt16(gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["naturalidade"].Value);
                f.Numero = Convert.ToInt32(gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["numero"].Value);
                f.Sexo = Convert.ToChar(gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["sexo"].Value);
                f.Telefone = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
                f.Telefone_Contato = gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["telefone_contato"].Value.ToString();
                
                funcionario = f;
                id = Convert.ToInt32(gvCarregarListaFuncionario.Rows[e.RowIndex].Cells["id"].Value);
            }

        }

        /// <summary>
        /// Esse metodo faz com que o evendo 2 click's com o mouse faz o fechamento do formulario de consulta;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvCarregarListaFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// esse metodo executa a consulta dos funcionarios filtrando por cpj. Ao dar dois click no registro desejado o mesmo 
        /// é carregado na tela de cadastro/edição.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtConsultarListaFuncionarioPorCpf_TextChanged(object sender, EventArgs e)
        {
            var dados = _FuncionarioController.ObterTodosFuncionarios();
            gvCarregarListaFuncionario.DataSource = null;
            gvCarregarListaFuncionario.DataSource = (from item in dados
                                                     where item.Cpf.Contains(txtConsultarListaFuncionarioPorCpf.Text)
                                                     select item).ToList();
        }
    }
}
