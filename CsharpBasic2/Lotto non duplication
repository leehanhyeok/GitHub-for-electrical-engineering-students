namespace LottoApp04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] number = new int[7];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = random.Next(1, 46);

                //전수조사
                for (int j = 0; j < i; j++)
                {
                    if (number[i] == number[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            int bonusNumber = number[6]; //넘버 배열 6번을 보너스 넘버로 사용? 
            int[] lottoNumbers = new int[6]; //왜 로또번호 배열을 다시 만드는지?
            Array.Copy(number, 0, lottoNumbers, 0, 6);// array copy - sort 다시 알기

            Array.Sort(lottoNumbers);

            foreach (int i in lottoNumbers) //foreach 사용 (꺼낸다)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine($"보너스 번호 : {bonusNumber}");
        }
    }
}
