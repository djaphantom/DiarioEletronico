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
    public class TurmaBLL
    {
        public void Inserir(Turma _turma)
        {
            //TurmaDAL turmaDAL = new TurmaDAL();
            //turmaDAL.Inserir(_turma);
        }
        public DataTable Buscar(string _filtro)
        {
            //TurmaDAL turmaDAL = new TurmaDAL();
            //return TurmaDAL.Buscar(_filtro);
            throw new NotImplementedException();
        }
        public Turma Alterar(Turma _turma)
        {
            //AgentePedagogicoDAL turmaDAL = new AgentePedagogicoDAL();
            //return turmaDAL.Alterar(_turma);
            throw new NotImplementedException();
        }
        public void Excluir(int _id)
        {
            //TurmaDAL turmaDAL = new TurmaDAL();
            //turmaDAL.Excluir(_id);
        }

    }
}
