namespace five
{
    internal class Program
    {
        static string[] solution(string[] names)
        {
            List<string> newWorkList = new List<string>();

            for (int i = 0; i < names.Length; i+=5)
            {
                    newWorkList.Add(names[i]);
            }

            return newWorkList.ToArray(); ;
        }
        static void Main(string[] args)
        {
            string[] names = { "nami", "ahri", "jayce", "garen", "ivern", "vex", "jinx" };

            string[] result = solution(names);

            foreach (string r in result)
            {
                Console.WriteLine(r);
            }
        }
    }
}
