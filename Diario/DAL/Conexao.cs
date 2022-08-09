using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                return @"User ID=SA;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;Password=bruno2003";
            }
        }
    }
}
