using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NotaDAL
    {
        public Nota Inserir(Nota _nota)
        {
            
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirNota";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _nota.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Turma", SqlDbType.Int)
                {
                    Value = _nota.Id_Turma
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", SqlDbType.Int)
                {
                    Value = _nota.Id_Aluno
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Diario", SqlDbType.Int)
                {
                    Value = _nota.Id_Diario
                });

                cmd.Parameters.Add(new SqlParameter("@notaAluno", SqlDbType.Float)
                {
                    Value = _nota.NotaAluno
                });

                cn.Open();

                _nota.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _nota;
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

/*###################################################################################################################################*/
        public DataTable Buscar(string _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "SP_BuscarNota";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
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
/*###################################################################################################################################*/
        
        public Nota Alterar(Nota _nota)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao; ;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarNota";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _nota.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Turma", SqlDbType.Int)
                {
                    Value = _nota.Id_Turma
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", SqlDbType.Int)
                {
                    Value = _nota.Id_Aluno
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Diario", SqlDbType.Int)
                {
                    Value = _nota.Id_Diario
                });

                cmd.Parameters.Add(new SqlParameter("@notaAluno", SqlDbType.Int)
                {
                    Value = _nota.NotaAluno
                });

                cn.Open();
                cmd.ExecuteNonQuery();

                return _nota;

            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
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

/*###################################################################################################################################*/
        
        public void Excluir(int _Id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirNota";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _Id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não foi posivel excluir o usuario: " + _Id.ToString());

            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Message);
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
