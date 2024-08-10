namespace RandomApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> lottoNumberList = new List<int>(); //제네릭 리스트(정수형 자료만 받음)

            while (lottoNumberList.Count < 7) //7개가 차기 전까지 계속 반복
            {
                int number = random.Next(1, 46);

                if (!lottoNumberList.Contains(number)) //숫자가 중복된 값을 포함하고 있는가 (메소드)
                    lottoNumberList.Add(number); //중복이 안된 숫자를 배열에 넣겠다.
            }
            //보너스 번호 0번지 첫번쨰 요소를 보너스 번호로 하자 
            int bonusNumber = lottoNumberList[0];
            lottoNumberList.RemoveAt(0); //보너스 번호 복사, 0번지의 값을 뽑음

            //정렬
            lottoNumberList.Sort();//리스트는 자체 정렬이 있음 
            foreach (int i in lottoNumberList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //보너스 번호 출력
            Console.WriteLine($"보너스 번호: {bonusNumber}");
        }
    }
}
