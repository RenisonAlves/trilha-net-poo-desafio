using System.Security.AccessControl;
using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\n");

Console.WriteLine("Iphone XR");
Iphone iphone = new Iphone("123456789", "12x", "1123fgrt5w34", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Nokia N32");
Nokia nokia = new Nokia("(11) 99876-5432", "N32", "hR2234lfgtgd9", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("AzureApp");