using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using AppModelo.View.Windows.Listas;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastro
{
    /// <summary>
    /// Este formulátio permite o usuário a rotina  de castrastro, atualização ou detelar dados do funcionário por meio da tela de FUNCIONARIO localizada
    /// dentro do menu CADASTRO na tela principal. Essa rotina processa validações com classes do Controller de cadastro interno, externo e de segurança,
    ///controles relacionados com classes da Model entidade,classes de validação de cpf e e-mail, sql banco de dados, e classe do repositorio.
    /// 
    /// </summary>
    public partial class frmCadastroFuncionario : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();


        /// <summary>
        /// O construtor está instanciando três classes: FuncionárioController(),NacionalidadeController(), NaturalidadeController(). 
        /// O InitializeComponent() inicializa os campos cmbNacionalidade e cmbNaturalidade é reconhecida com dado da lista.
        /// </summary>
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);

            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";

            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
        }

        /// <summary>
        /// Classe instanciada
        /// Recebo os dados do metódo para obter o endereço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Classe instanciada
            var cepController = new ViaCepController();

            //Recebo os dados do metódo para obter o endereço
            var endereco = cepController.Obter(txtCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;

        }

        /// <summary>
        /// Primeira regra para verificar se o nome é < que 6 letras.
        /// verifica se digitou algum número.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            // primeira regra para verificar se o nome é < que 6 letras.
            if(txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }

            // verifica se digitou algum número.
            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Um nome não pode conter números");
                    return;
                }
            }

            errorProvider.Clear();

        }

        /// <summary>
        /// Validação do controle do dado cpf.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);

            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF inválido!");
                return;
            }
            
            errorProvider.Clear();
        }

        /// <summary>
        ///  Validação do controle do dado e-mail.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(email);

            if (emailEhValido is false)
            {
                errorProvider.SetError(txtEmail, "E-mail inválido!");
                return;
            }

            errorProvider.Clear();
        }
        /// <summary>
        ///  Validação do dado data de nascimento, conversão e instanciando a classe DateTime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDataNascimento_Validated(object sender, EventArgs e)
        {
            try
            {
                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                var dataHoje = DateTime.Now;

                if (dataNascimento > dataHoje)
                {
                    errorProvider.SetError(txtDataNascimento, "Você não pode informar a data de hoje");
                    return;
                }

                errorProvider.Clear();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                int numero = int.Parse(txtEnderecoNumero.Text);
                char sexo = rbMasculino.Checked ? 'M' : 'F';
                var salvou = _funcionarioController.Cadastrar(txtNome.Text, dataNascimento, sexo, txtCpf.Text, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtCep.Text, txtEnderecoLogradouro.Text, numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text, 1, 1);

                if (salvou)
                {
                    MessageBox.Show("Cadastrado com sucesso");
                    limpaForm();

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário");
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }
        /// <summary>
        /// Limpar os campos após confirmar cadastro no botão Cadastrar (btnCadastrar), direcionar o foco notxtNome para novo cadastro.
        /// </summary>
        void limpaForm()
        {
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtCpf.Text = "";
            cmbNacionalidade.SelectedIndex = -1; //-1 pois a base é 0, quero carregar com algo que não está na lista.
            cmbNaturalidade.SelectedIndex = -1;
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtCep.Text = "";
            txtEnderecoLogradouro.Text = "";
            txtEnderecoNumero.Text = "";
            txtEnderecoComplemento.Text = "";
            txtEnderecoBairro.Text = "";
            txtEnderecoMunicipio.Text = "";
            txtEnderecoUf.Text = "";

            txtNome.Focus();
        }

        /// <summary>
        /// Método atualizar dados de cadatro do formulário de cadastro do funcionário, o campo cpf e nacionalidade só poderá ser atualizado em caracter de exceção 
        /// exceção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            char sexo = rbMasculino.Checked ? 'M' : 'F'; // Expressão Operador ternário, tenho variavel do tipo caracter (pesquisar)
            var atualizarDado = _funcionarioController.AtualizarCadastroFuncionario(
            int.Parse(txtId.Text), txtNome.Text, DateTime.Parse(txtDataNascimento.Text), sexo, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text,
            txtCep.Text, txtEnderecoLogradouro.Text, int.Parse(txtEnderecoNumero.Text), txtEnderecoComplemento.Text, txtEnderecoBairro.Text,
            txtEnderecoMunicipio.Text, txtEnderecoUf.Text, 2);
               

            if (atualizarDado = true)
            {
                MessageBox.Show("Dado atualizado com sucesso", "Sucesso ao atualizar!" + MessageBoxIcon.Information + MessageBoxButtons.OK);           
            }

            else
            {
                MessageBox.Show("Ocorreu um poblema ao atualizar o dado, tente novamente.", "Problema ao atualizar!!" + MessageBoxIcon.Error + MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Este método, dentro do formulário de cadastro do frmCadastroFuncionario.cs abre o formulário com a lista dos funcionários cadastrados .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTodosFuncionarios_Click(object sender, EventArgs e)
        {
            var form = new frmListaFuncionarios();
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// Esse metodo carrega o formulario com a relação de funcionarios para possivel pesquisa. Após carregado o formulario e selecionado um registro do datagrid
        /// é instancia um objeto funionario para que os dados sejam carregados no formulario de edição do cadastro.
        /// a condição if e else do campo sexo lê o campo do bando de dados e seta o radio buton de acordo com o valor registrado no banco de dados;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisarIdFuncionario_Click(object sender, EventArgs e)
        {
            frmListaFuncionarios f = new frmListaFuncionarios();
            f.ShowDialog();
            txtId.Text = f.id.ToString();
            txtNome.Text = f.funcionario.Nome_Completo;
            txtDataNascimento.Text = f.funcionario.Data_Nascimento.ToString();
            txtCpf.Text = f.funcionario.Cpf;
            txtEmail.Text = f.funcionario.Email;
            txtEnderecoLogradouro.Text = f.funcionario.Logradouro;
            txtEnderecoMunicipio.Text = f.funcionario.Municipio;
            txtTelefone.Text = f.funcionario.Telefone;
            txtTelefoneContato.Text = f.funcionario.Telefone_Contato;
            txtEnderecoNumero.Text = f.funcionario.Numero.ToString();
            txtEnderecoComplemento.Text = f.funcionario.Complemento;
            txtCep.Text = f.funcionario.Cep;
            txtEnderecoBairro.Text = f.funcionario.Bairro;
            txtEnderecoUf.Text = f.funcionario.Uf;
            if (f.funcionario.Sexo == 'M')
            {
                rbFeminino.Checked = false;
                rbMasculino.Checked = true;
            }
            else
            {
                rbFeminino.Checked = true;
                rbMasculino.Checked = false;
            }

        }
    }
}
