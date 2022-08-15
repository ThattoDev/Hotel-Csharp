namespace HotelCsharp.Models
{
    public class Recepcionista : Pessoa
    {
         public Recepcionista() : base()
        {
        }

        public Recepcionista(string nome, string cpf, string telefone)
        : base(nome, cpf, telefone)
        {

        }

        public override void SeApresentar()
        {
            throw new NotImplementedException();
        }
    }
}