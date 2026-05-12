internal class Program
{
    private static void Main(string[] args)
    {
        int pesoTot = 0;
        int pesoManz = 0;
        int manz = 0;

        while (pesoTot < 1000) 
        {
            Console.WriteLine("Ingrese el peso de la manzana en gramos: ");
            pesoManz = Convert.ToInt32(Console.ReadLine());

            if (pesoManz >= 180 && pesoManz <= 200)
            {
                pesoTot = pesoTot + pesoManz;
                manz++;
                Console.WriteLine("Llevas: " + pesoTot + "g");
            }
            else
            {
                Console.WriteLine("Manzana Inválida");
            }
        }
        Console.WriteLine("Ya tienes 1 kg o más de manzanas");
        Console.WriteLine("Total de manzanas: "+manz);
    }
}