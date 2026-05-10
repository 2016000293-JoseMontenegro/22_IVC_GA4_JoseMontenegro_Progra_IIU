//VisualStudio
internal class Program
{
    private static void Main(string[] args)
    {
        const int TOTAL_SELLOS = 8;
        Console.WriteLine("-------CUPONERA DE BARBERÍA DON CRUP-------");

        for (int i = 1; i <= TOTAL_SELLOS; i++) //Acumulador
        {
            Console.WriteLine("\n Sello actual {0} de {1} ",i, TOTAL_SELLOS);
            Console.WriteLine("Presione cualquier tecla para registrar esta visita");
            Console.ReadKey();//Presionar una tecla para de continuar

            Console.WriteLine(">>>Sellos #{0} registrado correctamente...");
        }
        Console.WriteLine("\n******************************************");
        Console.WriteLine("¡CUPONERA COMPLETA!");
        Console.WriteLine("Orozco, has ganado tu corte de cabello GRATIS");
        Console.WriteLine("\n******************************************");

        Console.WriteLine("\n Presione una tecla para cerrar...");
        Console.ReadKey();
    }
}
