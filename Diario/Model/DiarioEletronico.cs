namespace Model
{
    public class DiarioEletronico
    {
        private int id;
        private int id_Disciplina;
        private int id_Professor;
        private int id_Turma;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Disciplina
        {
            get { return id_Disciplina; }
            set { id_Disciplina = value; }
        }

        public int Id_Professor
        {
            get { return id_Professor; }
            set { id_Professor = value; }
        }

       
        public int Id_Turma
        {
            get { return id_Turma; }
            set { id_Turma = value; }
        }


    }
}
