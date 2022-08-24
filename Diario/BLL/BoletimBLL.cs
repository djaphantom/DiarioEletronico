using DAL;
using System.Data;

namespace BLL
{
    public class BoletimBLL
    {
       public DataTable Buscar(string _filtro)
        {
            BoletinDAL boletinDAL = new BoletinDAL();
            return boletinDAL.Buscar(_filtro);
        }
    }
}
