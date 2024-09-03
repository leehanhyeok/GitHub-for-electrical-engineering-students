using System.Net;
using System.Net.Sockets;

namespace PicyureSaveServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 서버소켓 만들기, binding, listening
            TcpListener server = new TcpListener(IPAddress.Any , 13000);
            server.Start();
            Console.WriteLine("서버가 시작되었습니다. 클라이언트를 기다리는중");

            //2. Accept
            TcpClient client = server.AcceptTcpClient(); //accept 될때까지 대기 / block io
            Console.WriteLine("클라이언트가 연결되었습니다.");

            //3. Read Write
                //소켓에서 패킷을 가져오기
                //그림파일을 파일에 저장 
            NetworkStream networkStream = client.GetStream();

            //그림파일 수신 및 저장 
            using (FileStream fileStream = new FileStream("recived_img.png", FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[4096];
                int bytesRead; //버퍼로부터 읽어온 byte수 출력 
                while ((bytesRead = networkStream.Read(buffer, 0, buffer.Length)) > 0) //파일이 끝날때까지 읽어옴 
                {
                    fileStream.Write(buffer, 0, bytesRead);
                }
            }
            Console.WriteLine("파일 수신 완료");

            //4. close 
            networkStream.Close();
            client.Close();
            server.Stop();
        }
    }
}
