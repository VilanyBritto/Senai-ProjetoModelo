using AppModelo.Controller.Cadastros;
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
        public frmListaFuncionarios()
        {
            InitializeComponent();
        }

        private void gvCarregarListaFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var listaDeFuncionarios = FuncionarioController.ObterTodosFuncionarios();
            gvCarregarListaFuncionario.DataSource = listaDeFuncionarios;

            // gvNacionalidades.DataSource = null; _nacionalidadeController.ObterTodasNacionalidades();
            // gvNacionalidades.DataSource = _nacionalidadeController.ObterTodasNacionalidades();

            // var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            // gvNacionalidades.DataSource = listaDeNacionalidades;

            if (txtConsultarListaFuncionarioPorId.Text =  )
            {

            }
            else
            {

            }
        }
    }
}
