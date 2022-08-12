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
        private string periodo;

        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }
        public int Id
        {
            get { return id; }  
            set { id = value; } 
        }

    }
}
