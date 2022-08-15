namespace HotelCsharp.Models
{
    public class Gerente : Pessoa
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

        public override void SeApresentar()
        {
            throw new NotImplementedException();
        }
    }
}