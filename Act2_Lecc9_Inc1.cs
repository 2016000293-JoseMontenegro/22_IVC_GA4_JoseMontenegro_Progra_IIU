internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("========= NIVEL 5 =========");
        int monedas;

        Console.WriteLine("Ingrese la cantidad de monedas:");
        monedas = Convert.ToInt32(Console.ReadLine());

        if (monedas >= 350)
        {
            Console.WriteLine("Puedes ingresar al nivel 5");
        }
        else
        {
            Console.WriteLine("Nivel 5 bloqueado, necesitas mas monedas");
        }
    }
}