using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TeslarDataChartApp
{
    public partial class Form1 : Form
    {
        // 데이터베이스 연결 문자열 설정
        private string connectionString = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=192.168.0.2)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=scott;Password=tiger;";

        private int flag = 0;

        // 폼 초기화
        public Form1()
        {
            InitializeComponent();
        }

        // "차트 보기" 버튼 클릭 시 이벤트 핸들러
        private void ButtonShowChart_Click(object sender, EventArgs e)
        {
            // 차트 초기화
            chart1.Series[0].Points.Clear();

            // 오라클 데이터베이스 연결
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // 모든 차종 모델과 누적 판매량 가져오기
            cmd.CommandText = "SELECT 차종모델, 누적판매량 FROM CARTOTAL";

            OracleDataReader rdr = cmd.ExecuteReader();

            // 데이터베이스에서 가져온 각 행에 대해 차트에 데이터 추가
            while (rdr.Read())
            {
                string model = rdr["차종모델"].ToString();
                int sales = int.Parse(rdr["누적판매량"].ToString());

                // 차종 모델명(X 값)과 누적 판매량(Y 값)을 차트에 추가
                chart1.Series[0].Points.AddXY(model, sales);
            }

            // Y축 간격 설정
            chart1.ChartAreas[0].AxisY.Interval = 10;

            // DataReader와 데이터베이스 연결 종료
            rdr.Close();
            conn.Close();
        }

        // "부품 차트 보기" 버튼 클릭 시 이벤트 핸들러
        private void ButtonShowChartParts_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // "Cell"을 포함하는 부품 모델명과 해당 부품 수량 가져오기
            cmd.CommandText = "SELECT * FROM PART\r\nWHERE 부품모델명 LIKE '%Cell%'";

            OracleDataReader rdr = cmd.ExecuteReader();

            // 데이터베이스에서 가져온 각 행에 대해 차트에 데이터 추가
            while (rdr.Read())
            {
                string modelparts = rdr["부품모델명"].ToString();
                int parts = int.Parse(rdr["부품수량"].ToString());

                // 부품 모델명(X 값)과 부품 수량(Y 값)을 차트에 추가
                chart1.Series[0].Points.AddXY(modelparts, parts);
            }

            // Y축 간격 설정
            chart1.ChartAreas[0].AxisY.Interval = 10;

            // DataReader와 데이터베이스 연결 종료
            rdr.Close();
            conn.Close();
        }

        // "BP 부품 차트 보기" 버튼 클릭 시 이벤트 핸들러
        private void ButtonShowChartBP_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // "BP"를 포함하는 부품 모델명과 해당 부품 수량 가져오기
            cmd.CommandText = "SELECT * FROM PART\r\nWHERE 부품모델명 LIKE '%BP%'";

            OracleDataReader rdr = cmd.ExecuteReader();

            // 데이터베이스에서 가져온 각 행에 대해 차트에 데이터 추가
            while (rdr.Read())
            {
                string modelparts = rdr["부품모델명"].ToString();
                int parts = int.Parse(rdr["부품수량"].ToString());

                // 부품 모델명(X 값)과 부품 수량(Y 값)을 차트에 추가
                chart1.Series[0].Points.AddXY(modelparts, parts);
            }

            // Y축 간격 설정
            chart1.ChartAreas[0].AxisY.Interval = 10;

            // DataReader와 데이터베이스 연결 종료
            rdr.Close();
            conn.Close();
        }

        // "프론트 모터 차트 보기" 버튼 클릭 시 이벤트 핸들러
        private void ButtonShowFMotor_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // "Front"를 포함하는 부품 모델명과 해당 부품 수량 가져오기
            cmd.CommandText = "SELECT * FROM PART\r\nWHERE 부품모델명 LIKE '%Front%'";

            OracleDataReader rdr = cmd.ExecuteReader();

            // 데이터베이스에서 가져온 각 행에 대해 차트에 데이터 추가
            while (rdr.Read())
            {
                string modelparts = rdr["부품모델명"].ToString();
                int parts = int.Parse(rdr["부품수량"].ToString());

                // 부품 모델명(X 값)과 부품 수량(Y 값)을 차트에 추가
                chart1.Series[0].Points.AddXY(modelparts, parts);
            }

            // Y축 간격 설정
            chart1.ChartAreas[0].AxisY.Interval = 10;

            // DataReader와 데이터베이스 연결 종료
            rdr.Close();
            conn.Close();
        }

        // "리어 모터 차트 보기" 버튼 클릭 시 이벤트 핸들러
        private void ButtonShowChartRMotor_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // "Rear"를 포함하는 부품 모델명과 해당 부품 수량 가져오기
            cmd.CommandText = "SELECT * FROM PART\r\nWHERE 부품모델명 LIKE '%Rear%'";

            OracleDataReader rdr = cmd.ExecuteReader();

            // 데이터베이스에서 가져온 각 행에 대해 차트에 데이터 추가
            while (rdr.Read())
            {
                string modelparts = rdr["부품모델명"].ToString();
                int parts = int.Parse(rdr["부품수량"].ToString());

                // 부품 모델명(X 값)과 부품 수량(Y 값)을 차트에 추가
                chart1.Series[0].Points.AddXY(modelparts, parts);
            }

            // Y축 간격 설정
            chart1.ChartAreas[0].AxisY.Interval = 10;

            // DataReader와 데이터베이스 연결 종료
            rdr.Close();
            conn.Close();
        }

        // "인버터 차트 보기" 버튼 클릭 시 이벤트 핸들러
        private void ButtonShowChartInvertor_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // "Inverter"를 포함하는 부품 모델명과 해당 부품 수량 가져오기
            cmd.CommandText = "SELECT * FROM PART\r\nWHERE 부품모델명 LIKE '%Inverter%'";

            OracleDataReader rdr = cmd.ExecuteReader();

            // 데이터베이스에서 가져온 각 행에 대해 차트에 데이터 추가
            while (rdr.Read())
            {
                string modelparts = rdr["부품모델명"].ToString();
                int parts = int.Parse(rdr["부품수량"].ToString());

                // 부품 모델명(X 값)과 부품 수량(Y 값)을 차트에 추가
                chart1.Series[0].Points.AddXY(modelparts, parts);
            }

            // Y축 간격 설정
            chart1.ChartAreas[0].AxisY.Interval = 10;

            // DataReader와 데이터베이스 연결 종료
            rdr.Close();
            conn.Close();
        }

        // "드라이브 유닛 차트 보기" 버튼 클릭 시 이벤트 핸들러
        private void ButtonShowChartDUnit_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // "DriveUnit"을 포함하는 부품 모델명과 해당 부품 수량 가져오기
            cmd.CommandText = "SELECT * FROM PART\r\nWHERE 부품모델명 LIKE '%DriveUnit%'";

            OracleDataReader rdr = cmd.ExecuteReader();

            // 데이터베이스에서
            while (rdr.Read())
            {
                string modelparts = rdr["부품모델명"].ToString();
                int parts = int.Parse(rdr["부품수량"].ToString());

                // Add the model name as X value and sales as Y value
                chart1.Series[0].Points.AddXY(modelparts, parts);
            }

            chart1.ChartAreas[0].AxisY.Interval = 10;


            // Close the DataReader and connection
            rdr.Close();
            conn.Close();
        }

        private void ButtonShowChartFSD_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // Fetch all models and their cumulative sales
            cmd.CommandText = "SELECT * FROM PART\r\nWHERE 부품모델명 LIKE '%Computer%'";

            OracleDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string modelparts = rdr["부품모델명"].ToString();
                int parts = int.Parse(rdr["부품수량"].ToString());

                // Add the model name as X value and sales as Y value
                chart1.Series[0].Points.AddXY(modelparts, parts);
            }

            chart1.ChartAreas[0].AxisY.Interval = 10;


            // Close the DataReader and connection
            rdr.Close();
            conn.Close();
        }
    }
}
