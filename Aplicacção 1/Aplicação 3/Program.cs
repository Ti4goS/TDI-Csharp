internal class Program
{
    private static void Main(string[] args)
    {
       
        // Criando a coleção Stack (pilha) e inserindo os valores
        Stack<int> stack = new Stack<int>();
        stack.Push(5);
        stack.Push(7);
        stack.Push(9);
        stack.Push(4);
        stack.Push(5);

        Console.WriteLine("Valores na pilha (Stack):");
        PrintAndRemoveItems(stack);

        // Criando a coleção List (lista) e inserindo os valores
        List<int> list = new List<int> { 5, 7, 9, 4, 5 };

        Console.WriteLine("\nValores na lista (List):");
        PrintAndRemoveItems(list);

        // Criando a coleção Queue (fila) e inserindo os valores
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(5);
        queue.Enqueue(7);
        queue.Enqueue(9);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Console.WriteLine("\nValores na fila (Queue):");
        PrintAndRemoveItems(queue);

        // Criando a coleção HashSet e inserindo os valores
        HashSet<int> set = new HashSet<int> { 5, 7, 9, 4, 5 };

        Console.WriteLine("\nValores no conjunto (HashSet):");
        PrintAndRemoveItems(set);
    }

    static void PrintAndRemoveItems<T>(ICollection<T> collection)
    {
        foreach (T item in collection.ToList())
        {
            Console.WriteLine(item);
            collection.Remove(item);
        }
    }
}