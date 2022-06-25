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
    public class DiarioEletronicoDAL
    {
        public DiarioEletronico Inserir(DiarioEletronico _diarioEletronico)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirDiario";

                cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.Int)
                {
                    Value = _diarioEletronico.Id
                });

                cmd.Parameters.Add(new SqlParameter("Id_Disciplina", SqlDbType.Int)
                {
                    Value = _diarioEletronico.Id_Disciplina
                });

                cmd.Parameters.Add(new SqlParameter("Id_Professor", SqlDbType.Int)
                {
                    Value = _diarioEletronico.Id_Professor
                });

                cmd.Parameters.Add(new SqlParameter("Id_Turma", SqlDbType.Int)
                {
                    Value = _diarioEletronico.Id_Turma
                });

                return _diarioEletronico;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Error: " + ex.Message);
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
                da.SelectCommand.CommandText = "SP_BuscarDiario";
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
                cmd.CommandText = "SP_ExcluirDiario";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não foi possível excluir usuário: " + _id.ToString());
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

        public DiarioEletronico Alterar(DiarioEletronico _diarioEletronico)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarDiario";

                SqlParameter id = new SqlParameter("@Id", SqlDbType.Int);
                id.Value = _diarioEletronico.Id;
                cmd.Parameters.Add(id);

                SqlParameter id_Disciplina = new SqlParameter("@Id_Disciplina", SqlDbType.Int);
                id_Disciplina.Value = _diarioEletronico.Id_Disciplina;
                cmd.Parameters.Add(id_Disciplina);

                SqlParameter id_Professor = new SqlParameter("@Id_Professor", SqlDbType.Int);
                id_Professor.Value = _diarioEletronico.Id_Professor;
                cmd.Parameters.Add(id_Professor);

                SqlParameter id_Turma = new SqlParameter("@Id_Turma", SqlDbType.Int);
                id_Turma.Value = _diarioEletronico.Id_Turma;
                cmd.Parameters.Add(id_Turma);

                cn.Open();
                cmd.ExecuteNonQuery();
                return _diarioEletronico;
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
