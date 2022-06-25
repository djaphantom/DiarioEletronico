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
    public class SexoBLL
    {
        public Sexo Inserir(Sexo _sexo)
        {
            SexoDAL sexoDAL = new SexoDAL();
            return sexoDAL.Inserir(_sexo);

        }
        public DataTable Buscar(string _filtro)
        {
            SexoDAL sexoDAL = new SexoDAL();
            return sexoDAL.Buscar(_filtro);
        }
        public Sexo Alterar(Sexo _sexo)
        {
            SexoDAL sexoDAL = new SexoDAL();
            return sexoDAL.Alterar(_sexo);
        }
        public void Excuir(int _id)
        {
            SexoDAL sexoDAL = new SexoDAL();
            sexoDAL.Excluir(_id);
        }
    }
}
