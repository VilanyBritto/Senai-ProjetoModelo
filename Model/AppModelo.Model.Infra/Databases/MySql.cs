namespace AppModelo.Model.Infra.Databases
{/// <summary>
/// Classe com dados de acesso para comunicar-se e conectar-se ao servidor do banco de dados.
/// </summary>
    public static class MySql
    {
        public static string ConnectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline14;uid=wwonline14;password=aluno22senai;";
            return conn;
        }
    }
}

