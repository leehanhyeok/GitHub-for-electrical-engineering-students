using Oracle.ManagedDataAccess.Client;
using System;
using System.Threading.Channels;
using System.Xml.Linq;

namespace FactoryApp
{
    class Manufacturing
    {
        public string Name { get; set; }
        public string Fruit { get; set; }
        public int Sugar { get; set; }
        public int Citricacid { get; set; }
        public int Carbonated { get; set; }

        
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

            List<Manufacturing> beverage = new List<Manufacturing>();
            int choice = 0;
            int beverage_index = 1;

            string name;
            string fruit;
            int sugar;
            int citricacid;
            int carbonated;

            string beveragename;
            string location;

            do
            {
                Console.WriteLine("=========================");
                Console.WriteLine("음료제조 시스템");
                Console.WriteLine("=========================");
                Console.WriteLine("0. 테이블 생성 초기화");
                Console.WriteLine("1. 음료 배합 하기");
                Console.WriteLine("2. 음료 배합 목록 보기");
                Console.WriteLine("3. 음료 배합 수정");
                Console.WriteLine("4. 음료 폐기");
                Console.WriteLine("5. 음료 검색");

                Console.WriteLine("6. 납품 정보 추가");
                Console.WriteLine("7. 납품 정보 확인");
                Console.WriteLine("8. 음료 제조 종료");
                Console.WriteLine("=========================");
                Console.Write("선택 : ");

                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("=========================");

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("테이블을 초기화 합니다.");
                        cmd.CommandText = "DROP TABLE Beverage_Manufacturing";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "DROP TABLE Delivery";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Beverage_Manufacturing(ID NUMBER PRIMARY KEY, BeverageName VARCHAR2(50) NOT NULL, FruitName VARCHAR2(50) NOT NULL, SugarMixingAmount NUMBER(37) NOT NULL, CitricacidMixingAmount NUMBER(37) NOT NULL, CarbonatedMixingAmount NUMBER(37) NOT NULL)";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE TABLE Delivery(BeverageName VARCHAR2(50) NOT NULL, LOC VARCHAR2(50) NOT NULL)";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "DROP SEQUENCE SEQ_PRODUCT";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "CREATE SEQUENCE SEQ_PRODUCT INCREMENT BY 1 START WITH 1 NOCYCLE";
                        cmd.ExecuteNonQuery();
                        break;

                    case 1:
                        Console.Write("음료 이름 : ");
                        name = Console.ReadLine();
                        Console.Write("합성 착향료(과일향 종) : ");
                        fruit = Console.ReadLine();
                        Console.Write("설탕 량(g) : ");
                        sugar = Int32.Parse(Console.ReadLine());
                        Console.Write("시트르산 량(g): ");
                        citricacid = Int32.Parse(Console.ReadLine());
                        Console.Write("탄산 량(g) : ");
                        carbonated = Int32.Parse(Console.ReadLine());

                        cmd.CommandText = "INSERT INTO Beverage_Manufacturing(ID, BeverageName, FruitName, SugarMixingAmount, CitricacidMixingAmount, CarbonatedMixingAmount)" +
                                          $"VALUES (SEQ_PRODUCT.NEXTVAL,'{name}','{fruit}','{sugar}','{citricacid}','{carbonated}')";

                        cmd.ExecuteNonQuery();
                        break;

                    case 2:
                        cmd.CommandText = "SELECT * FROM Beverage_Manufacturing";

                        OracleDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            //int id = rdr.GetInt32(0); //int나 number로 받을때 
                            //int id = int.Parse(rdr.GetString(0));  // 0이 뜻하는 것은 컬럼의 순서 0부터 첫번째 컬럼
                            //int id = int.Parse(rdr["ID"] as string); //Error
                            int id = int.Parse(rdr["ID"].ToString());
                            name = rdr["BeverageName"] as string;
                            fruit = rdr["FruitName"] as string;
                            sugar = int.Parse(rdr["SugarMixingAmount"].ToString());
                            citricacid = int.Parse(rdr["CitricacidMixingAmount"].ToString());
                            carbonated = int.Parse(rdr["CarbonatedMixingAmount"].ToString());

                            Console.WriteLine($"{id}. {name} | {fruit} | {sugar} | {citricacid} | {carbonated}");
                        }
                        break;

                    case 3:
                        Console.Write("수정할 음료의 ID 번호를 입력하시오 : ");
                        int select = Int32.Parse(Console.ReadLine());
                        cmd.CommandText = $"SELECT * FROM Beverage_Manufacturing WHERE ID = {select}";

                        rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            //int id = rdr.GetInt32(0); //int나 number로 받을때 
                            //int id = int.Parse(rdr.GetString(0));  // 0이 뜻하는 것은 컬럼의 순서 0부터 첫번째 컬럼
                            //int id = int.Parse(rdr["ID"] as string); //Error
                            int id = int.Parse(rdr["ID"].ToString());
                            name = rdr["BeverageName"] as string;
                            fruit = rdr["FruitName"] as string;
                            sugar = int.Parse(rdr["SugarMixingAmount"].ToString());
                            citricacid = int.Parse(rdr["CitricacidMixingAmount"].ToString());
                            carbonated = int.Parse(rdr["CarbonatedMixingAmount"].ToString());

