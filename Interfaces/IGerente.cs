namespace HotelCsharp.Interfaces
{
    public interface IGerente : ICamareira, IRecepcionista, IPessoa
    {
       void ConhecerMuitoBemOHotel(); 
    }
}