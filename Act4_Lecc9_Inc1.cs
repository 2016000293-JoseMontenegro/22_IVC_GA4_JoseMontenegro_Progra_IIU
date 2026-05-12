internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TABLA DE MULTIPLICAR");

        int num, resultado;

        Console.WriteLine("Ingrese un numero:");
        num = Convert.ToInt32(Console.ReadLine());

        for (int v = 1; v <= 10; v++)
        {
            resultado = num * v;
            Console.WriteLine(num + " x " + v + " = " + resultado);
        }
    }
}