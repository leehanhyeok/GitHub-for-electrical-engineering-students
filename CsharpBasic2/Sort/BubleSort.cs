namespace BubleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 4, 5, 7, 3, 2, 1, 9, 8 };
            int temp = 0;
            for (int i = list.Length - 1; i > 0; i--) //인덱스 7번부터
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[j]>list[j+1]) //j 가 j+1 크면
                    {
                        temp = list[j];
                        list[j] = list[j+1]; //j와 j+1 값을 뒤집음
                        list[j+1] = temp;
                    }
                }
            }
            foreach(int  i in list)
                Console.Write(i +" ");
        }
    }
}
