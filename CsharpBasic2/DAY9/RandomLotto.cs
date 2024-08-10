namespace RandomApp02

{

    internal class Program

    {

        static void Main(string[] args)

        {

            Random random = new Random();

            int[] num= new int[6];

            Console.Write($"로또번호 : ");



            for (int i = 0; i<num.Length; i++)

            {

                num[i] = random.Next(1,100);

                Console.Write($"{num[i]} ");

                

            }

            Console.WriteLine();

            Console.WriteLine($"보너스 번호 : {random.Next(1, 100)}");



        }

    }

}
