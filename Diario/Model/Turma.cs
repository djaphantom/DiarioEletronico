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
        private string Serie;
        private string Turno;

        public string serie
        {
            get { return Serie; }
            set { Serie = value; }
        }
        public int Id
        {
            get { return id; }  
            set { id = value; } 
        }


        public string turno
        {
            get { return Turno; }
            set { Turno = value; }
        }

    }
}
