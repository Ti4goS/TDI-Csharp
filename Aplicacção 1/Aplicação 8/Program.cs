int n1;

Console.WriteLine("Informe um número:");
n1 = int.Parse(Console.ReadLine());

if (n1 >= 10 && n1 <= 100)
{
    Console.WriteLine("Está entre 10 e 100");
}
else
{
    Console.WriteLine("Número está fora do intervalo entre 10 e 100");
}