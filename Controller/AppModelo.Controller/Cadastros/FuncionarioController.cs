using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppModelo.Model.Domain.Validators.Validadores;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        public bool Cadastrar(string nome, DateTime dataNascimento, char sexo, string cpf, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Inserir(nome, dataNascimento, sexo, cpf, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidade, naturalidade);
            return resposta;
        }

        public bool AtualizarCadastroFuncionario(int id,string nome, DateTime dataNascimento, char sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int naturalidade)
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.Atualizar (id , nome, dataNascimento, sexo,email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf,naturalidade);
            return resposta;
        }

        public List<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionarioRepository();
            var resposta = repositorio.ObterTodos();
            return (List<FuncionarioEntity>)resposta;
        }
    }

}
