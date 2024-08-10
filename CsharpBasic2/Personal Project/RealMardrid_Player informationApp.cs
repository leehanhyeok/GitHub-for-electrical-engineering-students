using System;



namespace ScoccerTeam

{

    class Team

    {

        public int No { get; set; }

        public string Position { get; set; }

        public string Name { get; set; }



        public Team(string name, string position, int no)   

        {

            No = no;

            Position = position;

            Name = name;

        }

    }



    internal class Program

    {

        static void Main(string[] args)

        {

            List<Team> list = new List<Team>();

            int choice = 0;

            do

            {

                Console.WriteLine("=========================");

                Console.WriteLine("1. Real Madrid 선수 삽입");

                Console.WriteLine("2. Real Madrid 선수 삭제");

                Console.WriteLine("3. Real Madrid 선수 조회");

                Console.WriteLine("4. Real Madrid 선수 수정");

                Console.WriteLine("5. 프로그램 종료");

                Console.WriteLine();

                Console.Write("메뉴 : ");

                choice = int.Parse(Console.ReadLine());

                Console.WriteLine("=========================");

                if (choice == 1)

                {

                    Console.Write("선수의 이름을 입력해주세요 :  ");

                    string name = Console.ReadLine();

                    Console.Write("선수의 포지션을 입력해주세요 : ");

                    string position = Console.ReadLine();

                    Console.Write("선수의 등번호를 입력해주세요 : ");

                    int no = int.Parse(Console.ReadLine());

                    Team laliga = new Team(name, position, no);

                    list.Add(laliga);

                }

                else if(choice == 2)

                {

                    Console.Write("삭제할 선수의 인덱스를 입력하시오 : ");

                    int num = Int32.Parse(Console.ReadLine());

                    list.RemoveAt(num - 1);

                }



                else if(choice == 3)

                {

                    int index = 1;

                    foreach(Team i in list)

                    {



                        Console.WriteLine($"({index})");

                        Console.WriteLine("이름 : " + i.Name);

                        Console.WriteLine("포지션 : " + i.Position);

                        Console.WriteLine("등번호 : " + i.No);

                        Console.WriteLine();

                        index++;



                    }

                }



                else if (choice == 4)

                {

                    Console.Write("수정할 선수의 인덱스를 입력하시오 : ");

                    int num = Int32.Parse(Console.ReadLine());

                    list.RemoveAt(num - 1);

                    Console.Write("선수의 이름을 입력해주세요 :  ");

                    string name = Console.ReadLine();

                    Console.Write("선수의 포지션을 입력해주세요 : ");

                    string position = Console.ReadLine();

                    Console.Write("선수의 등번호를 입력해주세요 : ");

                    int no = int.Parse(Console.ReadLine());

                    Team laliga = new Team(name, position, no);

                    list.Add(laliga);

                    



                }

                else if (choice == 5)

                {

                    Console.WriteLine("프로그램 종료");

                }



            } while (choice != 5);



        }

    }

}
