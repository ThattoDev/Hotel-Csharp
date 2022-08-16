using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public abstract class Pessoa : IPessoa
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

        public virtual void SeApresentar()
        {
            Console.WriteLine("Prazer, sou a pessoa " + Nome);
            Console.WriteLine();;
        }
    }
}