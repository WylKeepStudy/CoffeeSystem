using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _316
{
    public partial class CoffeeInfo : Form
    {


        //构造器
        public CoffeeInfo()
        {
            InitializeComponent();
        }

        //退出键
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //获取连接
        SqlConnection connection = new SqlConnection(@"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True");

        //添加记录
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            // 检查所有必填字段是否为空
            if (string.IsNullOrWhiteSpace(Variety.Text) ||
                string.IsNullOrWhiteSpace(RoastLevel.Text) ||
                string.IsNullOrWhiteSpace(Origin.Text))
            {
                MessageBox.Show("请正确填写所有必填字段！");
                return;
            }



            try
            {
                connection.Open();
                string sql = @"INSERT INTO COFFEE_INFO
                          (Variety, RoastLevel, Origin, RoastDate, Notes) 
                          VALUES 
                          (@Variety, @RoastLevel, @Origin, @RoastDate, @Notes)";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // 添加参数
                    command.Parameters.AddWithValue("@Variety", Variety.Text.Trim());
                    command.Parameters.AddWithValue("@RoastLevel", RoastLevel.Text.Trim());
                    command.Parameters.AddWithValue("@Origin", Origin.Text.Trim());
                    command.Parameters.AddWithValue("@RoastDate", RoastDate.Text.Trim());

                    // 处理可空的Notes字段
                    if (!string.IsNullOrWhiteSpace(Notes.Text))
                    {
                        command.Parameters.AddWithValue("@Notes", Notes.Text.Trim());
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    }

                    // 执行插入
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("咖啡信息添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refresh_Click(null, null);
                        // 清空输入框
                        ClearInputs();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();  // 确保连接关闭
                    connection.Dispose(); // 释放资源
                }
            }


        }  

        //清除框内内容
        private void ClearInputs()
        {
            //CoffeeID_01.Clear();
            Variety.Clear();
            RoastLevel.SelectedIndex = -1;
            Origin.Clear();
            RoastDate.Clear();
            Notes.Clear();
        }

        //窗体加载时进行数据展示初始化
        private void CoffeeInfo_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“coffeeSystemDataSet.COFFEE_INFO”中。您可以根据需要移动或移除它。
            this.cOFFEE_INFOTableAdapter.Fill(this.coffeeSystemDataSet.COFFEE_INFO);



        }

        //条件查询
        private void ReadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 构建基础SQL语句
                string sql = @"SELECT 
            CoffeeID,
            Variety AS varietyDataGridViewTextBoxColumn,
            RoastLevel AS roastLevelDataGridViewTextBoxColumn,
            Origin AS originDataGridViewTextBoxColumn,
            CONVERT(varchar, RoastDate, 23) AS roastDateDataGridViewTextBoxColumn,
            ISNULL(Notes, '') AS notesDataGridViewTextBoxColumn
            FROM COFFEE_INFO 
            WHERE 1=1"; // 初始条件永远为真
                        //使用 AS 为列设置别名（与 DataGridView 列名匹配 ）

                // 2. 声明并初始化参数集合
                List<SqlParameter> parameters = new List<SqlParameter>();

                // 3. 动态添加查询条件
                if (!string.IsNullOrWhiteSpace(Variety.Text))
                {
                    sql += " AND Variety LIKE @Variety";
                    parameters.Add(new SqlParameter("@Variety", "%" + Variety.Text.Trim() + "%"));
                }

                if (RoastLevel.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(RoastLevel.Text))
                {
                    sql += " AND RoastLevel = @RoastLevel";
                    parameters.Add(new SqlParameter("@RoastLevel", RoastLevel.Text.Trim()));
                }

                if (!string.IsNullOrWhiteSpace(Origin.Text))
                {
                    sql += " AND Origin LIKE @Origin";
                    parameters.Add(new SqlParameter("@Origin", "%" + Origin.Text.Trim() + "%"));
                }

                if (!string.IsNullOrWhiteSpace(RoastDate.Text))
                {
                    sql += " AND CONVERT(date, RoastDate) = @RoastDate";
                    parameters.Add(new SqlParameter("@RoastDate", RoastDate.Text.Trim()));
                }

                // 4. 执行查询（每次创建新的连接）
                using (SqlConnection connection = new SqlConnection(@"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);

                    // 添加参数到命令
                    command.Parameters.AddRange(parameters.ToArray());

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 5. 清除现有数据
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();

                    // 6. 检查是否查询到数据
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("没有找到匹配的记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 7. 设置数据源
                    dataGridView1.DataSource = dt;

                    // 8. 移除序号列（可选）
                    //if (dataGridView1.Columns.Contains("序号"))
                    //{
                    //   dataGridView1.Columns.Remove("序号");
                    // }

                    // 配置列显示
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.ColumnHeadersVisible = true;
                    // 调整列宽
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                    if (dataGridView1.Columns.Contains("CoffeeID"))
                        dataGridView1.Columns["CoffeeID"].HeaderText = "咖啡编号";
                    if (dataGridView1.Columns.Contains("varietyDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["varietyDataGridViewTextBoxColumn"].HeaderText = "品种";
                    if (dataGridView1.Columns.Contains("roastLevelDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["roastLevelDataGridViewTextBoxColumn"].HeaderText = "烘焙程度";
                    if (dataGridView1.Columns.Contains("originDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["originDataGridViewTextBoxColumn"].HeaderText = "产地";
                    if (dataGridView1.Columns.Contains("roastDateDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["roastDateDataGridViewTextBoxColumn"].HeaderText = "烘焙日期";
                    if (dataGridView1.Columns.Contains("notesDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["notesDataGridViewTextBoxColumn"].HeaderText = "备注";



                    // 刷新显示
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //刷新数据展示
        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                // 清空所有查询条件
                ClearInputs();

                // 重新初始化连接对象
                using (SqlConnection conn = new SqlConnection(@"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();

                    // 构建基础SQL查询（不包含序号列）
                    string sql = @"SELECT 
                    CoffeeID,
                    Variety AS varietyDataGridViewTextBoxColumn,
                    RoastLevel AS roastLevelDataGridViewTextBoxColumn,
                    Origin AS originDataGridViewTextBoxColumn,
                    CONVERT(varchar, RoastDate, 23) AS roastDateDataGridViewTextBoxColumn,
                    ISNULL(Notes, '') AS notesDataGridViewTextBoxColumn
                    FROM COFFEE_INFO 
                    ORDER BY CoffeeID";  // 按CoffeeID排序

                    SqlCommand command = new SqlCommand(sql, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 清除现有数据
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();

                    // 检查是否查询到数据
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("没有咖啡信息记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 设置数据源
                    dataGridView1.DataSource = dt;

                    // 配置列显示
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.ColumnHeadersVisible = true;

                    //调整列宽
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                    if (dataGridView1.Columns.Contains("CoffeeID"))
                        dataGridView1.Columns["CoffeeID"].HeaderText = "咖啡编号";
                    if (dataGridView1.Columns.Contains("varietyDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["varietyDataGridViewTextBoxColumn"].HeaderText = "品种";
                    if (dataGridView1.Columns.Contains("roastLevelDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["roastLevelDataGridViewTextBoxColumn"].HeaderText = "烘焙程度";
                    if (dataGridView1.Columns.Contains("originDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["originDataGridViewTextBoxColumn"].HeaderText = "产地";
                    if (dataGridView1.Columns.Contains("roastDateDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["roastDateDataGridViewTextBoxColumn"].HeaderText = "烘焙日期";
                    if (dataGridView1.Columns.Contains("notesDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["notesDataGridViewTextBoxColumn"].HeaderText = "备注";

                    // 刷新显示
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刷新失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //点击行后自动填入对应内容
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的是有效的数据行（不是标题行或无效行）
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // 获取选中的行
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // 使用列名而非索引（更安全，避免列顺序变化导致错误）
                    //?. 安全导航操作符：防止 Value 为 null 时抛出异常。
                    //?? 空值合并操作符：如果值为 null，则赋空字符串 ""。
                    Variety.Text = row.Cells["varietyDataGridViewTextBoxColumn"].Value?.ToString() ?? "";

                    // 设置烘焙程度下拉框（确保值存在）
                    string roastLevel = row.Cells["roastLevelDataGridViewTextBoxColumn"].Value?.ToString();
                    if (!string.IsNullOrEmpty(roastLevel))
                    {
                        RoastLevel.SelectedItem = roastLevel;
                    }

                    // 设置产地
                    Origin.Text = row.Cells["originDataGridViewTextBoxColumn"].Value?.ToString() ?? "";

                    // 设置烘焙日期（假设列名为"烘焙日期"）
                    if (row.Cells["roastDateDataGridViewTextBoxColumn"].Value != null)
                    {
                        RoastDate.Text = row.Cells["roastDateDataGridViewTextBoxColumn"].Value.ToString();
                    }

                    // 设置备注（可为空）
                    Notes.Text = row.Cells["notesDataGridViewTextBoxColumn"].Value?.ToString() ?? "";

                    // 如果需要CoffeeID（假设是隐藏列）
                    //if (dataGridView1.Columns.Contains("CoffeeID") && row.Cells["CoffeeID"].Value != null)
                   // {
                   //     key = Convert.ToInt32(row.Cells["CoffeeID"].Value); // 存储当前选中的ID
                 //  }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"数据加载失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 删除所选记录
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // 检查是否有选中的行
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要删除的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 获取选中行对象
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // 检查CoffeeID列是否存在且值不为空
            if (!dataGridView1.Columns.Contains("CoffeeID") || selectedRow.Cells["CoffeeID"].Value == null)
            {
                MessageBox.Show("无法获取记录ID，删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int coffeeId = Convert.ToInt32(selectedRow.Cells["CoffeeID"].Value);

            // 确认删除
            DialogResult confirm = MessageBox.Show($"确定要删除ID为 {coffeeId} 的记录吗？", "确认删除",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    string sql = "DELETE FROM COFFEE_INFO WHERE CoffeeID = @CoffeeID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CoffeeID", coffeeId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("记录删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // 刷新数据
                            refresh_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("删除失败，记录可能已被其他用户删除。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 修改所选记录
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // 检查是否有选中的行
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择要修改的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 获取选中行的第一行
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // 检查CoffeeID列是否存在且值不为空
            if (!dataGridView1.Columns.Contains("CoffeeID") || selectedRow.Cells["CoffeeID"].Value == null)
            {
                MessageBox.Show("无法获取记录ID，修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 获取当前记录的ID
            int coffeeId = Convert.ToInt32(selectedRow.Cells["CoffeeID"].Value);

            // 检查必填字段是否为空
            if (string.IsNullOrWhiteSpace(Variety.Text) ||
                string.IsNullOrWhiteSpace(RoastLevel.Text) ||
                string.IsNullOrWhiteSpace(Origin.Text))
            {
                MessageBox.Show("请正确填写所有必填字段！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 确认修改
            DialogResult confirm = MessageBox.Show($"确定要修改ID为 {coffeeId} 的记录吗？", "确认修改",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    string sql = @"UPDATE COFFEE_INFO SET 
                        Variety = @Variety,
                        RoastLevel = @RoastLevel,
                        Origin = @Origin,
                        RoastDate = @RoastDate,
                        Notes = @Notes
                        WHERE CoffeeID = @CoffeeID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // 添加参数
                        command.Parameters.AddWithValue("@CoffeeID", coffeeId);
                        command.Parameters.AddWithValue("@Variety", Variety.Text.Trim());
                        command.Parameters.AddWithValue("@RoastLevel", RoastLevel.Text.Trim());
                        command.Parameters.AddWithValue("@Origin", Origin.Text.Trim());

                        // 处理RoastDate（如果为空则设为NULL）
                        if (!string.IsNullOrWhiteSpace(RoastDate.Text))
                        {
                            command.Parameters.AddWithValue("@RoastDate", RoastDate.Text.Trim());
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@RoastDate", DBNull.Value);
                        }

                        // 处理Notes（如果为空则设为NULL）
                        if (!string.IsNullOrWhiteSpace(Notes.Text))
                        {
                            command.Parameters.AddWithValue("@Notes", Notes.Text.Trim());
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        }

                        // 执行更新
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("记录修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // 刷新数据
                            refresh_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("修改失败，记录可能已被其他用户删除。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 切换到品鉴页面
        private void button2_Click(object sender, EventArgs e)
        {
            TastingRecord tr = new TastingRecord();
            tr.Show();
            this.Hide();
        }

        //切换到统计窗体
        private void StatisticsBtn_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics();
            st.Show();
            this.Hide();
        }

        // 设置当前日期，格式为 SQL Server 接受的 DATE 格式 (yyyy-MM-dd)
        private void NowBtn_Click(object sender, EventArgs e)
        {
            RoastDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
        }

    }
}
