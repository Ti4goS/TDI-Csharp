int n1, n2;

Console.WriteLine("Informe o primeiro número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número");
n2 = int.Parse(Console.ReadLine());

while (n1 <= n2)
{
    Console.WriteLine(n1);
    n1++;
}