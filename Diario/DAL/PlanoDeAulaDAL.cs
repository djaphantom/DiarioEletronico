﻿using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PlanoDeAulaDAL
    {
        public PlanoDeAula Inserir(PlanoDeAula _planoDeAula)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_InserirPlanoDeAula";

                cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)
                {
                    Value = _planoDeAula.Id
                });

                cmd.Parameters.Add(new SqlParameter("@Id_professor", SqlDbType.Int)
                {
                    Value = _planoDeAula.Id_professor
                });

                cmd.Parameters.Add(new SqlParameter("@Id_diario", SqlDbType.Int)
                {
                    Value = _planoDeAula.Id_Diario
                });

                cmd.Parameters.Add(new SqlParameter("@conteudo", SqlDbType.VarChar)
                {
                    Value = _planoDeAula.Conteudo
                });

                return _planoDeAula;
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
                da.SelectCommand.CommandText = "SP_BuscarPlanoDeAula";
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
                cmd.CommandText = "SP_ExcluirPlanoDeAula";
                SqlParameter pid = new SqlParameter("@Id", SqlDbType.Int);
                pid.Value = _id;
                cmd.Parameters.Add(pid);
                cn.Open();
                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                    throw new Exception("Não foi possível excluir PlanoDeAula: " + _id.ToString());
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

        public PlanoDeAula Alterar(PlanoDeAula _planoDeAula)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarPlanoDeAula";

                SqlParameter id = new SqlParameter("@Id", SqlDbType.Int);
                id.Value = _planoDeAula.Id;
                cmd.Parameters.Add(id);

                SqlParameter id_professor = new SqlParameter("@Id_professor", SqlDbType.Int);
                id_professor.Value = _planoDeAula.Id_professor;
                cmd.Parameters.Add(id_professor);

                SqlParameter id_diario = new SqlParameter("@Id_diario", SqlDbType.VarChar);
                id_diario.Value = _planoDeAula.Id_Diario;
                cmd.Parameters.Add(id_diario);

                SqlParameter conteudo = new SqlParameter("@Conteudo", SqlDbType.VarChar);
                conteudo.Value = _planoDeAula.Conteudo;
                cmd.Parameters.Add(conteudo);

                cn.Open();
                cmd.ExecuteNonQuery();
                return _planoDeAula;
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
