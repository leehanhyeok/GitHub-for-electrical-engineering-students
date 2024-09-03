using System.Net.Sockets;
using System.Net;
using System.Text;

namespace MutipleEchoServer
{
    internal class Program
    {
        // 클라이언트의 수를 카운트하는 변수
        static int cnt = 0;

        static void Main(string[] args)
        {
            // 서버 기능을 실행하는 스레드를 생성하고 백그라운드로 실행
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();

            // 서버 스레드가 종료될 때까지 대기
            serverThread.Join();
            Console.WriteLine("서버프로그램을 종료합니다.");
        }

        static void serverFunc(object obj)
        {
            // 소켓 생성: IPv4 주소 체계, 스트림 소켓, TCP 프로토콜 사용
            Socket socket = new Socket(AddressFamily.InterNetwork,
                                       SocketType.Stream,
                                       ProtocolType.Tcp);

            // 모든 네트워크 인터페이스에서 포트 13000을 사용하는 엔드포인트 바인딩
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 13000);
            socket.Bind(endPoint);
            socket.Listen(50); // 최대 50개의 대기 연결 요청

            Console.WriteLine("퀴즈 서버 시작 . . .");

            // 클라이언트의 연결을 대기하는 루프
            while (true)
            {
                // 클라이언트 연결 수락
                Socket clientSocket = socket.Accept();
                cnt++; // 클라이언트 수 증가
                // 클라이언트와의 작업을 처리하는 스레드를 생성하고 백그라운드로 실행
                Thread workThread = new Thread(new ParameterizedThreadStart(workFunc));
                workThread.IsBackground = true;
                workThread.Start(clientSocket);
            }
        }

        private static void workFunc(object obj)
        {
            // 데이터를 받을 버퍼 생성
            byte[] recvBytes = new byte[1024];
            Socket clientSocket = (Socket)obj; // 전달된 소켓 객체로 캐스팅
            // 클라이언트로부터 데이터 수신
            int nRecv = clientSocket.Receive(recvBytes);

            // 받은 데이터를 UTF-8 문자열로 변환
            string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
            Console.WriteLine($"클라이언트 번호 {cnt} : {txt}");

            // 클라이언트에게 "Hello : "와 받은 메시지를 다시 전송 (에코)
            byte[] sendBytes = Encoding.UTF8.GetBytes("Hello : " + txt);
            clientSocket.Send(sendBytes);

            // 클라이언트 소켓 연결 종료
            clientSocket.Close();
        }
    }
}
