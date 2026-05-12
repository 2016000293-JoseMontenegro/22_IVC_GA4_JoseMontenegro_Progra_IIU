internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 1;

        Console.WriteLine("Números impares entre 1 y 100:");

        do
        {
            Console.WriteLine(numero);
            numero += 2;

        } while (numero <= 100);

        Console.WriteLine("\nFin del programa.");
    }
}