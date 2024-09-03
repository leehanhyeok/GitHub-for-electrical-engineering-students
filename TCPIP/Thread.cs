namespace ThreadTest001
{
    internal class Program
    {
        static void threadFunc()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello World!");
        }
        static void Main(string[] args)
        {
           
            Thread t1 = new Thread(new ThreadStart(threadFunc));
            //t1.IsBackground = true; //main 같이 끝남 
            t1 .Start(); //back 그라운드 없다면 main이 끝나고 thread 종료 

            //t1 .Join(); //main이 끝나기를 기다림 

            Console.WriteLine("Main 프로그램 종료");
        }
    }
}
