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
                /*return @"User ID=SA;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;Password=bruno2003";*/
                return @"User ID=sa;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;password=Senailab05";
                /*return @"User ID=SA;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;password=Senailab05";*/
                /* return @"User ID=sa;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;password=sENAILAB05";*/

                /*return @"User ID=sa;Initial Catalog=BancoDiarioEle;Data Source=DESKTOP-PFD4BLL\SQLEXPRESS01;Password=123456789";*/

            }
        }
    }
}
