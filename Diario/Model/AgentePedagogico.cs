namespace Model
{
    public class AgentePedagogico
    {
        private int id;
        private string senha;
        private string nomeAgente;
        private string NomeUsuario;

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

        public string nomeUsuario
        {
            get { return NomeUsuario; }
            set { NomeUsuario = value; }
        }


    }
}
