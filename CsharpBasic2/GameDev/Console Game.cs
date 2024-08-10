namespace MenuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("용사님의 이름을 입력해 주세요 : ");
            string name = Console.ReadLine();
            Console.WriteLine($"안녕하세요, 용감한 탐험가 {name} !");
            Console.WriteLine();

            int menu = 0;

            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("메뉴선택");
                Console.WriteLine("1. 낡은 마을 탐험");
                Console.WriteLine("2. 숲속 오두막 방문");
                Console.WriteLine("3. 게임 종료");
                Console.Write("선택 : ");
                
                menu = Int32.Parse(Console.ReadLine());
                Console.WriteLine("====================");

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("낡은 마을에 도착했습니다.");
                        Thread.Sleep(500); //강제 지연
                        Console.WriteLine("마을 주민들과 대화하고, 마을의 비밀을 파헤칠 수 있는 단서를 얻습니다.");
                        Thread.Sleep(500);
                        Console.WriteLine("마을의 문제를 해결하기 위해 퀘스트를 수행해야 할 수도 있습니다.");
                        Thread.Sleep(500);
                        Console.WriteLine("퀘스트를 완료하면 보상을 받을 수 있습니다.");
                        Thread.Sleep(500);
                        Console.WriteLine("한 어린 여자아이가 울고 있습니다.");
                        Thread.Sleep(500);
                        Console.WriteLine("(훌쩍) (훌쩍) 아저씨 저 새가 내 인형을 가져 갔어요");
                        Thread.Sleep(500);
                        Console.WriteLine("어떻게 답하시겠습니까? : ");
                        Console.WriteLine("====================");
                        Console.WriteLine("1. 귀찮게 하지마");
                        Console.WriteLine("2. 꼬마야 내가 찾아줄게");
                        int num = Int32.Parse(Console.ReadLine());
                        if(num == 1)
                        {
                            Console.WriteLine("====================");
                            Console.WriteLine("아저씨 미워! (퍽)(퍽)");
                            Thread.Sleep(500);
                            Console.WriteLine("999의 데미지를 받아 플레이어가 사망했습니다.");
                            break;
                        }
                        else if (num == 2)
                        {
                            Console.WriteLine("====================");
                            Console.WriteLine("(화색)고마워요 아저씨!");
                            Thread.Sleep(500);
                            Console.WriteLine("(나무 위를 가르키며)저 새대가리가 내 인형을 가져갔어!");
                            Thread.Sleep(1000);
                            Console.WriteLine("플레이어가 나무를 오릅니다");
                            Thread.Sleep(1000);
                            Console.WriteLine("새와의 전투에서 이겼습니다!");
                            Thread.Sleep(1000);
                            Console.WriteLine("인형을 돌려줍니다.");
                            Thread.Sleep(1000);
                            Console.WriteLine("(꽉 껴안으며) 아저씨 사랑해요!");
                            Thread.Sleep(1000);
                            Console.WriteLine("(경험치를 얻습니다. (300xp)");
                            break ;
                        }

                            break;
                    case 2:
                        
                        Console.WriteLine("숲속 오두막에 도착했습니다.");
                        Thread.Sleep(500); //강제 지연
                        Console.WriteLine("한 마법사가 다가옵니다 (저벅) (저벅)");
                        Thread.Sleep(500);
                        Console.WriteLine("자네 여기엔 왜 왔는가?");
                        Thread.Sleep(500);
                        Console.WriteLine("내 시험을 풀어야만 나갈 수 있을 것이야");
                        Thread.Sleep(500);
                        Console.WriteLine("5 곱하기 5는!");
                        int num2 = Int32.Parse(Console.ReadLine());
                        if (num2 == 25)
                        {
                            Console.WriteLine("====================");
                            Console.WriteLine("25 !");
                            Thread.Sleep(1000);
                            Console.WriteLine("정답이군.. 문을 열어주도록 하지 (끼익)");
                            Thread.Sleep(1000);
                            Console.WriteLine("나가는 문이 열렸습니다.");
                            Console.WriteLine("(경험치를 얻습니다. (500xp)");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("====================");
                            Console.WriteLine("이런 멍청한 놈을 봤나! 에잇");
                            Thread.Sleep(1000);
                            Console.WriteLine("저주에 받아 '쥐' 가 되었습니다.");
                            Thread.Sleep(1000);
                            Console.WriteLine("(찍) (찍)");
                            break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("게임 종료");
                        break;
                }

            } while(menu != 3);

        }
    }
}
