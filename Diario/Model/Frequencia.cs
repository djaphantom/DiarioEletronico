﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Frequencia
    {
        private int id;
        private int id_Aluno;
        private int id_diario;
        private bool faltas;
        private string data_;


       public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Id_Aluno
        {
            get { return id_Aluno; }
            set { id_Aluno = value; }
        }

        public int Id_Diario
        {
            get { return id_diario; }
            set { id_diario = value; }
        }

        public Boolean Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }
        public string Data_
        {
            get { return data_; }
            set { data_ = value; }
        }
    }
}
