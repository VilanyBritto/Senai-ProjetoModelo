using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    /// <summary>
    /// Essa classe é a camada responsável pela comunicação do formulário frmCadastroFuncionario com o banco de dados
    /// </summary>
    public class FuncionarioRepository
    {
        public bool Inserir(string nome, DateTime dataNascimento, char sexo, string cpf, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var dataConvertida = dataNascimento.ToString("dd-MM-yyyy");

            var sql = $"INSERT INTO funcionarios (nome_completo, data_nascimento, sexo, cpf, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, fk_nacionalidade, fk_naturalidade) " +
                $"VALUES ('{nome}', {dataConvertida}, '{sexo}', '{cpf}', '{email}', '{telefone}', '{telefone_contato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {nacionalidade}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;

            //var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            //var sql = $"INSERT INTO funcionarios (nome_completo, data_nascimento, sexo, cpf, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, fk_nacionalidade, fk_naturalidade) VALUES ({nome}, {dataConvertida}, {sexo}, {cpf}, {email}, {telefone}, {telefone_contato}, {cep}, {logradouro}, {numero}, {complemento}, {bairro}, {municipio}, {uf}, {nacionalidade}, {naturalidade})";
            //using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());
            //var resultado = conexaoBd.Execute(sql);

            //return resultado > 0;
        }
        public bool Atualizar(int id, string nome, DateTime dataNascimento, char sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int naturalidade)
        {
            var sqlNat = $"select n.id from naturalidades n where n.descricao = '{naturalidade}'";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var sql = $"UPDATE funcionarios SET nome_completo = '{nome}', data_nascimento= '{dataNascimento}', sexo='{sexo}', email='{email}', telefone ='{telefone}', telefone_contato= '{telefone_contato}', cep='{cep}',logradouro='{logradouro}',numero={numero},complemento='{bairro}',municipio='{municipio}',uf='{uf}',naturalidade= '{naturalidade}' WHERE id = {id}";     
            
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }

        public IEnumerable<FuncionarioEntity> ObterTodosFuncionarios()
        {
            var sql = "SELECT * FROM funcionarios ORDER BY nome_completo ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConnectionString());

            var resultado = conexaoBd.Query<FuncionarioEntity>(sql);

            return resultado;
        }
    }
}
