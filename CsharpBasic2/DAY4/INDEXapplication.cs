namespace QUIZ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();


            string outtext = "";
            for (int i = str.Length-1; i >= 0; i--) //인덱스 값을 거꾸로 출력
            {
                outtext += str[i];
            }
            Console.WriteLine(outtext);

        }
    }
}
