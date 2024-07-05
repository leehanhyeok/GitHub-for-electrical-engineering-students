using System.Diagnostics.CodeAnalysis;

namespace scoreArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[3];
            int sum = 0;
            //score[0] 국어성적 ... 

            /*
            Console.Write("국어성적 : ");
            score[0] = Int32.Parse(Console.ReadLine());
            Console.Write("영어성적 : ");
            score[1] = Int32.Parse(Console.ReadLine());   //원시적
            Console.Write("수학성적 : ");
            score[2] = Int32.Parse(Console.ReadLine());
            */
            for (int i = 0; i < score.Length; i++)
            {
                Console.Write("점수를 입력하시오: ");
                score[i] = Int32.Parse(Console.ReadLine());
                sum+= score[i];
            }
           
            double avr = (double)sum / 3;

            Console.WriteLine($"총점 : {sum}");
            Console.WriteLine($"평균 : {avr:F2}"); //소수점 2자리 까지 출력
        }
    }
}
