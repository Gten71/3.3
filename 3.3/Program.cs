using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double S = 1;
                for (int i = 1; i <= n; i++)
                {
                    long F = 1;
                    for (int j = 1; j <= i; j++) F *= j;
                    S += x - 1 / (x + 1) + 1 / 3 * Math.Pow((x - 1 / x + 3), 3) + 1 / 5 * Math.Pow((x - 1 / x + 1), 5);
                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
