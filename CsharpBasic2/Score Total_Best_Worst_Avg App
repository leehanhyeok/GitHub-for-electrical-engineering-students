using System.Diagnostics.CodeAnalysis;

namespace RandomScoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] score = new int[3];

            for (int i = 0; i < score.Length; i++)
            {

                score[i] = random.Next(70,101);
            }

            Console.WriteLine($"총점 : {score.Sum()}");
            Console.WriteLine($"가장 높은 점수 : {score.Max()}");
            Console.WriteLine($"가장 낮은 점수 : {score.Min()}");
            Console.WriteLine($"평균 점수 : {score.Average():F2}");
        }
    }
}
