using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    // o sinal ":" significa herança, que está herdando de outra classe
    //o sinal "," significa implementando de uma interface.
    public class Recepcionista : Pessoa, IRecepcionista
    {
         public Recepcionista() : base()
        {
        }

        public Recepcionista(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {

        }

        public void AtenderOTelefone()
        {
            Console.WriteLine("Atendo o telefone perfeitamente.");
            Console.WriteLine();
        }

        public void FalarInglesBasico()
        {
            Console.WriteLine("Sei falar o ingês báscio.");
            Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Prazer, sou a recepcionista: " + Nome);
            Console.WriteLine();
        }
    }
}