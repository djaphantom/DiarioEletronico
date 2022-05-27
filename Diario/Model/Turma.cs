using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class Turma
     {
        private int id;
        private int id_aluno;   
        private string periodo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        // id da turma


        public int Id_aluno
        {
            get { return id_aluno; }
            set { id_aluno = value; }
        }
        // id do aluno

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        // periodo da aula

     }//class turma

}// PASTA MODEL
