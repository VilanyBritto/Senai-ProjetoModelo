using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        //Retorna a classe ViacepWapper
        public ViaCepWrapper Obter(string cep)
        {
           var service = new ViaCepService();
            //FAKE CONSULTA
            var viaCep = service.ObterDaApi(cep);

            
            return viaCep;
        }
    }
}
