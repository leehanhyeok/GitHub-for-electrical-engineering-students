namespace QUIZ10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -7, 5, 60, -33, 42 };
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++) 
            { 
                if (arr[i] > max) //max>arr[i] 로 하면 안됨, arr을 조사했는데 맥스보다 큰 값이 있다면 max에 넣어야 함/현재의 요소값이 max보다 크다면)
                    max = arr[i];
            }
            Console.WriteLine($"최대값은 : {max}");
        }
    }
}
