using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SimpleTCPServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TCPListener 클래스 이용해서 작업 -- 서버 만들기 
            // 1 .Server 만들고 Binding 
                // 1-1 ip 만들기, Port 만들기 
            IPAddress localAddr = IPAddress.Parse("192.168.0.16"); //문자열로 던지면 ipadress주소로 변환해줌 //내 주소 입력 
            int port = 13000;

            TcpListener server = new TcpListener(localAddr, port);
            server.Start(); //서버 시작 
            Console.WriteLine("연결을 기다리는 중 . . . .");

            // 2. Listener, Accept
            using (TcpClient client = server.AcceptTcpClient())
            {
                Console.WriteLine("연결성공"); // 내부적 무한루프, 클라없으면 동작안함 

                // 3. Write  (전달하고 받을지, 받고 전달할지 사용자가 정함) 
                // 서버 => 클라이언트로 메시지 전달
                using (NetworkStream stream = client.GetStream())
                {
                    string messsage = "안녕하세요";
                    byte[] data = Encoding.UTF8.GetBytes(messsage); //UTF8로 바이너리 파일로 엔코딩

                    stream.Write(data, 0, data.Length); //messsage는 바이트로 받음 //네트워크로 클라이언트로 메시지 전송 
                    Console.WriteLine($"전달한 메시지 : {messsage}");
                }
            }
            // 4. 종료
            server.Stop();
        }
    }
}
