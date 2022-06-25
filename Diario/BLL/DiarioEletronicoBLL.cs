using DAL;
using Model;
using System.Data;

namespace BLL
{
    public class DiarioEletronicoBLL
    {
        public DiarioEletronico Inserir(DiarioEletronico _diarioEletronico)
        {

            DiarioEletronicoDAL diarioEletronicoDAL = new DiarioEletronicoDAL();
            return diarioEletronicoDAL.Inserir(_diarioEletronico);
        }
        public DataTable Buscar(string _filtro)
        {
            DiarioEletronicoDAL diarioEletronicoDAL = new DiarioEletronicoDAL();
            return diarioEletronicoDAL.Buscar(_filtro);

        }
        public DiarioEletronico Alterar(DiarioEletronico _diarioEletronico)
        {
            DiarioEletronicoDAL diarioEletronicoDAL = new DiarioEletronicoDAL();
            return diarioEletronicoDAL.Alterar(_diarioEletronico);
        }
        public void Excluir(int _Id)
        {
            DiarioEletronicoDAL diarioEletronicoDAL = new DiarioEletronicoDAL();
            diarioEletronicoDAL.Excluir(_Id);
        }
    }
}
