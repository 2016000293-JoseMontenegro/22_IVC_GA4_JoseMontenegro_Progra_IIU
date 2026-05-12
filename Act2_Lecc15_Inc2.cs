internal class Program
{
    private static void Main(string[] args)
    {
        int din, a, b, i;
        Console.WriteLine("===CLASIFICACION DE BILLETES===");
        a = 0;
        b = 0;
        for (i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese el billete " + i + ": ");
            if (int.TryParse(Console.ReadLine(), out din))
            {
                if (din == 100)
                {
                    a = a + 1;
                    b = b + 100;
                }
            }
        }
        Console.WriteLine("Cbilletes de 100 encontrados: " + a);
        Console.WriteLine("billetes de 100: " + b);
    }
}