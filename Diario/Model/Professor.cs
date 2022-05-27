using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Professor
    {
        private int Id;
        private string NomeProfessor;
        private string EnderecoProfessor;
        private string CidadeProfessor;
        private string CPF_Professor;
        private string Email;
        private string Telefone;

        public int id
        {
            get { return id; }
            set { id = value; }
        }

        public string nomeProfessor
        {
            get { return nomeProfessor; }
            set { nomeProfessor = value; }
        }
        public string enderecoProfessor
        {
            get { return enderecoProfessor; }
            set { enderecoProfessor = value; }
        }

        public String cidadeProfessor
        {

            get { return cidadeProfessor; }
            set { cidadeProfessor = value; }
        }

        public string cpf_Professor
        {
            get { return cpf_Professor; }
            set { cpf_Professor = value; }
        }
        public string email
        {
            get { return email; }
            set { email = value; }
        }

        public string telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

    }
}
