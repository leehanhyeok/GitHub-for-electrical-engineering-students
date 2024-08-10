namespace ExamApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i-=2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            int j = 99;
            while (j > 0)
            {
                Console.Write($"{j} ");
                j-=2;
            }
        }
    }
}
