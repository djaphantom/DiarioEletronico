namespace Model
{
    public class Boletim
    {
        private int id;
        private int id_Bimestre;
        private int id_Disciplina;
        private int id_Aluno;
        private int nota;
        private int faltas;
        private int media;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Bimestre
        {
            get { return id_Bimestre; }
            set { id_Bimestre = value; }
        }

        public int Id_Disciplina
        {
            get { return id_Disciplina; }
            set { id_Disciplina = value; }
        }

        public int Id_Aluno
        {
            get { return id_Aluno; }
            set { id_Aluno = value; }
        }

        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }


        public int Faltas
        {
            get { return faltas; }
            set { faltas = value; }
        }


        public int Media
        {
            get { return media; }
            set { media = value; }
        }

        private int resultado;

        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

    }
}
