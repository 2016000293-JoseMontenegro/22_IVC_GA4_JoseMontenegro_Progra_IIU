internal class Program
{
    private static void Main(string[] args)
    {
        int totBoletos = 0;
        double totDinero = 0;
        int opc = -1;

        Console.WriteLine("--- Control de Acceso: Rueda de la Fortuna ---");

        while (opc != 0)
        {
            Console.WriteLine("\nElija una opción:");
            Console.WriteLine("1. Vender boleto Adulto ($15)");
            Console.WriteLine("2. Vender boleto Niño ($10)");
            Console.WriteLine("0. Salir y mostrar totales");

            if (int.TryParse(Console.ReadLine(), out opc))
            {
                switch (opc)
                {
                    case 1:
                        totBoletos++;
                        totDinero += 15;
                        Console.WriteLine("Boleto de adulto sumado.");
                        break;
                    case 2:
                        totBoletos++;
                        totDinero += 10;
                        Console.WriteLine(" Boleto de niño sumado.");
                        break;
                    case 0:
                        Console.WriteLine("Generando reporte final...");
                        break;
                    default:
                        Console.WriteLine(" Opción inválida.");
                        break;
                }

                if (opc != 0)
                {
                    Console.WriteLine("ACTUAL: " + totBoletos + " boletos, Caja: " + totDinero);
                }
            }
        }

        Console.WriteLine("\n======================================");
        Console.WriteLine("TOTAL DE BOLETOS VENDIDOS: " + totBoletos);
        Console.WriteLine("TOTAL DINERO RECAUDADO: " + totDinero);
        Console.WriteLine("======================================");
    }
}