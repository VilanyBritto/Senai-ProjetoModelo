using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);

            if(emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu e-mail está errado");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
         
            var usuarioencontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuarioencontrado)
            {
                var form = new frmPrincipal();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario ou senha não encontrado");
            }

        }
    }
}
//faltou update de nacionalidade e naturalidade e colocar aqui e-mail