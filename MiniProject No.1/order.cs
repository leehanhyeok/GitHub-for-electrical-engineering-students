using Oracle.ManagedDataAccess.Client; // Oracle 데이터베이스 접근을 위한 Oracle 클라이언트 가져오기
using System.Data; // 데이터 처리를 위한 System.Data 네임스페이스 가져오기

namespace InputCheckApp
{
    public partial class Form1 : Form
    {
        // Oracle 데이터베이스에 연결하기 위한 연결 문자열
        private string connectionString = "User Id=scott;Password=tiger;" +
                                          "Data Source=(DESCRIPTION=" +
                                          "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                                          "(HOST=192.168.0.2)(PORT=1521)))" +
                                          "(CONNECT_DATA=(SERVER=DEDICATED)" +
                                          "(SERVICE_NAME=xe)));";

        public Form1()
        {
            InitializeComponent(); // 폼 구성 요소 초기화
        }

        // "Show Order" 버튼이 클릭되었을 때 이벤트를 처리하는 메소드
        private void buttonShowOrder_Click(object sender, EventArgs e)
        {
            // Oracle 데이터베이스에 연결을 설정
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open(); // 데이터베이스 연결 열기

                // ORDERCAR 테이블에서 모든 레코드를 주문날짜(주문 날짜)로 정렬하여 선택하는 SQL 쿼리
                string query = "SELECT * FROM ORDERCAR ORDER BY 주문날짜";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection); // 쿼리를 실행하기 위한 어댑터 생성

                DataTable dataTable = new DataTable(); // 쿼리 결과를 담을 DataTable 생성
                adapter.Fill(dataTable); // DataTable에 쿼리에서 가져온 데이터 채우기

                dataGridView1.DataSource = dataTable; // 데이터를 dataGridView1에 바인딩하여 화면에 표시
            }
        }

        // "Show Inventory" 버튼이 클릭되었을 때 이벤트를 처리하는 메소드
        private void buttonShowinventory_Click(object sender, EventArgs e)
        {
            // Oracle 데이터베이스에 연결을 설정
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open(); // 데이터베이스 연결 열기

                // PART 테이블에서 모든 레코드를 선택하는 SQL 쿼리
                string query = "SELECT * FROM PART";
                OracleDataAdapter adapter = new OracleDataAdapter(query, connection); // 쿼리를 실행하기 위한 어댑터 생성

                DataTable dataTable = new DataTable(); // 쿼리 결과를 담을 DataTable 생성
                adapter.Fill(dataTable); // DataTable에 쿼리에서 가져온 데이터 채우기

                dataGridView2.DataSource = dataTable; // 데이터를 dataGridView2에 바인딩하여 화면에 표시
            }
        }

        // "Close" 버튼이 클릭되었을 때 이벤트를 처리하는 메소드
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 폼 닫기
        }
    }
}
