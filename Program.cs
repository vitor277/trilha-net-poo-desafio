using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Cel Nokia");
Smartphone celular1 = new Nokia("7", "Plus", "111222", 64);
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Testando Cel IPhone");
Smartphone celular2 = new Iphone("X", "Plus", "333555", 128);
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Facebook");
