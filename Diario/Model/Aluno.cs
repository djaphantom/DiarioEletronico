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
        private string telefoneAluno;
        private string email;



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


        public string TelefoneAluno
        {
            get { return telefoneAluno; }
            set { telefoneAluno = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}
