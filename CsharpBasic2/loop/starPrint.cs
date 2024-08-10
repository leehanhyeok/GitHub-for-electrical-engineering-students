namespace starApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N? : ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++) //j 변수를 i에 따라가면 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
