
namespace ConsoleApp5
{
    internal class TriangleArea
    {
        static void Main(string[] args)
        {
            
            /* 삼각형 넓이 */
            Console.Write("너비를 입력해 주세요 : ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("높이를 입력해 주세요 : ");
            int height = int.Parse(Console.ReadLine());
            
            double result =  0.5 * width * height; //수식
            // double result =  (width * height) / 2.0;  // 2.0 소수점 해야 실수 자료형의 값이 출력 혹은 double(2) 캐스팅 double

            Console.WriteLine($"삼각형의 넓이는 {result} 입니다.");

        }
    }
}
