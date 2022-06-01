using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Professor
    {
        private int id;
        private string nomeProfessor;
        private string enderecoProfessor;
        private string cidadeProfessor;
        private string cPF_Professor;
        private string email;
        private string telefone;
        private string dataDeNascimento;
        private string sexo;
        private string uF;
        private string setor;
        private string senha;
        private string cEP;
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeProfessor
        {
            get { return nomeProfessor; }
            set { nomeProfessor = value; }
        }


        public string CPF_Professor
        {
            get { return cPF_Professor; }
            set { cPF_Professor = value; }
        }


        public string DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }


        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }


        public string EnderecoProfessor
        {
            get { return enderecoProfessor; }
            set { enderecoProfessor = value; }
        }

        public string CidadeProfessor
        {

            get { return cidadeProfessor; }
            set { cidadeProfessor = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        public string UF
        {
            get { return uF; }
            set { uF = value; }
        }


        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }


        public string CEP
        {
            get { return cEP; }
            set { cEP = value; }
        }


        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

    }
}
