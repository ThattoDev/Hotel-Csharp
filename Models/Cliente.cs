namespace HotelCsharp.Models
{
    public class Cliente : Pessoa
    {
         public Cliente() : base()
        {
        }

        public Cliente(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {

        }

        public override void SeApresentar()
        {
            throw new NotImplementedException();
        }
    }
}