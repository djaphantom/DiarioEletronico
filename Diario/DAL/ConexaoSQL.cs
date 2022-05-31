using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConexaoSQL
    {
        public static string StringDeConexao
        {
            get
            {
                return @"User ID=SA;Initial Catalog=BancoDiarioEletronico; Data Source=.\SQLEXPRESS2019;Password=sENAILAB05";
            }
        }
    }
}
