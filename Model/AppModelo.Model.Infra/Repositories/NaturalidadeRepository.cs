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
    public class NaturalidadeRepository // contém os comandos sql que vai ser usado no meu BD
    {
        //CRUD  =  creat(insert)  -  read (select (inserir))  -  update (update)  -  delete (delete)
        public bool Inserir(string descricao, bool status)
        {

            //String interpolation
            var agora = DateTime.Now.ToString("u"); //*("yyyy-MM-dd H:mm:ss");
            var sql = $"INSERT INTO naturalidades (descricao, dataCriacao, dataAlteracao, ativo) VALUES ('{descricao}','{agora}','{agora}', {agora})";
           
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql); //creat e insert usa o comando . Execute
            return resultado > 0;
           
            //*var dataCriacao = agora;
            //*var dataAlteracao = agora;
            
        }

        public bool Atualizar()
        {
            return false;
        }

        public bool Remover()
        {
            return false;
        }

        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM naturalidades ORDER BY descricao DESC";
            //  var sql = "SELECT * FROM naturalidades";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);
            // se for select, obterporId, ObterTodos usa-se o Query
            return resultado;

        }

        public IEnumerable<NaturalidadeEntity> ObterTodosAtivos()
        {
            var sql = "SELECT id, descricao FROM naturalidade WHERE ativo = true";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public NacionalidadeEntity ObterPorId()
        {
            return new NacionalidadeEntity();
        }
        public NaturalidadeEntity ObterPorDescricao(string descricao)
        {
            var sql = $"SELECT id, descricao FROM naturalidade WHERE descricao = '{descricao}' ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<NaturalidadeEntity>(sql);

            return resultado;
        }
    }
}

