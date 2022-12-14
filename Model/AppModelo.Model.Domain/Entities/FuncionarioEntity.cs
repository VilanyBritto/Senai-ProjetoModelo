using System;

namespace AppModelo.Model.Domain.Entities
{
    /// <summary>
    /// Implementação da classe FuncionarioEntity com suas propriedades, esse modelo irá espelhar as tabelas do banco de dados.
    /// </summary>
    public class FuncionarioEntity
    {
        public int Id { get; set; }
        public string Nome_Completo { get; set; }
        public DateTime? Data_Nascimento { get; set; }
        public char Sexo { get; set; }
        public string Cpf { get; set; }
        public  int Nacionalidade { get; set; }
        public int Naturalidade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Telefone_Contato { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
    }
}
