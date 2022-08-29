using System;

namespace _08._Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num1; i++)
            {
                if (i % 2 == 0)
                    for (int j = 2; j <= 7; j++)
                    {
                        if (j != 4 && j != 6 && j <= num2)

                            for (int k = 2; k <= num3; k++)
                            {
                                if (k % 2 == 0)
                                    Console.WriteLine($"{i} {j} {k}");
                            }
                    }

            }

        }
    }
}
