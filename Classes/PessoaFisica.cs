namespace AulaPOO_Heranca.Classes
{
    public class PessoaFisica : Pessoa // = Nome da subclasse, chamando a herança e classe Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(string documento)
        {
            if (documento != ""){
                return true;
            }
            return false;
        }
    }
}