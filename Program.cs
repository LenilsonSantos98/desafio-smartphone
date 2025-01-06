using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Criando o Iphone");
Smartphone iphone = new Iphone(numero:"135", modelo: "iphone 4", imei: "1234", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");



Console.WriteLine("Criando o Nokia");
Smartphone nokia = new Nokia(numero:"248", modelo: "Modelo3", imei: "6789", memoria: 128 );
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

