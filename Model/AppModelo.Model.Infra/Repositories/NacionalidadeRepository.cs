using AppModelo.Model.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository // contém os comandos sql que vai ser usado no meu BD
    {
        //CRUD  -  creat(insert)  -  read (select (inserir))  -  update (update)  -  delete (delete)
        public bool Inserir() { }

        public bool Atualizar(int id) { }

        public bool Remover() { }

        public Lista<NacionalidadeEntity> ObterTodos() 
        {
            var sql = "SELECT * FROM nacionalidades";
        }

        public NacionalidadeEntity ObterPorId() { }
     
    }
}
