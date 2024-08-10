namespace FIlePractice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteAllText
            string path = @"C:\Temp\five.txt";
            string content = "";

            for (int i = 1; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    content += i.ToString() + " ";
                }
            }

            File.WriteAllText(path, content);

            ////Read
            //string readContent = File.ReadAllText(path);
            //Console.WriteLine(readContent);


            FileInfo fi = new FileInfo(path);

            //FileInfo 로 쓰기
            using (StreamWriter sw = fi.CreateText())
            {
                sw.WriteLine(content);
            }

            //읽기
            using (StreamReader sr = fi.OpenText())
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
