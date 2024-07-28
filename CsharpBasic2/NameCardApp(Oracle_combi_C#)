using Oracle.ManagedDataAccess.Client;
using System;
using System.Threading.Channels;
using System.Xml.Linq;

namespace MiniConsoleProgram
{
    class Namecard
    {
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Adress { get; set; }


        public Namecard(string name, string tel, string email, string company, string adress) //인자가 있는 생성자로 
        {
            Name = name;
            Tel = tel;
            Email = email;
            Company = company;
            Adress = adress;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=9000)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=scott;Password=tiger;";

            //1.연결 객체 만들기 - Client
            OracleConnection conn = new OracleConnection(strConn);

            //2.데이터베이스 접속을 위한 연결
            conn.Open();

            //3.1 Query 명령객체 만들기
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn; //연결객체와 연동

            List<Namecard> person = new List<Namecard>();
            int choice = 0;
            int cardid = 1;
            do
            {
                Console.WriteLine("=========================");
                Console.WriteLine("명함관리 시스템");
                Console.WriteLine("=========================");
                Console.WriteLine("0. 테이블 생성 초기화");
                Console.WriteLine("1. 명함 추가");
                Console.WriteLine("2. 명함 목록 보기");
                Console.WriteLine("3. 명함 수정");
                Console.WriteLine("4. 명함 삭제");
                Console.WriteLine("5. 명함 검색");
                Console.WriteLine("6. 종료");
                Console.WriteLine("=========================");
                Console.Write("선택 : ");

                choice = int.Parse(Console.ReadLine());

                Console.WriteLine("=========================");

                if(choice == 0)
                {
                    Console.WriteLine("테이블을 초기화 합니다.");
                    cmd.CommandText = "DROP TABLE BusinessCards";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE BusinessCards (CardID NUMBER PRIMARY KEY, Name VARCHAR2(50) NOT NULL, PhoneNumber VARCHAR2(20) NOT NULL, Email VARCHAR2(50), Company VARCHAR2(100), Address VARCHAR2(200))";
                    cmd.ExecuteNonQuery();
                }

                else if (choice == 1)
                {
                    Console.Write("이름 : ");
                    string name = Console.ReadLine();
                    Console.Write("전화번호 : ");
                    string tel = Console.ReadLine();
                    Console.Write("이메일 : ");
                    string email = Console.ReadLine();
                    Console.Write("회사 : ");
                    string company = Console.ReadLine();
                    Console.Write("주소 : ");
                    string adress = Console.ReadLine();
                    
                    cmd.CommandText = "INSERT INTO BusinessCards (CardID, Name, PhoneNumber, Email, Company, Address)" +
                                      $"VALUES ({cardid++},'{name}','{tel}','{email}','{company}','{adress}')";
                    
                    cmd.ExecuteNonQuery();
                }

                else if(choice == 2)
                {
                    cmd.CommandText = "SELECT * FROM BusinessCards";

                    OracleDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        //int id = rdr.GetInt32(0); //int나 number로 받을때 
                        //int id = int.Parse(rdr.GetString(0));  // 0이 뜻하는 것은 컬럼의 순서 0부터 첫번째 컬럼
                        //int id = int.Parse(rdr["ID"] as string); //Error
                        int id = int.Parse(rdr["CardID"].ToString());
                        string name = rdr["Name"] as string;
                        string tel = rdr["PhoneNumber"] as string;
                        string email = rdr["Email"] as string;
                        string company = rdr["Company"] as string;
                        string adress = rdr["Address"] as string;

                        Console.WriteLine($"{id}. {name} | {tel} | {email} | {company} | {adress}");
                    }
                }

                else if(choice == 3)
                {
                    Console.Write("수정할 명함의 번호를 입력하시오 : ");
                    int select = Int32.Parse(Console.ReadLine());
                    cmd.CommandText = $"SELECT * FROM BusinessCards WHERE CARDID = {select}";

                    OracleDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        //int id = rdr.GetInt32(0); //int나 number로 받을때 
                        //int id = int.Parse(rdr.GetString(0));  // 0이 뜻하는 것은 컬럼의 순서 0부터 첫번째 컬럼
                        //int id = int.Parse(rdr["ID"] as string); //Error
                        int id = int.Parse(rdr["CardID"].ToString());
                        string name = rdr["Name"] as string;
                        string tel = rdr["PhoneNumber"] as string;
                        string email = rdr["Email"] as string;
                        string company = rdr["Company"] as string;
                        string adress = rdr["Address"] as string;

                        Console.WriteLine($"{id}. {name} | {tel} | {email} | {company} | {adress}");
                    }
                    
                    Console.Write("수정할 항목 (1:이름, 2:전화번호, 3:이메일, 4:회사, 5:주소): ");
                    int select_update = Int32.Parse(Console.ReadLine());
                        
                    if (select_update == 1)
                    {
                        Console.Write("수정할 이름 입력 : ");
                        string name_update = Console.ReadLine();
                        // Console.WriteLine($"변수 테스트 {name_update}, Select:{select}");
                        cmd.CommandText = $"UPDATE BUSINESSCARDS SET NAME = '{name_update}' WHERE CARDID = {select}";
                        cmd.ExecuteNonQuery();       
                    }

                    else if (select_update == 2)
                    {
                        Console.Write("수정할 전화번호 입력 : ");
                        string phonenumber_update = Console.ReadLine();
                        
                        cmd.CommandText = $"UPDATE BUSINESSCARDS SET PHONENUMBER = '{phonenumber_update}' WHERE CARDID = {select}";
                        cmd.ExecuteNonQuery();
                    }

                    else if (select_update == 3)
                    {
                        Console.Write("수정할 이메일 입력 : ");
                        string email_update = Console.ReadLine();

                        cmd.CommandText = $"UPDATE BUSINESSCARDS SET EMAIL = '{email_update}' WHERE CARDID = {select}";
                        cmd.ExecuteNonQuery();
                    }

                    else if (select_update == 4)
                    {
                        Console.Write("수정할 회사이름 입력 : ");
                        string company_update = Console.ReadLine();

                        cmd.CommandText = $"UPDATE BUSINESSCARDS SET COMPANY = '{company_update}' WHERE CARDID = {select}";
                        cmd.ExecuteNonQuery();
                    }

                    else if (select_update == 5)
                    {
                        Console.Write("수정할 주소 입력 : ");
                        string address_update = Console.ReadLine();

                        cmd.CommandText = $"UPDATE BUSINESSCARDS SET ADDRESS = '{address_update}' WHERE CARDID = {select}";
                        cmd.ExecuteNonQuery();
                    }

                    else
                    {
                        Console.WriteLine("다시입력해주세요");
                    }  
                }

                else if(choice == 4)
                {
                    Console.Write("삭제할 명함의 번호를 입력하시오 : ");
                    int select = int.Parse(Console.ReadLine());

                    cmd.CommandText = $"DELETE FROM BUSINESSCARDS WHERE CARDID = '{select}'";

                    cmd.ExecuteNonQuery();
                }

                else if(choice == 5)
                {
                    Console.WriteLine("[명함 검색 기능]");
                    Console.WriteLine("============================");
                    Console.WriteLine("명함 검색");
                    Console.WriteLine("============================");
                    Console.Write("검색할 이름 입력하세요 : ");

                    string search = Console.ReadLine();

                    Console.WriteLine("============================");
                    Console.WriteLine("검색 결과");
                    cmd.CommandText = $"SELECT * FROM BusinessCards WHERE NAME LIKE '%{search}%'";

                    cmd.ExecuteNonQuery();

                    OracleDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        //int id = rdr.GetInt32(0); //int나 number로 받을때 
                        //int id = int.Parse(rdr.GetString(0));  // 0이 뜻하는 것은 컬럼의 순서 0부터 첫번째 컬럼
                        //int id = int.Parse(rdr["ID"] as string); //Error
                        int id = int.Parse(rdr["CardID"].ToString());
                        string name = rdr["Name"] as string;
                        string tel = rdr["PhoneNumber"] as string;
                        string email = rdr["Email"] as string;
                        string company = rdr["Company"] as string;
                        string adress = rdr["Address"] as string;

                        Console.WriteLine($"{id}. {name} | {tel} | {email} | {company} | {adress}");
                    }
                }
                else if(choice == 6)
                {
                    Console.WriteLine("시스템 종료");
                    break;
                }
                else
                {
                    Console.WriteLine("다시입력해주세요");
                }

            } while (choice != 6);
            conn.Close();
        }
    }
}
