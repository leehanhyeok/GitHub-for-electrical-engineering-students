using Oracle.ManagedDataAccess.Client; // Oracle 데이터베이스 접근을 위한 Oracle 클라이언트 가져오기
using System;
using System.Data;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NumericApp
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

        // 폼이 로드될 때 실행되는 메소드
        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기 로드 작업을 여기에 추가할 수 있음 (현재 비어 있음)
        }

        // "Order" 버튼이 클릭되었을 때 실행되는 메소드
        private void ButtonOrder_Click(object sender, EventArgs e)
        {
            // OracleConnection 객체 생성
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    // 연결 열기
                    conn.Open();

                    // 트랜잭션 시작
                    OracleTransaction transaction = conn.BeginTransaction();

                    // ListView에서 아이템 가져오기
                    foreach (ListViewItem item in listViewModelCar.Items)
                    {
                        string modelName = item.Text; // 첫 번째 열 (모델명)
                        string quantity = item.SubItems[1].Text; // 두 번째 열 (수량)

                        // SQL 쿼리 작성
                        string sql = "INSERT INTO ORDERCAR (차종모델, 주문수량, 주문날짜) " +
                                     "VALUES (:modelName, :quantity, TO_CHAR(SYSDATE, 'YYYY/MM/DD HH24:MI:SS'))";

                        // OracleCommand 객체 생성
                        using (OracleCommand cmd = new OracleCommand(sql, conn))
                        {
                            // 파라미터 추가
                            cmd.Parameters.Add(new OracleParameter("modelName", modelName));
                            cmd.Parameters.Add(new OracleParameter("quantity", quantity));

                            // 쿼리 실행
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 트랜잭션 커밋
                    transaction.Commit();

                    // 성공 메시지 표시
                    MessageBox.Show("주문이 완료되었습니다!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // 에러 발생 시, 롤백
                    transaction.Rollback();

                    // 에러 메시지 표시
                    MessageBox.Show("에러발생: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // numericUpDownModel3 값이 변경되었을 때 실행되는 메소드 (현재 비어 있음)
        private void numericUpDownModel3_ValueChanged(object sender, EventArgs e)
        {
            // 필요한 경우 이곳에 값을 변경하는 로직을 추가할 수 있음
        }

        // "Add" 버튼이 클릭되었을 때 실행되는 메소드
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            listViewModelCar.Items.Clear(); // ListView의 기존 아이템을 모두 삭제

            // NumericUpDown 컨트롤에서 값 가져오기
            int modelSCount = (int)numericUpDownModelS.Value;
            int model3Count = (int)numericUpDownModel3.Value;
            int modelXCount = (int)numericUpDownModelX.Value;
            int modelYCount = (int)numericUpDownModelY.Value;

            // 각 모델의 이름과 수량을 ListView에 추가합니다.
            if (modelSCount > 0)
            {
                ListViewItem item = new ListViewItem("테슬라 모델 S");  // 첫 번째 열에 모델 이름 추가
                item.SubItems.Add(modelSCount.ToString()); // 두 번째 열에 수량 추가
                listViewModelCar.Items.Add(item);
            }

            if (model3Count > 0)
            {
                ListViewItem item = new ListViewItem("테슬라 모델 3");
                item.SubItems.Add(model3Count.ToString());
                listViewModelCar.Items.Add(item);
            }

            if (modelXCount > 0)
            {
                ListViewItem item = new ListViewItem("테슬라 모델 X");
                item.SubItems.Add(modelXCount.ToString());
                listViewModelCar.Items.Add(item);
            }

            if (modelYCount > 0)
            {
                ListViewItem item = new ListViewItem("테슬라 모델 Y");
                item.SubItems.Add(modelYCount.ToString());
                listViewModelCar.Items.Add(item);
            }
        }

        // "Delete" 버튼이 클릭되었을 때 실행되는 메소드
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // 삭제 확인 메시지 박스 표시
            if (MessageBox.Show("선택하신 항목이 삭제 됩니다.\r계속 하시겠습니까?", "항목 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // ListView에서 선택된 아이템이 있는지 확인
                if (listViewModelCar.SelectedItems.Count > 0)
                {
                    // 선택된 아이템의 인덱스를 가져와서 해당 아이템 삭제
                    int index = listViewModelCar.FocusedItem.Index;
                    listViewModelCar.Items.RemoveAt(index);
                }
                else
                {
                    // 선택된 항목이 없을 경우 메시지 박스 표시
                    MessageBox.Show("선택하신 항목이 없습니다.");
                }
            }
        }

        // "Close" 버튼이 클릭되었을 때 실행되는 메소드
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close(); // 폼 닫기
        }
    }
}
