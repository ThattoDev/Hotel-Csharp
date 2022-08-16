using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Hotel
    {
        public String Nome {get; set;}
        public Endereco Endereco {get; set;}
        public List<IRecepcionista> Recepcionistas {get; private set;}
        public List<ICamareira> Camareiras {get; private set;}
        public IGerente Gerente {get; private set;}

        public Hotel(string nome)
        {
            Nome = nome;
            Recepcionistas = new List<IRecepcionista>();
            Camareiras = new List<ICamareira>();
        }

         public Hotel(string nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Recepcionistas = new List<IRecepcionista>();
            Camareiras = new List<ICamareira>();
        }

        public void ContratarGerente(IGerente gerente)
        {
            Gerente = gerente;
        }

        public void ContratarCamareira(ICamareira camareira)
        {
            Camareiras.Add(camareira);
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            Recepcionistas.Add(recepcionista);
        }
    }
}