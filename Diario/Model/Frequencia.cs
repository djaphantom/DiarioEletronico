using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Frequencia
    {
        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        private int frequencia;

        public int DescricaoFrequencia
        {
            get { return frequencia; }
            set { frequencia = value; }
        }
    }
}
