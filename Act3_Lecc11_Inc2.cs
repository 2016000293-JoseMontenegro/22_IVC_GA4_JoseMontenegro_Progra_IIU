internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;
        int numero;

        Console.WriteLine("--- Sumadora Automática ---");
        Console.WriteLine("Introduce números para terminar, escribe el 9.");

        do
        {
            Console.Write("Introduce un número: ");

            numero = int.Parse(Console.ReadLine());


            if (numero != 9)
            {
                suma += numero;
            }

        } while (numero != 9);

        Console.WriteLine("\n================================");
        Console.WriteLine($"La suma total es: " + suma);
        Console.WriteLine("================================");
    }
}