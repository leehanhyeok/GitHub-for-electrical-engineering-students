namespace DelegateApp01
{
    internal class Program
    {

        public delegate int Compute(int a, int b); //
        
        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;

            Compute compute = Plus;
            Console.WriteLine($"덧셈을 하게 됩니다. : {compute(x,y)}"); //변수처럼 들어옴 

            compute = Minus;
            Console.WriteLine($"뺼셈을 하게 됩니다. : {compute(x,y)}");

            compute = Multiple;
            Console.WriteLine($"곱셈을 하게 됩니다. : {compute(x, y)}");

            compute = Divide;
            Console.WriteLine($"나눗셈을 하게 됩니다. : {compute(x, y)}");
        }

        //참조 메소드 

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Multiple(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
