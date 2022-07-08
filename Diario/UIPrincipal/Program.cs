using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPrincipal
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string texto = "Erisvaldo";
            string hash = Infra.Criptografia.GetHash(texto);
            bool iguais = Infra.Criptografia.verificarHash( texto, hash); 
            Application.Run(new FormLogin());
        }
    }
}
