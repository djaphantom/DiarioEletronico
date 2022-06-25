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
    public class PlanoDeAulaBLL
    {
        public PlanoDeAula Inserir(PlanoDeAula _planoDeAula)
        {

            PlanoDeAulaDAL PlanoDeAulaDAL = new PlanoDeAulaDAL();
            return PlanoDeAulaDAL.Inserir(_planoDeAula);
        }
        public DataTable Buscar(string _filtro)
        {
            PlanoDeAulaDAL PlanoDeAulaDAL = new PlanoDeAulaDAL();
            return PlanoDeAulaDAL.Buscar(_filtro);

        }
        public PlanoDeAula Alterar(PlanoDeAula _planoDeAula)
        {
            PlanoDeAulaDAL PlanoDeAulaDAL = new PlanoDeAulaDAL();
            return PlanoDeAulaDAL.Alterar(_planoDeAula);
        }

        public void Excluir(int _Id)
        {
            PlanoDeAulaDAL PlanoDeAulaDAL = new PlanoDeAulaDAL();
            PlanoDeAulaDAL.Excluir(_Id);
        }
    }
}
