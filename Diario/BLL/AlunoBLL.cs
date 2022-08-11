using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class AlunoBLL
    {
        public Aluno Inserir(Aluno _aluno)
        {
            AlunoDAL alunoDAL = new AlunoDAL();
            _aluno.Senha = Infra.Criptografia.GetHash(_aluno.Senha);
            return alunoDAL.Inserir(_aluno);
        }
        public DataTable Buscar(string _filtro)
        {
            AlunoDAL alunoDAL = new AlunoDAL();
            return alunoDAL.Buscar(_filtro);
        }
        public Aluno Alterar(Aluno _aluno)
        {
            AlunoDAL alunoDAL = new AlunoDAL();
            return alunoDAL.Alterar(_aluno);
        }
        public void Excuir(int _id)
        {
            AlunoDAL alunoDAL = new AlunoDAL();
            alunoDAL.Excluir(_id);
        }
    }
}
