

using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;


namespace AppModelo.View.Windows
{
    /// <summary>
    /// Este é um software de cadastro de funcionário que tem a finalidade de realizar cadastro, atualizar dados e/ou deletar.
    ///O software é composto formulários na qual são representados por pelas ao usuário, sendo tela login, tela principal e pelas telas que compoem as rotinas
    ///formulários de naturalidade, nacionalidade e tela recuperar senha. As telas se comunicam e armazenam informações no banco de dados.
    /// </summary>
    public partial class frmLogin : Form
    {
        /// <summary>
        /// A tela frmLogin contará com a inicialização tendo os textbox pré-preenchidos com os dados de e-mail e senha podendo ser alterados.
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
            txtEmail.Text = "vilanybritto@gmail.com";
            txtSenha.Text = "BAC4D542";
           
        }

        /// <summary>
        /// O método private void btnEntrar_click é um evento definido ao botão da tela de login para ao clicar acessar a tela principal.
        /// Este método contém condições de validação do formato do e-mail, foco do cursor para indicar o campo a ser preenchido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;

            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "E-mail é inválido");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);

            if (usuarioEncontrado)
            {
                var form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrado");
            }

        }
        /// <summary>
        /// Este método referencia o frmRecuperarSenha, permite o usuário acessar os comandos de solicitação de recuperação de senha.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.Show();
            this.Hide();
        }

    }
}
