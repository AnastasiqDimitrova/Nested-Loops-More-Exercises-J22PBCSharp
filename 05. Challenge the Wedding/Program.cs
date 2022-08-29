using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int numberOfTables = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    if (i * j <= numberOfTables)
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}

