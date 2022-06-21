﻿using System;
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
        private string cPF_Professor;
        private string email;
        private string telefone;
        private string dataDeNascimento;
        private string id_sexo;
        private string id_cidade;
        private string enderecoProfessor;
        private string setor;
        private string cep;
        private string senha;
        

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

        public string DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }

        public string Id_Sexo
        {
            get { return id_sexo; }
            set { id_sexo = value; }
        }

        public string Id_Cidade
        {

            get { return id_cidade; }
            set { id_cidade = value; }
        }

        public string EnderecoProfessor
        {
            get { return enderecoProfessor; }
            set { enderecoProfessor = value; }
        }

        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
