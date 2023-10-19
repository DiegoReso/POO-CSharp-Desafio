using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone i1 = new Iphone("24999571026", "Iphone14 PRO MAX", "123456789", 128);

Iphone i2 = new Iphone("24998527928", "Iphone14 PRO MAX", "987654321", 128);

Nokia n1 = new Nokia("24445698787", "Nokia Tijolao", "123654321123", 500);

Nokia n2 = new Nokia("24445698731", "Nokia Tijolex", "123654", 500);


Console.WriteLine(n1.Numero);
Console.WriteLine(n2.Numero);
Console.WriteLine(i1.Numero);
Console.WriteLine(n2.Numero);

i1.ReceberLigacao();
n1.ReceberLigacao();


i1.InstalarAplicativo("Tibia Me");
n1.InstalarAplicativo("WIld Rift");