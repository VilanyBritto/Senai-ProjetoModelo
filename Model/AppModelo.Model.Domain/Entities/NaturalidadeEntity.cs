using MySql.Data.Types;
using System;

namespace AppModelo.Model.Domain.Entities
{
    /// <summary>
    /// Implementação da classe  NaturalidadeEntity com suas propriedades, esse modelo irá espelhar as tabelas do banco de dados.
    /// </summary>
    public class NaturalidadeEntity
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
