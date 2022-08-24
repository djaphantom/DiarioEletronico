using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BoletinDAL
    {
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
                da.SelectCommand.CommandText = "Sp_BuscarBoletim";
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter pboletin = new SqlParameter("@filtro", SqlDbType.VarChar);
                pboletin.Value = _filtro;
                da.SelectCommand.Parameters.Add(pboletin);

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
