using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Cidade
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int id_UF;

        public int Id_UF
        {
            get { return id_UF; }
            set { id_UF = value; }
        }

        private int nomeCidade;

        public int NomeCidade
        {
            get { return nomeCidade; }
            set { nomeCidade = value; }
        }

    }
}
