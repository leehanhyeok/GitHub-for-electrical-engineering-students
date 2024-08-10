using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DataGridApp04
{
    public partial class Form1 : Form
    {
        private string connectionString = "User Id=scott;Password=tiger;Data Source=localhost:9000/XE;";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void LoadData()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID, NAME, HP FROM STUDENT";
                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    //컬럼 이름 설정
                    dataGridView1.Columns["ID"].HeaderText = "번호";
                    dataGridView1.Columns["Name"].HeaderText = "이름";
                    dataGridView1.Columns["Hp"].HeaderText = "핸드폰 번호";
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 로드 중 오류 : {ex.Message}");
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text;
            bool found = false;

            foreach(DataGridViewRow row in dataGridView1.SelectedRows) //선택된 row에서 동일한 이름의 값을 찾음 
            {
                if (row.Cells["Name"].Value != null && row.Cells["Name"].Value.ToString().Equals(searchValue))
                {
                    row.Selected = true;
                    found = true;
                    MessageBox.Show("찾았습니다.");
                    return;
                }
                
            }
            if (!found) 
                MessageBox.Show("해당 이름이 없습니다!");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO STUDENT (ID, NAME, HP) VALUES (:ID, :NAME, :HP)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add("Id", OracleDbType.Int32).Value = int.Parse(textBoxNo.Text);
                        command.Parameters.Add("Name", OracleDbType.Varchar2).Value = textBoxName.Text;
                        command.Parameters.Add("Hp", OracleDbType.Varchar2).Value = textBoxHp.Text;

                        command.ExecuteNonQuery();
                    }
                    LoadData();

                    textBoxNo.Clear();
                    textBoxName.Clear();
                    textBoxHp.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"데이터 삽입 중오류: {ex.Message}");
                }

            }
            textBoxNo.Clear() ; 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int IdNum;
            if(int.TryParse(textBoxNo.Text, out IdNum))
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM STUDENT WHERE ID = :ID";
                        using (OracleCommand command = new OracleCommand(query, connection))
                        {
                            command.Parameters.Add("ID", OracleDbType.Int32).Value = IdNum;
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("데이터가 성공적으로 삭제 되었습니다.");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("삭제할 데이터가 없습니다.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"데이터 삭제 중 오류 : {ex.Message}");
                    }
                }
                textBoxNo.Clear();
               
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
