int n1, n2, soma, sub, multi, resto, div;

Console.WriteLine("Informe o primeiro número");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número");
n2 = int.Parse(Console.ReadLine());

soma = n1 + n2;
Console.WriteLine("Soma ->" + soma);

sub = n1 - n2;
Console.WriteLine("Sbtração ->" + sub);

multi = n1 * n2;
Console.WriteLine("Multiplicação ->" + multi);

resto = n1 % n2;
Console.WriteLine("Resto -> " + resto);

div = n1 / n2;
Console.WriteLine("Divisão ->" + div);


