using System;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int temp = 0;
            int num = Int32.Parse(Console.ReadLine());
            for (int i = num - 1; i > 0; i--)
            {
                if(num % i == 0)
                {
                    sum += i;
                }
            }

            if (num == sum)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
