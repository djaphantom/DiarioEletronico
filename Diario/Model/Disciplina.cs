using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class Disciplina
    {

        private int Id;
        private string NomeDisciplina;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string disciplina
        {
            get { return NomeDisciplina; }
            set { NomeDisciplina = value; }
        }
    }
}
