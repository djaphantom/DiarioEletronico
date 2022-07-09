using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class BoletinBLL
    {
       public DataTable Buscar(int Id_Aluno)
        {
            BoletinDAL boletinDAL = new BoletinDAL();
            return boletinDAL.Buscar(Id_Aluno);
        }
    }
}
