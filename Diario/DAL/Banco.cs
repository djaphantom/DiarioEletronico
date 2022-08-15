using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Banco
    {

        public string vqueryCidade = @"SELECT Id, NomeCidade FROM Cidade order by Id";

        public string vquerySEXO = @"SELECT Id, SEXO FROM Sexo order by Id";

        public string vqueryUF = @"SELECT Id, NomeUF FROM UF order by Id";

        public string vqueryTurma = @"SELECT Id, Serie FROM Turma order by Id";

        public string NOTAS = @"SELECT ALUNO.Id,NomeAluno FROM Aluno INNER JOIN Turma AS T ON Aluno.Id_Turma = T.Id WHERE Serie = '1 A'";

        public static DataTable dql(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                SqlConnection cn = new SqlConnection();

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, cn);
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
