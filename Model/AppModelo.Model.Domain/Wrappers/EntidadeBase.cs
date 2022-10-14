using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Wrappers
{
    public abstract class  EntidadeBase 
     // Classe do tipo abstract não pode ser instaciada, não ua dentro do código, ela serve apenas como herança.
    {
        public string Erro { get; set; }

        public bool Sucesso { get; set; }
    }
}
