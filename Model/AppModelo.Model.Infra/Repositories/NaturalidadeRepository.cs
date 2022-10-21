using AppModelo.Model.Domain.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        public class NaturalidadeRepository // contém os comandos sql que vai ser usado no meu BD
        {
            //CRUD  =  creat(insert)  -  read (select (inserir))  -  update (update)  -  delete (delete)
            public bool Inserir(string descricao)
            {

                //String interpolation
                var sql = $"INSERT INTO nacionalidades (descricao) VALUES ('{descricao}')";
                using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
                var resultado = conexaoBd.Execute(sql); //creat e insert usa o comando . Execute
                return resultado > 0;
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
                var sql = "SELECT id, descricao FROM nacionalidades ORDER BY descricao DESC";
                //  var sql = "SELECT * FROM nacionalidades";
                using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

                var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);
                // se for select, obterporId, ObterTodos usa-se o Query
                return resultado;

            }

            public NaturalidadeEntity ObterPorId()
            {
                return new NaturalidadeEntity();
            }

        }
    }
}
