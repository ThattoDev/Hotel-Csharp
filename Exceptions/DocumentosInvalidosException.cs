namespace HotelCsharp.Exceptions
{
    public class DocumentosInvalidosException : Exception
    {
        public DocumentosInvalidosException() 
        : base("Documentos inválidos")
        {

        }

        public DocumentosInvalidosException(string mensagem) : base (mensagem)
        {

        }
    }
}