using System;

namespace _10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coins1 = int.Parse(Console.ReadLine());
            int coins2 = int.Parse(Console.ReadLine());
            int bancnotes = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());


            int coins = 0;
            while (sum != 0)
            {
                if (sum - 1 >= 0)
                {
                    sum -= 1;
                    coins++;
                }
                if (sum - 2 >= 0)
                {
                    sum -= 2;
                    coins++;
                }
                if (sum - 5 >= 0)
                {
                    sum -=5;
                    coins++;
                }

            }
            Console.WriteLine($"{coins1} * 1 lv. + {coins2} * 2 lv. + {bancnotes} * 5 lv. = {sum} lv.");

        }
    }
}
