internal class Program
{
    private static void Main(string[] args)
    {
        int primo = 0;
        int par = 0;

        for (int i = 300; i >= 1; i--)
        {

            if (i % 2 == 0)
            {
                par += i;
            }


            bool z = true;

            if (i <= 1)
            {
                z = false;
            }
            else
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        z = false;
                        break;
                    }
                }
            }

            if (z)
            {
                primo++;
            }
        }

        Console.WriteLine("Cantidad de números primos: " + primo);
        Console.WriteLine("Suma de números pares: " + par);
    }
}