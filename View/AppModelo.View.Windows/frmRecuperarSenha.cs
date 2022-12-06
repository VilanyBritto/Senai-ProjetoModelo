using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
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
    /// <summary>
    /// Este formulário apresenta em tela campos com a funcionalidade de recuperação de senha.
    /// </summary>
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este método compõe a validação dos dados do campo e-mail para recuperar senha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecuperarAcesso_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;

            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "E-mail é inválido");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var resultado = controller.RecuperarSenha(txtEmail.Text);
            MessageBox.Show(resultado , "E-mail de recuperação enviado com sucesso!");


        }
        /// <summary>
        /// Este método valida o btnCancelar para cancelar a ação de recuperação de senha referenciando a tela de login para o usuário acessar com os dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new frmLogin();
            form.Show();
            this.Hide();
        }
    }
}
