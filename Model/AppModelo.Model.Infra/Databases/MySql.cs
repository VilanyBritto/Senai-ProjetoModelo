namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        public static string ConectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline14;uid=wwonline14;password=aluno22senai;";
            return conn;
        }
    }
}
