using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DALL
{
    public class Banco
    {
        readonly SqlTransaction t = null;
        readonly SqlTransaction cn = null;

        public Banco()
        {
            t = cn.BeginTransaction(IsolationLevel.Serializable);
            cn = new SqlConnection("");
        }
    }
}
