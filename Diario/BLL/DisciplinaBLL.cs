using DAL;
using Model;
using System.Data;

namespace BLL
{
    class DisciplinaBLL
    {
        public Disciplina Inserir(Disciplina _disciplina)
        {

            DisciplinaDAL disciplinaDAL = new DisciplinaDAL();
            return disciplinaDAL.Inserir(_disciplina);
        }
        public DataTable Buscar(string _filtro)
        {
            DisciplinaDAL disciplinaDAL = new DisciplinaDAL();
            return disciplinaDAL.Buscar(_filtro);

        }
        public Disciplina Alterar(Disciplina _disciplina)
        {
            DisciplinaDAL disciplinaDAL = new DisciplinaDAL();
            return disciplinaDAL.Alterar(_disciplina);
        }
        public void Excluir(int _Id)
        {
            DisciplinaDAL disciplinaDAL = new DisciplinaDAL();
            disciplinaDAL.Excluir(_Id);
        }

    }
}
