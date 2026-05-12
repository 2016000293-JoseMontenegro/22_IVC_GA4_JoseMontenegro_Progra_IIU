internal class Program
{
    private static void Main(string[] args)
    {
        int contadorPrimos = 0;
        int sumaPrimos = 0;

        for (int n = 1; n <= 100; n++)
        {
            if (EsPrimo(n))
            {
                contadorPrimos++;
                sumaPrimos += n;
            }
        }

        Console.WriteLine($"Entre 1 y 100 hay " + contadorPrimos + " números primos.");
        Console.WriteLine($"La suma total de ellos es: " + sumaPrimos);
    }


    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}