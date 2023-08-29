using Aplicação_4;

double raio;
Console.WriteLine("Digite o valor do raio:");
raio = double.Parse(Console.ReadLine());

Circulo circulo = new Circulo(raio);

Console.WriteLine("Área do círculo -> " + circulo.Area());
Console.WriteLine("Comprimento do círculo -> " + circulo.Comprimento());