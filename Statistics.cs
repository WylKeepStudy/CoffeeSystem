using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _316
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
            LoadCoffeeVarieties();
        }


        // 加载所有咖啡品种到ComboBox
        private void LoadCoffeeVarieties()
        {
            try
            {
                string connectionString = @"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DISTINCT Variety FROM COFFEE_INFO ORDER BY Variety";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            cmbVariety.Items.Clear();

                            while (reader.Read())
                            {
                                cmbVariety.Items.Add(reader["Variety"].ToString());
                            }
                        }
                    }
                }

                // 设置自动完成功能
                cmbVariety.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbVariety.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载咖啡品种失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //统计按钮
        // 修改后的查询按钮点击事件
        private void StaticBtn_Click(object sender, EventArgs e)
        {
            // 获取用户选择的咖啡品种
            string variety = cmbVariety.Text.Trim();

            if (string.IsNullOrEmpty(variety))
            {
                MessageBox.Show("请选择或输入咖啡品种", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = @"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 查询品鉴次数
                    string countQuery = @"
                SELECT COUNT(*) AS TastingCount
                FROM TASTING_RECORD tr
                JOIN COFFEE_INFO ci ON tr.CoffeeID = ci.CoffeeID
                WHERE ci.Variety = @Variety";

                    using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                    {
                        countCommand.Parameters.AddWithValue("@Variety", variety);
                        int tastingCount = (int)countCommand.ExecuteScalar();
                        TastingTimes.Text = tastingCount.ToString();
                    }

                    // 查询详细数据
                    string detailQuery = @"
                SELECT 
                    ci.Variety AS 咖啡品种,
                    ci.RoastLevel AS 烘焙程度,
                    ci.Origin AS 产地,
                    tr.TastingDate AS 品鉴日期,
                    tr.AromaIntensity AS 香气强度,
                    tr.AcidityLevel AS 酸度,
                    tr.BodyFeel AS 口感,
                    tr.FlavorNotes AS 风味描述,
                    tr.Score AS 评分
                FROM TASTING_RECORD tr
                JOIN COFFEE_INFO ci ON tr.CoffeeID = ci.CoffeeID
                WHERE ci.Variety = @Variety
                ORDER BY tr.TastingDate DESC";

                    using (SqlCommand detailCommand = new SqlCommand(detailQuery, connection))
                    {
                        detailCommand.Parameters.AddWithValue("@Variety", variety);

                        SqlDataAdapter adapter = new SqlDataAdapter(detailCommand);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        // 设置第一列样式
                        if (dataGridView1.Columns.Count > 0)
                        {
                            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.LightBlue;
                            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.DarkBlue;
                        }

                        // 调整列宽和显示设置
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TastingTimes.Text = "0";
                dataGridView1.DataSource = null;
            }
        }


        //切换咖啡信息窗体
        private void button1_Click(object sender, EventArgs e)
        {
            CoffeeInfo ci = new CoffeeInfo();
            ci.Show();
            this.Hide();
        }


        //切换品鉴记录窗体
        private void button2_Click(object sender, EventArgs e)
        {
            TastingRecord tr = new TastingRecord();
            tr.Show();
            this.Hide();
        }


        //退出键
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }
    }
}
