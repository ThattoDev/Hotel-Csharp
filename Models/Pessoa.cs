namespace HotelCsharp.Models
{
    public abstract class Pessoa
    {
        public String Nome{get; set;}
        public String CPF{get; set;}
        public String Telefone{get; set;}

        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public abstract void SeApresentar();
    }
}