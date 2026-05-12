internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("NUMEROS IMPARES");

        int num;

        Console.WriteLine("Ingrese un numero mayor o igual a 20:");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 20; i <= num; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}