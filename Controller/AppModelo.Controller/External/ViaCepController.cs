using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;

namespace AppModelo.Controller.External
{
    /// <summary>
    /// Retorna a classe ViaCepWrapper
    /// </summary>
    public class ViaCepController
    {
        //Retorna a classe ViaCepWrapper
        public ViaCepWrapper Obter(string cep)
        {
            var service = new ViaCepService();
            var viaCep = service.ObterDaApi(cep);
            return viaCep;
        }
    }
}
