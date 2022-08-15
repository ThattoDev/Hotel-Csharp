using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira() : base()
        {
        }

        public Camareira(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {

        }

        public void ArrumarACama()
        {
            Console.WriteLine("Arrumo a cama perfeitamente.");
            Console.WriteLine();
        }

        public void LimparOQuarto()
        {
            Console.WriteLine("Limpo o quarto perfeitamente.");
            Console.WriteLine();
        }

        public override void SeApresentar()
        {
            Console.WriteLine("Muito Pazer, sou a camareira: " + Nome);
        }
    }
}