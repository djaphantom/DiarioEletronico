﻿
namespace Model
{
    public class Aluno
    {
        private int id;
        private int id_Turma;
        private string nomeAluno;
        private string enderecoAluno;
        private string cidadeAluno;
        private string telefoneResponsavel;
        private string email;
        private string dataDeNascimanto;
        private string sexo;
        private string setor;
        private string cep;
        private string nomeResponsavel;
        private int numero;
        private string Uf;
        private string senha;



        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public int Id_Turma
        {
            get { return id_Turma; }
            set { id_Turma = value; }
        }


        public string NomeAluno
        {
            get { return nomeAluno; }
            set {nomeAluno = value;}
        }


        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public string EnderecoAluno
        {
            get { return enderecoAluno; }
            set { enderecoAluno = value; }
        }


        public string CidadeAluno
        {
            get { return cidadeAluno; }
            set { cidadeAluno = value; }
        }


        public string TelefoneResponsavel
        {
            get { return telefoneResponsavel; }
            set { telefoneResponsavel = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string DataDeNascimento
        {
            get { return dataDeNascimanto; }
            set { dataDeNascimanto = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }


        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string CPF;

        public string cpf
        {
            get { return CPF; }
            set { CPF = value; }
        }


        public string NomeResponsavel
        {
            get { return nomeResponsavel; }
            set { nomeResponsavel = value; }
        }


        public string UF
        {
            get { return Uf; }
            set { Uf = value; }
        }


        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


    }
}
