using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    /// <summary>
    /// Essa classe é a camada responsável pelo processo, respostas e requisições do frmNacionalidades
    /// </summary>
    public class NacionalidadeController
    {
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }

        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }

        public bool AtualizarDado(int id, string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }
        public void Deletar(int id)
        {
            var repositorio = new NacionalidadeRepository();
            repositorio.Deletar(id);
            //return resposta;
        }
    }
}
