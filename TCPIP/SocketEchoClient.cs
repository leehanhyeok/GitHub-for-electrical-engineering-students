
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace EchoClientAdv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1.소켓만들기
                Socket socket = new Socket(AddressFamily.InterNetwork,
                                        SocketType.Stream,
                                        ProtocolType.Tcp);

                //2.연결
                EndPoint serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 13000);
                socket.Connect(serverEP);

                //3.wirte & read
                    //wirte
                Console.Write("메시지 작성 : ");
                string msg = Console.ReadLine();
                byte[] buffer = Encoding.UTF8.GetBytes(msg);
                socket.Send(buffer);

                    //read
                byte[] recvBytes = new byte[1024];
                int nRecv = socket.Receive(recvBytes);
                string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
                Console.Write($"Echo : {txt}");

                //5.종료
                socket.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
