internal class Program
{
    private static void Main(string[] args)
    {
        int per;
        int con = 1;
        int bol = 0;
        int din = 0;
        string tipo;

        Console.Write("Ingrese cuantas personas compraran boleto en la prueba: ");
        per = int.Parse(Console.ReadLine());

        while (con <= per)
        {

            Console.Write("Ingrese tipo de boleto a=adulto, n=nino: ");
            tipo = Console.ReadLine().ToLower();

            if (tipo == "a")
            {
                bol = bol + 1;
                din = din + 15;
                Console.WriteLine("Se sumo un boleto de adulto.");
            }
            else if (tipo == "n")
            {
                bol = bol + 1;
                din = din + 10;
                Console.WriteLine("Se sumo un boleto de nino.");
            }
            else
            {
                Console.WriteLine("Tipo incorrecto, no se suma boleto.");
            }

            Console.WriteLine("Total boletos: " + bol + "  Total dinero: " + din);
            Console.WriteLine("----------------------------------------");
            con = con + 1;
        }

        Console.WriteLine("Resultado de la prueba:");
        Console.WriteLine("Boletos vendidos: " + bol);
        Console.WriteLine("Dinero cobrado: " + din);
        Console.WriteLine("Presione una tecla para salir...");
    }
}