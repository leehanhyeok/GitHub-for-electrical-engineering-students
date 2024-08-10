using Microsoft.VisualBasic;
using System.Diagnostics.Tracing;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.Write("첫 번째 숫자를 입력하세요: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.Write("연산자(+,-,*,/) 를 입력하세요: ");
            string oper = Console.ReadLine();

            Console.Write("두 번째 숫자를 입력하세요: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if (oper == "+")
            {
                Console.WriteLine($"결과는 {num + num2} 입니다.");
            }
            else if (oper == "-")
            {
                Console.WriteLine($"결과는 {num - num2} 입니다.");
            }
            else if (oper == "*")
            {
                Console.WriteLine($"결과는 {num * num2} 입니다.");
            }
            else if (oper == "/")
            {
                Console.WriteLine($"결과는 {(double)num - num2} 입니다.");
            }

            
                Console.WriteLine("계산을 계속하시겠습니까? (Y/N)");
                string word = Console.ReadLine();  
                if (word.ToLower() == "n") // 대소문자 상관 없이 처리 (입력받은 값을 소문자로 치환하여 처리)
                {
                    Console.WriteLine("종료합니다");
                    break;
                }
                else if (word.ToLower() == "y")
                {
                    continue;
                }
            }
        }
    }
}
