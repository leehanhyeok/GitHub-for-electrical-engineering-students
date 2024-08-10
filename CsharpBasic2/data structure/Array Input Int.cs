namespace Array03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // 선언과 동시 초기화

            //Console.WriteLine(numbers[9]); // 10을 찍고 싶다면

            //값
            for (int i = 1; i < numbers.Length; i ++)
            {
                if (numbers[i] % 2 ==0) //짝수 출력
                    Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            //Index
            for (int i = 1; i < numbers.Length; i += 2)//짝수 출력
            {
                Console.WriteLine(numbers[i]); 
            }
        }
    }
}
