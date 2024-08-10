namespace DelegateApp01
{
    internal class Program
    {

        delegate void PrintDelegate(string str); //

        class Print
        {
            public void PrintOut(string str)
            {
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            Print p = new Print();
            PrintDelegate pdg = p.PrintOut; //Action //변수처럼 사용하고자 delegate 사용
            pdg("안녕하세요");
        }
    }
}
