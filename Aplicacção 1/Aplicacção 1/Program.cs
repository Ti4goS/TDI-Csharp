using Aplicacção_1;

internal class Program
{
    private static void Main(string[] args)
    {
        TempRecord tempRecord = new TempRecord();

        tempRecord[3] = 58.3F;
        tempRecord[5] = 60.1F;

        for(int i = 0; i < 10;i++)
        {
            System.Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
        }

        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();
    }
}