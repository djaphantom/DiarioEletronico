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
        private int id_diario;
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

        public int Id_Diario
        {
            get { return id_diario; }
            set { id_diario = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
