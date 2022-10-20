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

namespace AppModelo.View.Windows
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
            var controller = new NacionalidadeController();
            var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Nacionalidade incluída com sucesso");    
                txtDescricao.Text = String.Empty;
            }
            else
            {

                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
        }
    }
}
