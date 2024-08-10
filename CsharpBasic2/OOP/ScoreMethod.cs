namespace Quiz08
{
    internal class Program
    {
        static int[] InputScore()  //메소드 이름 대문자 대부분
        {
            int[] score = new int[3]; //여기 스코어는 아래 스코어와 상관 x
            for (int i = 0; i < 3; i++)
            {
                score[i] = Int32.Parse(Console.ReadLine());
            }
            return score; //복사되고 사라짐
        }
        static int GetSum(int[] score) // 배열을 받아와야 함 //매개변수는 선언된 것과 같음 
        {
            int sum = 0;

            for(int i=0; i<3; i++)
            {
                sum += score[i];
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int[] score = InputScore(); //국어 영어 수학 입력 받는 메소드 //배열에 값을 받아서 int[] score 에 넣음

            int sum = GetSum(score); //가져온 값(score)을 합산하는 메소드 //스코어 값을 복사해서

            Console.WriteLine($"총점: {sum}");
        }
    }
}
