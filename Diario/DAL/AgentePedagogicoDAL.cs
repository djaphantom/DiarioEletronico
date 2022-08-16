using Model;
using System;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class AgentePedagogicoDAL
    {

        public AgentePedagogico Inserir(AgentePedagogico _agentePedagogico)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirAgente";

                cmd.Parameters.Add(new SqlParameter("@NomeAgente", SqlDbType.VarChar)
                {
                    Value = _agentePedagogico.NomeAgente
                });

                cmd.Parameters.Add(new SqlParameter("@senha", SqlDbType.VarChar)
                {
                    Value = _agentePedagogico.Senha
                });

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _agentePedagogico.Id
                });

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.VarChar)
                {
                    Value = _agentePedagogico.nomeUsuario
                });

                cn.Open();
                _agentePedagogico.Id = Convert.ToInt32(cmd.ExecuteScalar());

                return _agentePedagogico;

            }
            catch (SqlException ex)
            {

                throw new Exception("servidor SQL Erro" + ex.Message);
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
                da.SelectCommand.CommandText = "SP_BuscarAgente";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(pfiltro);

                cn.Open();
                da.Fill(dt);
                return dt; ;

            }
            catch (SqlException ex)
            {

                throw new Exception("servidor SQL Erro" + ex.Message);
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
                cmd.CommandText = "SP_ExcluirAgente"; 
                 SqlParameter pid = new SqlParameter("@id",SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);

                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("não possivel excluir o Agente pedagogico: " + _id.ToString());




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
        public AgentePedagogico Alterar(AgentePedagogico _agentePedagogico)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarAgente";

                cmd.Parameters.Add(new SqlParameter("@NomeAgente", SqlDbType.Int)
                {
                    Value = _agentePedagogico.NomeAgente
                });

                cmd.Parameters.Add(new SqlParameter("@senha", SqlDbType.Int)
                {
                    Value = _agentePedagogico.Senha
                });

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _agentePedagogico.Id
                });

                cmd.Parameters.Add(new SqlParameter("@NomeUsuario", SqlDbType.Int)
                {
                    Value = _agentePedagogico.nomeUsuario
                });

                cn.Open();
                cmd.ExecuteNonQuery();
                return _agentePedagogico;
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
