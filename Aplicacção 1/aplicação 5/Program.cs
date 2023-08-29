class Animal
{
    public virtual bool EhMamifero()
    {
        return false;
    }
}

class Mamifero : Animal
{
    public override bool EhMamifero()
    {
        return true;
    }
}

class Ave : Animal
{
    public override bool EhMamifero()
    {
        return false;
    }
}

class Program
{
    static void Main()
    {
        Animal animal1 = new Mamifero();
        Animal animal2 = new Ave();

        Console.WriteLine("Animal 1 é mamífero? " + animal1.EhMamifero());
        Console.WriteLine("Animal 2 é mamífero? " + animal2.EhMamifero());
    }
}