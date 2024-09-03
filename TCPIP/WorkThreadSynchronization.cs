using System.Reflection;

namespace WorkThread01
{
    internal class Program
    {
        //스레드 동기화
        private static readonly object lockObject = new object();
        static void Main(string[] args)
        {

            //Main Thread => 사장님 
            int ThreadCount = 5;

            Thread[] threads = new Thread[ThreadCount];

            for (int i = 0; i < ThreadCount; i++)
            {
                int threadIndex = i;
                threads[i] = new Thread( () => DoWork(threadIndex));
                threads[i].Start();
            }
            foreach(Thread thread in threads)
                thread.Join();

            Console.WriteLine("모든 작업이 완료 되었습니다.");
        }

        static void DoWork(int index)
        {
            lock (lockObject) //락을 준다 //다 시작을해야
            {
                Console.WriteLine($"스레드 {index} 시작 : 작업을 수행 중 . . .");
            }
          

            Thread.Sleep(1000);

            lock (lockObject) //완료
            {
                Console.WriteLine($"스레드 {index} 완료 : 작업이 끝났습니다 . . .");
            }
        }
    }
}
