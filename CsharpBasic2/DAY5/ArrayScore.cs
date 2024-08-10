using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using static System.Formats.Asn1.AsnWriter;

namespace scoerApp
{
    internal class Program
    {
        static int[] InputThreeScore()
        {
            int[] score = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("점수입력 : ");
                score[i] = Int32.Parse(Console.ReadLine());
            }
            return score;
        }

        static int TotalScore(int[] score)
        {
            int sum = score[0] + score[1] + score[2];
            return sum;
        }

        static double GetAvg(int sum)
        {
            double avg = sum / 3.0;
            return avg;
        }

        static void Main(string[] args)
        {
            int[] score = InputThreeScore();
            int sum = TotalScore(score);  
            double avg = GetAvg(sum);

            Console.WriteLine($"총점 : {sum}");
            Console.WriteLine($"평균 : {avg:F2}");
        }
    }
}

