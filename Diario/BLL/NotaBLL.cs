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
    public class NotaBLL
    {
        public Nota Inserir(Nota _nota)
        {

            NotaDAL usuarioDAL = new NotaDAL();
            return usuarioDAL.Inserir(_nota);
        }
        public DataTable Buscar(string _filtro)
        {
            NotaDAL usuarioDAL = new NotaDAL();
            return usuarioDAL.Buscar(_filtro);

        }
        public Nota Alterar(Nota _nota)
        {
            NotaDAL usuarioDAL = new NotaDAL();
            return usuarioDAL.Alterar(_nota);
        }
        public void Excluir(int _Id)
        {
            NotaDAL usuarioDAL = new NotaDAL();
            usuarioDAL.Excluir(_Id);
        }


    }
}
