using DesafioPOO.Models;

// Testes

Smartphone iphone = new Iphone("8954620788", "Iphone 14 Pro", 885422600, 128);
Smartphone nokia = new Nokia("8896542300", "Nokia C20", 854232100, 64);

Console.WriteLine("------------- Celular Iphone --------------");

iphone.Ligar();
Console.WriteLine();

iphone.InstalarAplicativo(" Instagram");

Console.WriteLine();

iphone.Numero = "Nr° 8954620788";
iphone.MostrarNumero();

iphone.ReceberLigacao();

Console.WriteLine("-------------- Celular Nokia --------------");

nokia.Ligar();
Console.WriteLine();

nokia.InstalarAplicativo(" linkedin");

Console.WriteLine();
nokia.Numero = "Nr° 8896542300";
nokia.MostrarNumero();

nokia.ReceberLigacao();
