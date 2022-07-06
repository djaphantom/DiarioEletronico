namespace Model
{
    public class AgentePedagogico
    {
        private int id;
        private string senha;
        private string nomeAgente;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public string NomeAgente
        {
            get { return nomeAgente; }
            set { nomeAgente = value; }
        }


    }
}
