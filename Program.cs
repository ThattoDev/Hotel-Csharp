using HotelCsharp.Interfaces;
using HotelCsharp.Models;

Console.WriteLine("****************************************");
Console.WriteLine("*************Hotel Csharp***************");
Console.WriteLine("****************************************");
Console.WriteLine();

//Contratar uma camareira

ICamareira camareira1 = new Camareira("Chica da Silva", "12345678901", "021997766559");
ICamareira camareira2 = new Camareira("Maria da Silva", "12345688720", "021997766349");


// Contratar recepcionista

IRecepcionista recepcionista1 = new Recepcionista("Douglas castanho", "22334456709", "011987654320");
IRecepcionista recepcionista2 = new Recepcionista()
{
    Nome = "Mariana Coelho",
    CPF = "12876545423",
    Telefone = "021988778878"
};


IGerente gerente = new Gerente("Batatinha", "122334556787", "21908765432");

// Inauguração do \Hotel

Hotel hotel = new Hotel("Hotel CSharp", new Endereco()
{
    CEP = "25955100",
    Rua = "Fileuterpe",
    Numero = 379,
    Complemento = "esquina do pecado",
    Bairro = "Lugar do fim",
    Cidade = "Any"
});

// Contratando 2 Camareiras
hotel.ContratarCamareira(camareira1);
hotel.ContratarCamareira(camareira2);

// Cotratar Recepcionistas
hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista2);

//Contratar faz tudo.
hotel.ContratarCamareira(gerente);
hotel.ContratarRecepcionista(gerente);

// Gerente
hotel.Gerente.SeApresentar();
hotel.Gerente.ArrumarACama();
hotel.Gerente.AtenderOTelefone();
hotel.Gerente.ConhecerMuitoBemOHotel();
hotel.Gerente.FalarInglesBasico();

foreach (var camareira in hotel.Camareiras)
{
    camareira.SeApresentar();
    camareira.ArrumarACama();
    camareira.LimparOQuarto();
}

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.SeApresentar();
    recepcionista.AtenderOTelefone();
    recepcionista.FalarInglesBasico();
}

// Daqui pra baixo será tudo com o RH
IRHTerceirizado rh = new RH("RH CSharp", hotel);

// Contratar uma camareira.
var camareira3 = new Camareira
{
    Nome = "|Eujeca Turbo"
};
rh.ContratarCamareira(camareira3);
// Contratar recepcionista.
var recepcionista3 = new Recepcionista
{
    Nome = "Joyce Pulga"
};
rh.ContratarRecepcionista(recepcionista3);
// Promover camareira.
var camareira4 = new Camareira{
    Nome = "Eujequinha Limeira"
};

try
{
    rh.PromoverParaGerente(camareira4);    
}
catch (Exception ex)
{
    
    Console.WriteLine(ex.Message);
}

Console.WriteLine();


// Promover recepcionista.

var recepcionistaPromocao = new Recepcionista
{
    Nome = "Amanda Azelman",
    CPF = "03344334456"
};

try
{
    rh.PromoverParaGerente(recepcionistaPromocao);    
}
catch (Exception ex)
{
    
    Console.WriteLine(ex.Message);
}

Console.WriteLine();