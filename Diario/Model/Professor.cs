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
        private string cpf_Professor;
        private string email;
        private string telefone;

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

        public string CPF_Professor
        {
            get { return cpf_Professor; }
            set { cpf_Professor = value; }
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

    }
}
