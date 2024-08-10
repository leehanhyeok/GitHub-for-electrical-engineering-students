namespace MycopyApp
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //arg[0] a.txt

            //arg[1] b.txt
            string orgnfile = args[0];
            string copyfile = args[1];

            try
            {
                using (StreamReader sr = new StreamReader(orgnfile))
                using (StreamWriter sw = new StreamWriter(copyfile))
                {
                    var line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("복사성공");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }

}
