using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderWriter_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Temp\\pic1.png";
            byte[] picture;
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryReader br = new BinaryReader(fs);
                picture = br.ReadBytes((int)fs.Length); //직렬화 되어 있는 값으로 읽어 옮
                br.Close();
            }//사진 파일 읽어오기 => 메모리로 가져옴 (byte[] picture)

            //pic2.png로 Write 해봅시다.
            string path2 = "C:\\Temp\\pic2.png";
            using (FileStream fs = new FileStream(path2, FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(picture);
                bw.Flush(); //이진파일 Flush() 신경
                bw.Close();
            }
        }
    }
}
