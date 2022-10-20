using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
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
    
    public partial class frmCadastroFuncionario : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Crio a instância do controllador
            var cepController = new ViaCepController();

            //Recebo os dados do método obter para o enderço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if(txtNome.Text.Length < 6) // A propriedade Leangth consegue definir o tamanho do texto 
            {
                errorProvider.SetError(txtNome,"Digite seu nome completo");
                return;
            }
           
            //Foreach = erifica se digitou algum número
            foreach(var letra in txtNome.Text) //letra por letra dentro do nome e verificar se algum é número
            {
                if(char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece estar errado");
                    return ;

                }
            }
            errorProvider.Clear();
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf); 
            if(cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return;
            }
            errorProvider.Clear();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhValido = Validadores.ValidarEmail(email);
            if (emailEhValido is false)
            {
                errorProvider.SetError(txtCpf, "E-mail Inválido");
                return;
            }
            errorProvider.Clear();
        }

        private void txtDataNascimento_Validating(object sender, CancelEventArgs e)
        {
           // var dataNascimento = txtDataNascimento.Text;
            var dataNascimentoEhValido = DateTime.Parse(txtDataNascimento.Text);
            var dataNascimentoReal = (DateTime.Now.AddDays(1));
            
            if (dataNascimentoEhValido > dataNascimentoReal)
            {
                errorProvider.SetError(txtDataNascimento, "Data de Nascimento Inválida");
                return;
            }
            errorProvider.Clear();
        }
    }
}
