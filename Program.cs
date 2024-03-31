using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("9998888", "Nokia Blaster", "55555", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("instagram");

Console.WriteLine("________________\n\n\n");

Console.WriteLine("Smartphone IPhone");
Smartphone iphone = new Iphone("9998888", "Iphone 14 Pro Max", "22222", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");

