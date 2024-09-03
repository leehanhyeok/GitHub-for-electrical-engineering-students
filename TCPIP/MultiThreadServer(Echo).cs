using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace MultiThreadServerV1
{
    internal class Program
    {
        static int cnt = 0;
        
        static void Main(string[] args)
        {
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();

            serverThread.Join();
            Console.WriteLine("서버프로그램을 종료합니다.");
        }

        private static void serverFunc(object obj)  //매개변수 전달 기능 
        {
            using (Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 13000);
                srvSocket.Bind(endPoint);
                srvSocket.Listen(50);

                Console.WriteLine("서버 시작 . . .");
                while (true) //클라이언트 꺼지지 않음 
                {
                    Socket clientSocket = srvSocket.Accept(); //Accept 되면 clisocket의 위치를 알게 됨 
                    cnt++;
                    Thread workThread = new Thread(new ParameterizedThreadStart(workFunc));//ParameterizedThreadStart 사용시 매개변수 전달가능 
                    workThread.IsBackground=true;

                    workThread.Start(clientSocket);
                } //1대1 통신을 1대다로 

            }
        }

        private static void workFunc(object obj) //클라이언트 소켓을 가지고 
        {
            byte[] recvBytes = new byte[2048];
            Socket clientSocket = (Socket)obj;
            int nRecv = clientSocket.Receive(recvBytes);

            string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
            Console.WriteLine($"클라이언트 번호 {cnt} : {txt}");
            byte[] sendBytes = Encoding.UTF8.GetBytes("Hello : "+txt);
            clientSocket.Send(sendBytes);
            clientSocket.Close();
        }
    }
}
