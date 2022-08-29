using System;

namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num3; i++)
            {
                string number = i.ToString();
                int evenNum = 0;
                int oddNum = 0;
                for (int j = 0; j < number.Length; j++)
                {
                    int currentDigit = int.Parse(number[j].ToString());
                    if (j % 2 == 0)
                    {
                        oddNum += currentDigit;
                    }
                    else
                    {
                        evenNum += currentDigit;
                    }
                }
                if (evenNum == oddNum)
                {
                    Console.WriteLine($"{j}");
                }
            }

        }
    }
}
