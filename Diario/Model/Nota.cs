namespace Model
{
    public class Nota
    {
        private int id_Nota;
        private int id_Aluno;
        private int id_Turma;
        private float apontamento;

        public int Id_Nota
        {
            get { return id_Nota; }
            set { id_Nota = value; }
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


        public float Apontamento
        {
            get { return apontamento; }
            set { apontamento = value; }
        }


    }
}
