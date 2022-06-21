using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ocorrencia
    {
        private int id;
        private int id_Aluno;
        private string descricao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_aluno
        {
            get { return id_Aluno; }
            set { id_Aluno = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
