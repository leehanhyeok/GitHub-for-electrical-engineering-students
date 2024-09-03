using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketTCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. ServerSocket 만들기
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");//루프백 주소 - 자동으로 내주소 들어감 
            int port = 13000;
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //프로토콜 내용에 따라 달라짐

            // 2. bind
            serverSocket.Bind(new IPEndPoint(localAddr, port));

            // 3. Listen 
            serverSocket.Listen(1); //백로그 
            Console.WriteLine("연결을 기다리는 중 . . .");

            // 4. Accept
            Socket clientSocket = serverSocket.Accept(); // 클라이언트 소켓에 담음
            Console.WriteLine("연결 성공 !");

            // 5. Read/Write 
            string message = "안녕하세요 클라이언트님!";
            byte[] bytes = new byte[1024];
            byte[] data = Encoding.UTF8.GetBytes(message); //직렬화 

            clientSocket.Send(data);
            Console.WriteLine($"전송한 메시지 : {message}");

            // 6. Close 
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }
}
