using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ocorrencia
    {
        private int Id;
        private int Id_Aluno;
        private string descricao;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public int id_aluno
        {
            get { return Id_Aluno; }
            set { Id_Aluno = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
