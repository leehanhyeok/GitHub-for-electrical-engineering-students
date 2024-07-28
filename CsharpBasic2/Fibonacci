namespace Fibonacci
{
    public class Solution
    {
        public int Fibonacci(int n)
        {
            if(n == 0) 
                return 0;
            if(n == 1)
                return 1;

            return (Fibonacci(n-1) + Fibonacci(n-2)) % 1234567; //스택이 쌓이면서 풀림 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.Fibonacci(3)); 
        }
    }
}
