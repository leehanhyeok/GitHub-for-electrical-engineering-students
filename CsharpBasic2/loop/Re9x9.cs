namespace GuGuDan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for( int i = 9; i>1; i--)
            {
                for(int j = 9; j>0; j--)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}
