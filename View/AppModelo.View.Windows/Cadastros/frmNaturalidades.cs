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

namespace AppModelo.View.Windows.Cadastros
{
    
    public partial class frmNaturalidades : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidades()
        {
            InitializeComponent();

        }

       private void btnSalvar_Click(object sender, EventArgs e)
        {
            var controller = new frmNaturalidades();
            var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text);
            
            if (salvou)
            {
                MessageBox.Show("Naturalidade incluída com sucesso");
                txtDescricao.Text = String.Empty;
            }
            else
            {

                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxAtivo.Checked)
            //{
            //    checkBoxAtivo.Text = "Checked";
            //}
            //else
            //{
            //    checkBoxAtivo.Text = "Unchecked";
            //}
        }
    }
}
