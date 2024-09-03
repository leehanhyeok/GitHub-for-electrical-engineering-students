using System.Net.Sockets;
using System.Text;

namespace EchoClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "127.0.0.1";
            int port = 13000;

            TcpClient client = new TcpClient(server, port);

            NetworkStream stream = client.GetStream();

            //보내기
            string greet = "안녕하세요";
            byte[] message = new byte[1024];
            message = Encoding.UTF8.GetBytes(greet);
            stream.Write(message, 0, message.Length);
            Console.WriteLine($"보낸메시지 {greet}");


            //받기
            byte[] data = new byte[256];
            int bytes = stream.Read(data, 0, data.Length);
            string responseData = Encoding.UTF8.GetString(data, 0, bytes);
            Console.WriteLine($"Received: {responseData}");

            client.Close();
        }
    }
}
