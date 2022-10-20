using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System.Collections;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);

            //var service = new Email.service();
            // usa-se o código acima caso queira enviar e-mail ao setor para informar que houve alteração ou inclusão
            return resposta;
        }

        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;

        }

    }
}
