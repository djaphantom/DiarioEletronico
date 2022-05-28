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
        private Boolean apontamento;
        private DateTime data;


       public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public int Id_Aluno
        {
            get { return Id_Aluno; }
            set { Id_Aluno = value; }
        }

        public Boolean Apontamento
        {
            get { return Apontamento; }
            set { Apontamento = value; }
        }
        public DateTime Data
        {
            get { return Data; }
            set { Data = value; }
        }
    }
}
