namespace MenuApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int select = 0;
            do
            {
                Console.WriteLine("1. 1~100까지 홀수만 출력합니다.");
                Console.WriteLine("2. 알파벳 A ~ Z / a ~ z 까지 출력합니다.");
                Console.WriteLine("3. 12와 18의 최대공약수(GCD)를 구해봅니다.");
                Console.WriteLine("4. 프로그램을 종료합니다.");
                Console.Write("선택 : ");
                select = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (select == 1)
                {
                    for (int i = 1; i < 100; i += 2)
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                }

                else if (select == 2)
                {
                    char[] word= new char[26];
                    for(int i = 0; i < word.Length; i++) //(int j = 'A'; j <= 'Z'; j++)
                    {
                        word[i] = (char)(i+65);  //cw($"{(char)k}");
                        Console.Write($"{word[i]} ");
                    }
                    Console.WriteLine();

                    char[] smallword = new char[26];
                    for (int i = 0; i < smallword.Length; i++)
                    {
                        word[i] = (char)(i + 97);
                        Console.Write($"{word[i]} "); ;
                    }
                    Console.WriteLine();
                }

                else if (select == 3) // 유클리드호제법
                {
                    int a = 12; int b = 18;
                    

                    while(b != 0)
                    {
                        int temp = b;
                        b = a % b;
                        a = temp;
                    }
                    Console.WriteLine($"최대공약수 : {a}");
                }

                else if (select == 4)
                {
                    Console.WriteLine("프로그램 종료");
                }
            } while (select != 4);
        }
    }
}
