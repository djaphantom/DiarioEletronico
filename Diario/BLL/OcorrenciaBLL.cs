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
    public class OcorrenciaBLL
    {
        public Ocorrencia Inserir(Ocorrencia _ocorrencia)
        {
            OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();
            return ocorrenciaDAL.Inserir(_ocorrencia);

        }
        public DataTable Buscar(string _filtro)
        {
            OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();
            return ocorrenciaDAL.Buscar(_filtro);
        }
        public Ocorrencia Alterar(Ocorrencia _ocorrencia)
        {
            OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();
            return ocorrenciaDAL.Alterar(_ocorrencia);
        }
        public void Excuir(int _id)
        {
            OcorrenciaDAL ocorrenciaDAL = new OcorrenciaDAL();
            ocorrenciaDAL.Excluir(_id);
        }
    }
}
