using System;

namespace AppModelo.Model.Domain.Entities
{
    /// <summary>
    /// Implementação da classe  UsuarioEntity com suas propriedades, esse modelo irá espelhar as tabelas do banco de dados.
    /// </summary>
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime UltimoLogin { get; set; }
    }
}
