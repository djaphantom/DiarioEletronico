namespace Model
{
    public class Nota
    {
        private int id;
        private int id_Aluno;
        private int id_Turma;
        private int id_diario;
        private double notaAluno;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Aluno
        {
            get { return id_Aluno; }
            set { id_Aluno = value; }
        }


        public int Id_Turma
        {
            get { return id_Turma; }
            set { id_Turma = value; }
        }

        public int Id_Diario
        {
            get { return id_diario; }
            set { id_diario = value; }
        }

        public double NotaAluno
        {
            get { return notaAluno; }
            set { notaAluno = value; }
        }


    }
}
