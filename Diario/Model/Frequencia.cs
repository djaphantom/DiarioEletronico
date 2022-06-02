using System;
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
        private bool apontamento;
        private string data;


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

        public Boolean Apontamento
        {
            get { return apontamento; }
            set { apontamento = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
