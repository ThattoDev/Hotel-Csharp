using HotelCsharp.Exceptions;
using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class RH : IRHTerceirizado
    {
        public String Nome {get; set;}
        public Hotel Hotel {get; set;}

        public RH(string nome, Hotel hotel)
        {
            Nome = nome;
            Hotel = hotel;
        }

        public void ContratarCamareira(ICamareira camareira)
        {
            Hotel.Camareiras.Add(camareira);
        }

        public void ContratarRecepcionista(IRecepcionista recepcionista)
        {
            Hotel.Recepcionistas.Add(recepcionista);
        }

        public void PromoverParaGerente(Camareira camareira)
        {
            // Lógica para entrevista
            if(camareira.CPF == null)
            {
                throw new Exception("Regularize seu cpf para receber a promoção");
            }

            Hotel.ContratarGerente(new Gerente(){
                Nome = camareira.Nome,
                CPF = camareira.CPF,
                Telefone = camareira.Telefone
            });
        }

        public void PromoverParaGerente(Recepcionista recepcionista)
        {
            // Lógica para entrevista
            if(recepcionista.CPF == null)
            {
                throw new DocumentosInvalidosException();
            }
            
            Hotel.ContratarGerente(new Gerente(){
                Nome = recepcionista.Nome,
                CPF = recepcionista.CPF,
                Telefone = recepcionista.Telefone
            });
        }
    }
}