namespace Recursive01
{
    internal class Program
    {
        static int Factorial(int n) // 큰 값 넣고자 하면 int 대신 BigInterger
        {
            if (n == 1)  //리턴은 무조건 한번만 호출 단 if로 예외사항 만들 수 있음
                return n;
            else
                return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(Factorial(a));
        }
    }
}
