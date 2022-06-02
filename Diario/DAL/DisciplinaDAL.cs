using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DisciplinaDAL
    {
        public Disciplina Inserir(Disciplina _professor)
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
                    Value = _disciplina.NomeProfessor
                });

                cmd.Parameters.Add(new SqlParameter("@EnderecoProfessor", SqlDbType.VarChar)
                {
                    Value = _disciplina.EnderecoProfessor
                });

                cmd.Parameters.Add(new SqlParameter("@cidadeProfessor", SqlDbType.VarChar)
                {
                    Value = _disciplina.CidadeProfessor
                });

                cmd.Parameters.Add(new SqlParameter("@CPF_Professor", SqlDbType.VarChar)
                {
                    Value = _disciplina.CPF_Professor
                });

                cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar)
                {
                    Value = _disciplina.Email
                });
                return _disciplina;
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
