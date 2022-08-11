using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class NotaBLL
    {
        public Nota Inserir(Nota _nota)
        {

            NotaDAL notaDAL = new NotaDAL();
            return notaDAL.Inserir(_nota);
        }
        public DataTable Buscar(string _filtro)
        {
            NotaDAL notaDAL = new NotaDAL();
            return notaDAL.Buscar(_filtro);

        }
        public Nota Alterar(Nota _nota)
        {
            NotaDAL notaDAL = new NotaDAL();
            return notaDAL.Alterar(_nota);
        }
        public void Excluir(int _Id)
        {
            NotaDAL notaDAL = new NotaDAL();
            notaDAL.Excluir(_Id);
        }

        public static implicit operator NotaBLL(OcorrenciaBLL v)
        {
            throw new NotImplementedException();
        }
    }
}
