//C#
internal class Program
{
    private static void Main(string[] args)
    {
        int cajonesOcupados = 0;
        const int CapacidadTotal = 10;
        string opc = "";

        Console.WriteLine("===CONTROL DE ACCESO AL CENTRO COMERCIAL===");

        do 
        {
            Console.WriteLine("\n ESTADO: {0} ocupados | {1} disponibles",
                cajonesOcupados , CapacidadTotal - cajonesOcupados);
            Console.WriteLine("¿Ingresar nuevo vehículo? (S/N)");
            opc = Console.ReadLine();

            if (opc == "S") 
            {
                cajonesOcupados++;//cajonesOcupados=cajonesOcupados+1
                Console.WriteLine(">>>Acceso Concedido. Levantando Talanquera");
            }
            else if (opc == "N") 
            {
                Console.WriteLine(">>>Opción Inválida. Use 'S' para sí o la 'N' para No...");
            }
        }
        while (opc != "N" && cajonesOcupados<CapacidadTotal);

        if (cajonesOcupados >= CapacidadTotal) 
        {
            Console.WriteLine("\n ******************************");
            Console.WriteLine("ALERTA: CUPO COMPLETADO. TALANQUERA BLOQUEADA.");
            Console.WriteLine("\n ******************************");
        }
        Console.WriteLine("\n Apagando el sistema de control.");
        Console.WriteLine("\n Presione una tecla para continuar.");
        Console.ReadKey(); //Esperar tecla
    }
}
