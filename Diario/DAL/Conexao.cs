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

                // return @"User ID=SA;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;password=bruno2003"; //Bruno Alencar
                //  return @"User ID=SA;Initial Catalog=BancoDiarioEle;Data Source=DESKTOP-BLBTF95\SQLEXPRESS;password=123";
                /*return @"User ID=sa;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;password=Senailab05";*/
                return @"User ID=SA;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;password=Senailab05";
                /*return @"User ID=sa;Initial Catalog=BancoDiarioEle;Data Source=.\SQLEXPRESS2019;password=sENAILAB05";*/ //Henrique
               /* return @"User ID=sa;Initial Catalog=BancoDiarioEle;Data Source=DESKTOP-PFD4BLL\SQLEXPRESS01;Password=123456789"; //Henrique*/

            }
        }
    }
}
