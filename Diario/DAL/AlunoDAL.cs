using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AlunoDAL
    {
        public Aluno Inserir(Aluno _aluno)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirAluno";

                cmd.Parameters.Add(new SqlParameter ("@Id", SqlDbType.Int)
                {
                    Value = _aluno.ID
                });

                cmd.Parameters.Add(new SqlParameter("@NomeAluno", SqlDbType.VarChar)
                {
                    Value = _aluno.NomeAluno
                });

                cmd.Parameters.Add(new SqlParameter("@DataDeNascimento", SqlDbType.VarChar)
                {
                    Value = _aluno.DataDeNascimento
                });

                cmd.Parameters.Add(new SqlParameter("@TelefoneResponsavel", SqlDbType.VarChar)
                {
                    Value = _aluno.TelefoneResponsavel
                });

                cmd.Parameters.Add(new SqlParameter("@cpf", SqlDbType.VarChar)
                {
                    Value = _aluno.cpf
                });

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)
                {
                    Value = _aluno.Email
                });

                cmd.Parameters.Add(new SqlParameter("@NomeDoResponsavel", SqlDbType.VarChar)
                {
                    Value = _aluno.NomeResponsavel
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Sexo", SqlDbType.Int)
                {
                    Value = _aluno.Id_Sexo
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Cidade", SqlDbType.Int)
                {
                    Value = _aluno.Id_Cidade
                });

                cmd.Parameters.Add(new SqlParameter("@UF", SqlDbType.VarChar)
                {
                    Value = _aluno.UF
                });

                cmd.Parameters.Add(new SqlParameter("@EnderecoAluno", SqlDbType.VarChar)
                {
                    Value = _aluno.EnderecoAluno
                });

                cmd.Parameters.Add(new SqlParameter("@setor", SqlDbType.VarChar)
                {
                    Value = _aluno.Setor
                });

                cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.Int)
                {
                    Value = _aluno.Numero
                });

                cmd.Parameters.Add(new SqlParameter("@cep", SqlDbType.VarChar)
                {
                    Value = _aluno.CEP
                });

                cmd.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)
                {
                    Value = _aluno.Senha
                });

                cn.Open();

                _aluno.ID = Convert.ToInt32(cmd.ExecuteScalar());

                return _aluno;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
