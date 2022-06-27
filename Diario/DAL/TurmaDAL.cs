using System;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TurmaDAL
    {


        public Turma Inserir(Turma _turma)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter pperiodo = new SqlParameter("@periodo", SqlDbType.Int);
                pperiodo.Value = _turma.Periodo;
                cmd.Parameters.Add(pperiodo);

                cn.Open();
                _turma.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _turma;


            }
            catch (SqlException ex)
            {

                throw new Exception("Serviço SQL Erro:" + ex.Message);

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
        public DataTable Buscar(String _filtro)
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
                da.SelectCommand.CommandText = "SP_BuscarTurma";
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

                throw new Exception("servidor SQL erro: " + ex.Message);
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
                cmd.CommandText = "SP_ExcluirTurma";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1) ;
                throw new Exception("Não possivel executar o usuario: " + _id.ToString());


            }
            catch (SqlException ex)
            {

                throw new Exception("Servidor SQL erro: " + ex.Message);

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
        public Turma Alterar(Turma _turma)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeCenexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarTurma";

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _turma.Id;
                cmd.Parameters.Add(pid);

                SqlParameter pperiodo = new SqlParameter("@Operiodo", SqlDbType.VarChar);
                pperiodo.Value = _turma.Periodo;
                cmd.Parameters.Add(pperiodo);



                cn.Open();
                cmd.ExecuteNonQuery();
                return _turma;
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
