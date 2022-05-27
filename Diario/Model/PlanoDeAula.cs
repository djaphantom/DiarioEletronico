using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PlanoDeAula
    {

        private int id;
        private int id_professor;
        private int conteudo;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        //id do plano de aula


        public int Id_professor
        {
            get { return id_professor; }
            set { id_professor = value; }
        }
        // id do professor


        public int Conteudo
        {
            get { return conteudo; }
            set { conteudo = value; }
        }
        //conteudo do plano de aula



    }
}
