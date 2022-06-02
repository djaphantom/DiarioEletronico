using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class AgentePedagogicoDAL
    {




        public AgentePedagogico Inserir(AgentePedagogico _agentePedagogico)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeCenexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Caminho da procidure";

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

                throw new Exception( ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        public AgentePedagogico Buscar(String _filtro)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeCenexao;
                SqlCommand cmd = new SqlCommand();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandText = "nome da procidure";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar);
                pfiltro.Value = _filtro;
                da.SelectCommand.Parameters.Add(_filtro);



                cn.Open();
                da.Fill(dt);
                return dt;

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
        public AgentePedagogico Excluir(int _id)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }

}
