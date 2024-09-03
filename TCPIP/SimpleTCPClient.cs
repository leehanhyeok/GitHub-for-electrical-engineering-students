using System.Net.Sockets;
using System.Text;

namespace SimpleTCPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "192.168.0.11"; //보낼 서버 주소 
            int port = 13000;

            // 1. 서버로 접속할 클라이언트 소켓 만들기 
            // 성공시 접속됨 connect
            using (TcpClient client = new TcpClient(server, port))
            {
                //2. 메시지 받기 
                NetworkStream stream = client.GetStream();
                byte[] data = new byte[256]; //데이터 크기만큼 받아옴 
                int bytes = stream.Read(data, 0, data.Length);
                String responseData = Encoding.UTF8.GetString(data, 0, bytes);
                Console.WriteLine($"받은 메시지 : {responseData}");
            } 
        }
    }
}
