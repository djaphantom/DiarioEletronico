
namespace Model
{
    public class Aluno
    {
        private int id;
        private int id_Turma;
        private int id_cidade;
        private int id_sexo;
        private string nomeAluno;
        private string enderecoAluno;
        private string telefoneResponsavel;
        private string email;
        private string dataDeNascimanto;
        private string setor;
        private string cep;
        private string nomeResponsavel;
        private int numero;
        private string senha;
        private string cpf;
        private string NomeUsuario;



        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Turma
        {
            get { return id_Turma; }
            set { id_Turma = value; }
        }
        public int Id_Cidade
        {
            get { return id_cidade; }
            set { id_cidade = value; }
        }
        public int Id_Sexo
        {
            get { return id_sexo; }
            set { id_sexo = value; }
        }

        public string NomeAluno
        {
            get { return nomeAluno; }
            set {nomeAluno = value;}
        }

        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }

        public string EnderecoAluno
        {
            get { return enderecoAluno; }
            set { enderecoAluno = value; }
        }

        public string TelefoneResponsavel
        {
            get { return telefoneResponsavel; }
            set { telefoneResponsavel = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string DataDeNascimento
        {
            get { return dataDeNascimanto; }
            set { dataDeNascimanto = value; }
        }

        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string NomeResponsavel
        {
            get { return nomeResponsavel; }
            set { nomeResponsavel = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string nomeUsuario
        {
            get { return NomeUsuario; }
            set { NomeUsuario = value; }
        }

    }
}
