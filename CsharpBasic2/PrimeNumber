namespace PracticeAlg
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //전수조사는 대부분 2중반복
            //변수를 도구처럼 사용할 수 있어야 한다
            bool flag = false; //플래그 변수

            for (int i = 2; i <= 100; i++)//2부터 소수이므로
            {
                for (int j = 2; j < i; j++)//1과 자기 자신으로 나눠져야하므로
                {
                    //플래그 변수 필요
                    if (i % j == 0)
                    {
                        flag = true; //약수가 나와버리면
                        break; //끝
                    }
                }

                if (flag == false) //플래그가 실행이 안될경우
                    Console.Write($"{i} ");
                flag = false; // 플래그 감지 이후 다음번 조사를 위해 플래그 초기화
            }
            Console.WriteLine();
        }
    }
}
