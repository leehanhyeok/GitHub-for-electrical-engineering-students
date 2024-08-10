using System.Data;

namespace Property02
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return Name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("이름이 입력되지 않았습니다"); //
                }
                else
                {
                    name = value;
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; } = "아무개";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "홍길동";
            Console.WriteLine(person.Name);
        }
    }
}
