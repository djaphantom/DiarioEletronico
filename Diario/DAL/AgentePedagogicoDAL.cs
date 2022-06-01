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
                cmd.CommandText = "SP_InserirProfessor";

                cmd.Parameters
            }
            catch (Exception)
            {

                throw;
            }
        }
        public AgentePedagogico Buscar(String _filtro)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
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
        public AgentePedagogico Alterar(AgentePedagogico _agentePedagogico)
    }
<<<<<<< HEAD

    internal class Conexao
    {
        public static string StringDeCenexao { get; internal set; }
    }
}
=======
}
>>>>>>> dc3c29ea64454e1e04e3d7f992d2be7c48e1a3e9
