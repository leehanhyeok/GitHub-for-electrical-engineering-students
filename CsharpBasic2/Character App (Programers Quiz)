namespace todolist
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.InteropServices;

   
    internal class Program
    {
        static string[] solution(string[] todo_list, bool[] finished)
        {
            List<string> newWorkList = new List<string>();

            for (int i = 0; i < todo_list.Length; i++)
            {
                if(! finished[i])
                    newWorkList.Add(todo_list[i]);
            }

            return newWorkList.ToArray(); //list를 배열로 변경하는 메소드 
        }
        static void Main(string[] args)
        {

            string[] todo_list = { "problemsolving", "practiceguitar", "swim", "studygraph" };
            bool[] finished = { true, false, true, false };
            
            string[] list = solution(todo_list, finished);

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
