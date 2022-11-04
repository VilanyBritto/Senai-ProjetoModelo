using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionarioRepository
    {
        public bool Inserir(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionarios (id int NOT NULL,\r\n    id_naturalidades INT NOT NULL,\r\n    id_nacionalidades INT NOT NULL,\r\n    nome VARCHAR(250) NOT NULL,\r\n    data_nascimento DATE NOT NULL,\r\n    genero TINYINT NOT NULL,\r\n    cpf VARCHAR(14) NOT NULL,\r\n    email VARCHAR(250) NOT NULL,\r\n    telefone VARCHAR(14) NOT NULL,\r\n    telefone_contato VARCHAR(14),\r\n    cep VARCHAR(9) NOT NULL,\r\n    logradouro VARCHAR(250) NOT NULL,\r\n    numero INT(50) NOT NULL,\r\n    complemento VARCHAR(250),\r\n    bairro VARCHAR(250) NOT NULL,\r\n    municipio VARCHAR(250) NOT NULL,\r\n    uf VARCHAR(2) NOT NULL,\r\n    CONSTRAINT pk_funcionarios_id PRIMARY KEY (id),\r\n    CONSTRAINT fk_nacionalidades_id FOREIGN KEY (id_nacionalidades) REFERENCES nacionalidades(id),\r\n    CONSTRAINT fk_naturalidades_id FOREIGN KEY (id_naturalidades) REFERENCES naturalidades(id)) VALUES ('{nome}', '{dataConvertida}', {sexo}, '{email}', '{telefone}', '{telefone_contato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {nacionalidade}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}

