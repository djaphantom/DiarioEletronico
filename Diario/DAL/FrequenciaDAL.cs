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

        public Frequencia Alterar(Frequencia _professor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AlterarProfessor";

                SqlParameter id = new SqlParameter("@Id", SqlDbType.Int);
                id.Value = _professor.Id;
                cmd.Parameters.Add(id);

                SqlParameter nomeProfessor = new SqlParameter("@NomeProfessor", SqlDbType.Int);
                nomeProfessor.Value = _professor.NomeProfessor;
                cmd.Parameters.Add(nomeProfessor);

                SqlParameter cpf_Professor = new SqlParameter("@CPF_Professor", SqlDbType.VarChar);
                cpf_Professor.Value = _professor.CPF_Professor;
                cmd.Parameters.Add(cpf_Professor);

                SqlParameter email = new SqlParameter("@Email", SqlDbType.VarChar);
                email.Value = _professor.Email;
                cmd.Parameters.Add(email);

                SqlParameter telefone = new SqlParameter("@Telefone", SqlDbType.VarChar);
                telefone.Value = _professor.Telefone;
                cmd.Parameters.Add(telefone);

                SqlParameter dataDeNascimento = new SqlParameter("@DataDeNascimento", SqlDbType.VarChar);
                dataDeNascimento.Value = _professor.DataDeNascimento;
                cmd.Parameters.Add(dataDeNascimento);

                SqlParameter sexo = new SqlParameter("@Id_Sexo", SqlDbType.Int);
                sexo.Value = _professor.Id_Sexo;
                cmd.Parameters.Add(sexo);

                SqlParameter cidadeProfessor = new SqlParameter("@Id_Cidade", SqlDbType.Int);
                cidadeProfessor.Value = _professor.Id_Cidade;
                cmd.Parameters.Add(cidadeProfessor);


                SqlParameter enderecoProfessor = new SqlParameter("@EnderecoProfessor", SqlDbType.VarChar);
                enderecoProfessor.Value = _professor.EnderecoProfessor;
                cmd.Parameters.Add(enderecoProfessor);

                SqlParameter setor = new SqlParameter("@Setor", SqlDbType.VarChar);
                setor.Value = _professor.Setor;
                cmd.Parameters.Add(setor);

                SqlParameter cep = new SqlParameter("@CEP", SqlDbType.VarChar);
                cep.Value = _professor.CEP;
                cmd.Parameters.Add(cep);

                SqlParameter senha = new SqlParameter("@Senha", SqlDbType.VarChar);
                senha.Value = _professor.Senha;
                cmd.Parameters.Add(senha);

                cn.Open();
                cmd.ExecuteNonQuery();
                return _professor;
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
