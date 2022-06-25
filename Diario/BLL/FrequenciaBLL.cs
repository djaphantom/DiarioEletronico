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
    public class FrequenciaBLL
    {
        public Frequencia Inserir(Frequencia _frequencia)
        {
            FrequenciaDAL frequenciaDAL = new FrequenciaDAL();
            return frequenciaDAL.Inserir(_frequencia);

        }
        public DataTable Buscar(string _filtro)
        {
            FrequenciaDAL frequenciaDAL = new FrequenciaDAL();
            return frequenciaDAL.Buscar(_filtro);
        }
        public Frequencia Alterar(Frequencia _frequencia)
        {
            FrequenciaDAL frequenciaDAL = new FrequenciaDAL();
            return frequenciaDAL.Alterar(_frequencia);
        }
        public void Excuir(int _id)
        {
            FrequenciaDAL frequenciaDAL = new FrequenciaDAL();
            frequenciaDAL.Excluir(_id);
        }

    }
}
