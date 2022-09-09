using Zoologico;

Console.WriteLine("=== Testando poliformismo de sobreposição ====\n");

Tartaruga t = new();
t.Locomover();

Arara a = new();
a.FazerNinho();

Console.WriteLine("\n=== Testando poliformismo de sobrecarga ====\n");

Cachorro c = new();
//c.Reagir("Olá"); 
//c.Reagir("Vai apanhar");
//c.Reagir(11, 45);
//c.Reagir(21, 00);
//c.Reagir(2, 12.5f);
//c.Reagir(17, 4.5f);
c.Reagir(true);
c.Reagir(false);
