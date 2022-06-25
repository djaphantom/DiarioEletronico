using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UFBLL
    {
        public UF Inserir(UF _uF)
        {
            UfDAL uF = new UfDAL();
            return uF.Inserir(_uF);

        }
        public DataTable Buscar(string _filtro)
        {
            UfDAL uF = new UfDAL();
            return uF.Buscar(_filtro);
        }
        public UF Alterar(UF _uF)
        {
            UfDAL uF = new UfDAL();
            return uF.Alterar(_uF);
        }
        public void Excuir(int _id)
        {
            UfDAL cidadeDAL = new UfDAL();
            cidadeDAL.Excluir(_id);
        }
    }
}
