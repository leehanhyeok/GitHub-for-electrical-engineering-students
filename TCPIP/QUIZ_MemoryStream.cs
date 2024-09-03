using System.Text;

namespace UTF8Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 텍스트 파일의 경로를 지정
            string path = @"C:\Temp\abc.txt";

            // UTF-8 인코딩으로 파일 내용을 읽기 위해 StreamReader 생성
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            
            // 파일의 전체 내용을 문자열로 읽어옴
            string txt = sr.ReadToEnd();
            
            // 파일에서 읽어온 내용을 콘솔에 출력
            Console.WriteLine(txt);

            // 메모리 내에서 바이트 데이터를 저장할 MemoryStream 생성
            MemoryStream ms = new MemoryStream();
            
            // 문자열(txt)을 UTF-8 인코딩을 사용해 바이트 배열로 변환
            byte[] strBytes = Encoding.UTF8.GetBytes(txt);
            
            // 변환된 바이트 배열을 MemoryStream에 기록
            ms.Write(strBytes, 0, strBytes.Length);

            // MemoryStream의 위치를 처음으로 리셋 (스트림의 처음부터 읽기 위해)
            ms.Position = 0;

            // MemoryStream을 파일처럼 사용하여 읽기 위해 StreamReader를 생성 (UTF-8 인코딩 적용)
            StreamReader sr2 = new StreamReader(ms, Encoding.UTF8, true);
            
            // MemoryStream에서 모든 데이터를 읽어 다시 문자열로 변환
            txt = sr2.ReadToEnd();
            
            // MemoryStream에서 읽어온 내용을 콘솔에 출력
            Console.WriteLine(txt);
        }
    }
}
