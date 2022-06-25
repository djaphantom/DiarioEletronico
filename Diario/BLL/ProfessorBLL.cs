using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class ProfessorBLL
    {
        public Professor Inserir(Professor _professor)
        {
            ProfessorDAL professorDAL = new ProfessorDAL();
            return professorDAL.Inserir(_professor);

        }
        public DataTable Buscar(string _filtro)
        {
            ProfessorDAL professorDAL = new ProfessorDAL();
            return professorDAL.Buscar(_filtro);
        }
        public Professor Alterar(Professor _professor)
        {
            ProfessorDAL professorDAL = new ProfessorDAL();
            return professorDAL.Alterar(_professor);
        }
        public void Excuir(int _id)
        {
            ProfessorDAL professorDAL = new ProfessorDAL();
            professorDAL.Excluir(_id);
        }
    }
}
