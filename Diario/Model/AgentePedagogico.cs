namespace Model
{
    public class AgentePedagogico
    {
        private int id;
        private int senha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        private string nomeAgente;

        public string NomeAgente
        {
            get { return nomeAgente; }
            set { nomeAgente = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}
