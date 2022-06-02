using DAL;
using Model;


namespace BLL
{
    class AlunoBLL
    {
        public Aluno Inserir(Aluno _aluno)
        {
            AlunoDAL alunoDAL = new AlunoDAL();
            return alunoDAL.Inserir(_aluno);
        }
    }
}
