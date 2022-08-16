using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Gerente : Pessoa, IGerente //Herança só é possível de uma classe pai, mas implementação de interfaces, quantas eu quiser.
    {
        //Por se tratar de um costrutor padrão, este
        //não necessita de informar que é de base()
        public Gerente() : base()
        {
        }

        public Gerente(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {
        }

        public void ArrumarACama()
        {
            Console.WriteLine("Sou o gerente e sei arrumar a cama.");
            Console.WriteLine();
        }

        public void AtenderOTelefone()
        {
            Console.WriteLine("Sou o gerente e sei atender o telefone.");
            Console.WriteLine();
        }

        public void ConhecerMuitoBemOHotel()
        {
            Console.WriteLine("Sou gerente e conheç tudo sobre o hotel.");
            Console.WriteLine();
        }

        public void FalarInglesBasico()
        {
            Console.WriteLine("Sou o gerente e domino o inglês.");
            Console.WriteLine();
        }

        public void LimparOQuarto()
        {
            Console.WriteLine("Sou o gerente e sei limpar o quarto.");
            Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Prazer, sou o gerente " + Nome);
            Console.WriteLine();
        }
    }
}