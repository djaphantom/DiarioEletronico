using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ProfessorDAL
    {
        public Professor Inserir(Professor _professor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirProfessor";

                cmd.Parameters.Add(new SqlParameter("@NomeProfessor", SqlDbType.VarChar)
                {
                    Value = _professor.NomeProfessor
                });

                cmd.Parameters.Add(new SqlParameter("@EnderecoProfessor", SqlDbType.VarChar)
                {
                    Value = _professor.EnderecoProfessor
                });

                cmd.Parameters.Add(new SqlParameter("@cidadeProfessor", SqlDbType.VarChar)
                {
                    Value = _professor.CidadeProfessor
                });

                cmd.Parameters.Add(new SqlParameter("@CPF_Professor", SqlDbType.VarChar)
                {
                    Value = _professor.CPF_Professor
                });

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)
                {
                    Value = _professor.Email
                });
                return _professor;
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
                da.SelectCommand.CommandText = "SP_BuscarProfessor";
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
                throw new Exception("Servidor Sql Erro: " + ex.Message);
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