                            Console.WriteLine($"{id}. {name} | {fruit} | {sugar} | {citricacid} | {carbonated}");
                        }

                        Console.Write("수정할 항목 (1:음료 이름, 2:합성 착향료 (과일향), 3:설탕 량(g), 4:시트르산 량(g), 5:탄산 량(g)): ");
                        int select_update = Int32.Parse(Console.ReadLine());

                        switch (select_update)
                        {
                            case 1:
                                Console.Write("수정할 음료 이름 입력 : ");
                                string name_update = Console.ReadLine();
                                cmd.CommandText = $"UPDATE Beverage_Manufacturing SET BeverageName = '{name_update}' WHERE ID = {select}";
                                cmd.ExecuteNonQuery();
                                break;

                            case 2:
                                Console.Write("수정할 합성 착향료 (과일향 종) 입력 : ");
                                string fruit_update = Console.ReadLine();

                                cmd.CommandText = $"UPDATE Beverage_Manufacturing SET FruitName = '{fruit_update}' WHERE ID = {select}";
                                cmd.ExecuteNonQuery();
                                break;

                            case 3:
                                Console.Write("수정할 설탕 량(g) 입력 : ");
                                int sugar_update = Int32.Parse(Console.ReadLine());

                                cmd.CommandText = $"UPDATE Beverage_Manufacturing SET SugarMixingAmount = '{sugar_update}' WHERE ID = {select}";
                                cmd.ExecuteNonQuery();
                                break;

                            case 4:
                                Console.Write("수정할 시트르산 량(g) 입력 : ");
                                int citricacid_update = Int32.Parse(Console.ReadLine());

                                cmd.CommandText = $"UPDATE Beverage_Manufacturing SET CitricacidMixingAmount = '{citricacid_update}' WHERE ID = {select}";
                                cmd.ExecuteNonQuery();
                                break;

                            case 5:
                                Console.Write("수정할 탄산 량(g) 입력 : ");
                                int carbonated_update = Int32.Parse(Console.ReadLine());

                                cmd.CommandText = $"UPDATE Beverage_Manufacturing SET CarbonatedMixingAmount = '{carbonated_update}' WHERE ID = {select}";
                                cmd.ExecuteNonQuery();
                                break;

                            default:
                                Console.WriteLine("다시입력해주세요");
                                break;
                        }
                        break;

                    case 4:
                        Console.Write("삭제할 음료의 ID를 입력하시오 : ");
                        int select_del = int.Parse(Console.ReadLine());

                        cmd.CommandText = $"DELETE FROM Beverage_Manufacturing WHERE ID = '{select_del}'";

                        cmd.ExecuteNonQuery();
                        break;

                    case 5:
                        Console.WriteLine("[음료 검색 기능]");
                        Console.WriteLine("============================");
                        Console.WriteLine("음료 검색");
                        Console.WriteLine("============================");
                        Console.Write("검색할 음료 이름을 입력하세요 : ");

                        string search = Console.ReadLine();

                        Console.WriteLine("============================");
                        Console.WriteLine("검색 결과");
                        cmd.CommandText = $"SELECT * FROM Beverage_Manufacturing WHERE BeverageName LIKE '%{search}%'";

                        cmd.ExecuteNonQuery();

                        rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            //int id = rdr.GetInt32(0); //int나 number로 받을때 
                            //int id = int.Parse(rdr.GetString(0));  // 0이 뜻하는 것은 컬럼의 순서 0부터 첫번째 컬럼
                            //int id = int.Parse(rdr["ID"] as string); //Error
                            int id = int.Parse(rdr["ID"].ToString());
                            name = rdr["BeverageName"] as string;
                            fruit = rdr["FruitName"] as string;
                            sugar = int.Parse(rdr["SugarMixingAmount"].ToString());
                            citricacid = int.Parse(rdr["CitricacidMixingAmount"].ToString());
                            carbonated = int.Parse(rdr["CarbonatedMixingAmount"].ToString());

                            Console.WriteLine($"{id}. {name} | {fruit} | {sugar} | {citricacid} | {carbonated}");
                        }
                        break;

                    case 6:
                        Console.Write("음료 이름 : ");
                        beveragename = Console.ReadLine();
                        Console.Write("납품 지역명: ");
                        location = Console.ReadLine();


                        cmd.CommandText = "INSERT INTO Delivery(BeverageName, LOC)" +
                                          $"VALUES ('{beveragename}','{location}')";

                        cmd.ExecuteNonQuery();
                        break;

                    case 7:

                        cmd.CommandText = "SELECT BeverageName, LOC\r\nFROM Beverage_Manufacturing NATURAL JOIN Delivery\r\nORDER BY BeverageName, LOC";

                        rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            beveragename = rdr["BeverageName"] as string;
                            location = rdr["LOC"] as string;

                            Console.WriteLine($"{beveragename} | {location}");
                        }
                        break;

                    case 8:
                        Console.WriteLine("음료 제조를 종료 합니다.");
                        break;

                    default:
                        Console.WriteLine("다시입력해주세요");
                        break;
                }

            } while (choice != 8);
        }
    }
}
