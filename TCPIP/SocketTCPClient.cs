using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketTCPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Client 소켓 만들기, 서버 접속을 위한 소켓 만들기 
            IPAddress serverAddr = IPAddress.Parse("127.0.0.1");
            int port = 13000;

            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 2. Connect 
            clientSocket.Connect(new IPEndPoint(serverAddr, port)); // 종단에 접속 
            Console.WriteLine("서버에 연결 되었습니다. ");

            // 3. Read, Write
            byte[] bytes = new byte[1024];
            int byteRecived = clientSocket.Receive(bytes);

                //받은메시지 출력
            string message = Encoding.UTF8.GetString(bytes, 0, byteRecived);
            Console.WriteLine($"서버로 부터 받은 내용 : {message}");

            // 4. Close 
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }
}
