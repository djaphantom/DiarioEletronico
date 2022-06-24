using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class CidadeBLL
    {
        public Cidade Inserir(Cidade _cidade)
        {
            CidadeDAL cidadeDAL = new CidadeDAL();
            return cidadeDAL.Inserir(_cidade);

        }
        public DataTable Buscar(string _filtro)
        {
            CidadeDAL cidadeDAL = new CidadeDAL();
            return cidadeDAL.Buscar(_filtro);
        }
        public Cidade Alterar(Cidade _cidade)
        {
            CidadeDAL cidadeDAL = new CidadeDAL();
            return cidadeDAL.Alterar(_cidade);
        }
        public void Excuir(int _id)
        {
            CidadeDAL cidadeDAL = new CidadeDAL();
            cidadeDAL.Excluir(_id);
        }
    }
}
