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
            //*não gravar repetido
            //*não gravar com texto
            //* todas maiusculas

            //*var controller = new frmNaturalidades();
            //*var controller = _naturalidadeController;
            //*var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text);
           
            
           /* if (salvou)
            {
                MessageBox.Show("Naturalidade incluída com sucesso");
                txtDescricao.Text = String.Empty;
            }
            else
            {

                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
           **/

            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);

            if (temNumero)
            {
                errorProvider1.SetError(txtDescricao, "Naturalidades geralmente não tem número");
                txtDescricao.Focus();
                return;
            }

            var controller = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            
            var resposta = controller.Cadastrar(descricaoMaiuscula, chkStatus.Checked);

        }

       
    }
}
