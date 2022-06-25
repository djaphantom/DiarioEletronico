using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class FrequenciaDAL
    {
        public Frequencia Inserir(Frequencia _frequencia)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirProfessor";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _frequencia.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Aluno", SqlDbType.VarChar)
                {
                    Value = _frequencia.Id_Aluno
                });

                cmd.Parameters.Add(new SqlParameter("@Id_Diario", SqlDbType.VarChar)
                {
                    Value = _frequencia.Id_Diario
                });

                cmd.Parameters.Add(new SqlParameter("@Faltas", SqlDbType.VarChar)
                {
                    Value = _frequencia.Faltas
                });

                cmd.Parameters.Add(new SqlParameter("@Data_dia", SqlDbType.VarChar)
                {
                    Value = _frequencia.Data
                });

                return _frequencia;
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
                da.SelectCommand.CommandText = "SP_BuscarFrequencia";
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

        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_ExcluirFrequencia";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não foi possível excluir frequencia: " + _id.ToString());
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

        public Frequencia Alterar(Frequencia _frequencia)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Alterarfrequencia";

                SqlParameter id = new SqlParameter("@Id", SqlDbType.Int);
                id.Value = _frequencia.Id;
                cmd.Parameters.Add(id);

                SqlParameter nomeProfessor = new SqlParameter("@NomeProfessor", SqlDbType.Int);
                nomeProfessor.Value = _frequencia.Id_Aluno;
                cmd.Parameters.Add(nomeProfessor);

                SqlParameter cpf_Professor = new SqlParameter("@CPF_Professor", SqlDbType.VarChar);
                cpf_Professor.Value = _frequencia.Id_Diario;
                cmd.Parameters.Add(cpf_Professor);

                SqlParameter email = new SqlParameter("@Email", SqlDbType.VarChar);
                email.Value = _frequencia.Faltas;
                cmd.Parameters.Add(email);

                SqlParameter telefone = new SqlParameter("@Telefone", SqlDbType.VarChar);
                telefone.Value = _frequencia.Data;
                cmd.Parameters.Add(telefone);

                

                cn.Open();
                cmd.ExecuteNonQuery();
                return _frequencia;
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
