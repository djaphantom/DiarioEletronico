using DAL;
using Model;
using System;
using System.Data;

namespace BLL
{
    public class AgentePedagogicoBLL
    {
        public void Inserir(AgentePedagogico _agentePedagogico)
        {
            AgentePedagogicoDAL agentePedagogicoDAL = new AgentePedagogicoDAL();
            _agentePedagogico.Senha = Infra.Criptografia.GetHash(_agentePedagogico.Senha);
            agentePedagogicoDAL.Inserir(_agentePedagogico);

        }
        public DataTable Buscar(string _filtro)
        {
            AgentePedagogicoDAL agentePedagogicoDAL = new AgentePedagogicoDAL();
            return agentePedagogicoDAL.Buscar(_filtro); 

        }
        public AgentePedagogico Alterar(AgentePedagogico _agentePedagogico)
        {
            AgentePedagogicoDAL agentePedagogicoDAL = new AgentePedagogicoDAL();
            return agentePedagogicoDAL.Alterar(_agentePedagogico);
        }
        public void Excluir(int _id)
        {
            AgentePedagogicoDAL agentePedagogicoDAL = new AgentePedagogicoDAL();
            agentePedagogicoDAL.Excluir(_id);
        }
    }
}
