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

                SqlParameter pnomeAgente = new SqlParameter("@nomeAgente", SqlDbType.VarChar);
                pnomeAgente.Value = _agentePedagogico.NomeAgente;
                cmd.Parameters.Add(pnomeAgente);

                SqlParameter psenha = new SqlParameter("@senha", SqlDbType.VarChar);
                psenha.Value = _agentePedagogico.Senha;
                cmd.Parameters.Add(psenha);

                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _agentePedagogico.Id;
                cmd.Parameters.Add(pid);

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

                SqlParameter id = new SqlParameter("@Id", SqlDbType.Int);
                id.Value = _agentePedagogico.Id;
                cmd.Parameters.Add(id);

                SqlParameter nomeAgente = new SqlParameter("@NomeAgente", SqlDbType.VarChar);
                nomeAgente.Value = _agentePedagogico.NomeAgente;
                cmd.Parameters.Add(nomeAgente);


                SqlParameter senhaAgente = new SqlParameter("@Senha", SqlDbType.VarChar);
                senhaAgente.Value = _agentePedagogico.Senha;
                cmd.Parameters.Add(senhaAgente);

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
