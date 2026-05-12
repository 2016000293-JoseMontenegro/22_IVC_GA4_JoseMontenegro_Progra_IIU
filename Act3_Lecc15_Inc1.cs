internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;
        int pare = 0;
        for (int i = 1; i <= 20; i++)
        {
            int multi = i * 7;
            suma = suma + multi;
            if (multi % 2 == 0)
            {
                pare = pare + 1;
            }
        }

        Console.WriteLine("La sumatoria es de:" + suma);
        Console.WriteLine("Los pares son " + pare);
    }
}