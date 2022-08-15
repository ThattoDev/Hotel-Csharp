using HotelCsharp.Models;

Console.WriteLine("****************************************");
Console.WriteLine("*************Hotel Csharp***************");
Console.WriteLine("****************************************");
Console.WriteLine();

//Contratar uma camareira

var camareira = new Camareira("Chica da Silva", "12345678901", "021997766559");

camareira.SeApresentar();
Console.WriteLine();
camareira.ArrumarACama();
camareira.LimparOQuarto();