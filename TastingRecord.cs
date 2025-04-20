using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _316
{
    public partial class TastingRecord : Form
    {


        //构造函数
        public TastingRecord()
        {
            InitializeComponent();
        }


        // 在窗体类中添加字段  打印报表用
        private PrintDocument printDocument = new PrintDocument();
        private DataTable printData = new DataTable();


        //退出键
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //切换成咖啡信息窗体
        private void button1_Click(object sender, EventArgs e)
        {
            CoffeeInfo ci = new CoffeeInfo();
            ci.Show();
            this.Hide();
        }

        
        //获取连接
        private string connectionString = @"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True";




        //信息初始加载
        private void TastingRecord_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“coffeeSystemDataSet1.TASTING_RECORD”中。您可以根据需要移动或移除它。
            this.tASTING_RECORDTableAdapter.Fill(this.coffeeSystemDataSet1.TASTING_RECORD);


        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






        //刷新键
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

                    // 构建完整SQL查询（显示所有列）
                    string sql = @"SELECT 
                r.RecordID AS recordIDDataGridViewTextBoxColumn,
                r.CoffeeID AS coffeeIDDataGridViewTextBoxColumn,
                r.TastingDate AS tastingDateDataGridViewTextBoxColumn,
                r.AromaIntensity AS aromaIntensityDataGridViewTextBoxColumn,
                r.AcidityLevel AS acidityLevelDataGridViewTextBoxColumn,
                r.BodyFeel AS bodyFeelDataGridViewTextBoxColumn,
                ISNULL(r.FlavorNotes, '') AS flavorNotesDataGridViewTextBoxColumn,
                r.Score AS scoreDataGridViewTextBoxColumn
            FROM TASTING_RECORD r
            INNER JOIN COFFEE_INFO c ON r.CoffeeID = c.CoffeeID
            ORDER BY r.RecordID";

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
                        MessageBox.Show("没有品鉴记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 设置数据源
                    dataGridView1.DataSource = dt;

                    // 配置列显示（所有列都显示）
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.ColumnHeadersVisible = true;

                    // 调整列宽和显示设置
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    // 设置列标题（使用中文显示）
                    if (dataGridView1.Columns.Contains("recordIDDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["recordIDDataGridViewTextBoxColumn"].HeaderText = "记录ID";
                    if (dataGridView1.Columns.Contains("coffeeIDDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["coffeeIDDataGridViewTextBoxColumn"].HeaderText = "咖啡ID";
                    if (dataGridView1.Columns.Contains("tastingDateDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["tastingDateDataGridViewTextBoxColumn"].HeaderText = "品鉴日期";
                    if (dataGridView1.Columns.Contains("aromaIntensityDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["aromaIntensityDataGridViewTextBoxColumn"].HeaderText = "香气强度";
                    if (dataGridView1.Columns.Contains("acidityLevelDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["acidityLevelDataGridViewTextBoxColumn"].HeaderText = "酸度";
                    if (dataGridView1.Columns.Contains("bodyFeelDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["bodyFeelDataGridViewTextBoxColumn"].HeaderText = "口感";
                    if (dataGridView1.Columns.Contains("flavorNotesDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["flavorNotesDataGridViewTextBoxColumn"].HeaderText = "风味描述";
                    if (dataGridView1.Columns.Contains("scoreDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["scoreDataGridViewTextBoxColumn"].HeaderText = "评分";

                    // 刷新显示
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刷新失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //清除框中内容
        private void ClearInputs()
        {
            CoffeeID.Clear();
            TastingDate.Clear();
            AromaIntensity.SelectedIndex = -1;
            AcidityLevel.SelectedIndex = -1;
            BodyFeel.SelectedIndex = -1;
            FlavorNotes.Clear();
            Score.Clear();
        }


        //添加记录
        private void InsertBtn_Click(object sender, EventArgs e)
        {
                        // 验证必填字段
            if (string.IsNullOrWhiteSpace(CoffeeID.Text) || 
                string.IsNullOrWhiteSpace(TastingDate.Text))
            {
                MessageBox.Show("咖啡ID和品鉴日期是必填项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 验证咖啡ID是否为数字
            if (!int.TryParse(CoffeeID.Text, out int coffeeId))
            {
                MessageBox.Show("咖啡ID必须是数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 验证分数范围
            if (!string.IsNullOrWhiteSpace(Score.Text) && 
                (!int.TryParse(Score.Text, out int score) || score < 0 || score > 100))
            {
                MessageBox.Show("评分必须在0-100之间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    string sql = @"INSERT INTO TASTING_RECORD 
                                (CoffeeID, TastingDate, AromaIntensity, AcidityLevel, BodyFeel, FlavorNotes, Score)
                                VALUES 
                                (@CoffeeID, @TastingDate, @AromaIntensity, @AcidityLevel, @BodyFeel, @FlavorNotes, @Score)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CoffeeID", coffeeId);
                        command.Parameters.AddWithValue("@TastingDate", TastingDate.Text.Trim());
                        
                        // 处理下拉框
                        if (AromaIntensity.SelectedIndex != -1)
                            command.Parameters.AddWithValue("@AromaIntensity", AromaIntensity.SelectedItem.ToString());
                        else
                            command.Parameters.AddWithValue("@AromaIntensity", DBNull.Value);
                            
                        if (AcidityLevel.SelectedIndex != -1)
                            command.Parameters.AddWithValue("@AcidityLevel", AcidityLevel.SelectedItem.ToString());
                        else
                            command.Parameters.AddWithValue("@AcidityLevel", DBNull.Value);
                            
                        if (BodyFeel.SelectedIndex != -1)
                            command.Parameters.AddWithValue("@BodyFeel", BodyFeel.SelectedItem.ToString());
                        else
                            command.Parameters.AddWithValue("@BodyFeel", DBNull.Value);
                        
                        // 处理文本框
                        if (!string.IsNullOrWhiteSpace(FlavorNotes.Text))
                            command.Parameters.AddWithValue("@FlavorNotes", FlavorNotes.Text.Trim());
                        else
                            command.Parameters.AddWithValue("@FlavorNotes", DBNull.Value);
                            
                        if (!string.IsNullOrWhiteSpace(Score.Text))
                            command.Parameters.AddWithValue("@Score", int.Parse(Score.Text));
                        else
                            command.Parameters.AddWithValue("@Score", DBNull.Value);

                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("品鉴记录添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputs();
                            refresh_Click(null, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"添加记录失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 当前选中的记录ID
        private int currentRecordId = -1;

        // 点击行后自动填入对应内容并记录ID
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的是有效的数据行（不是标题行或无效行）
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // 获取选中的行
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // 记录当前选中记录的ID
                    if (row.Cells["recordIDDataGridViewTextBoxColumn"].Value != null)
                    {
                        currentRecordId = Convert.ToInt32(row.Cells["recordIDDataGridViewTextBoxColumn"].Value);
                    }

                    // 填充其他字段（根据您的实际列名调整）
                    if (dataGridView1.Columns.Contains("coffeeIDDataGridViewTextBoxColumn") && row.Cells["coffeeIDDataGridViewTextBoxColumn"].Value != null)
                    {
                        CoffeeID.Text = row.Cells["coffeeIDDataGridViewTextBoxColumn"].Value.ToString();
                    }

                    if (dataGridView1.Columns.Contains("tastingDateDataGridViewTextBoxColumn") && row.Cells["tastingDateDataGridViewTextBoxColumn"].Value != null)
                    {
                        TastingDate.Text = row.Cells["tastingDateDataGridViewTextBoxColumn"].Value.ToString();
                    }

                    // 设置下拉框值
                    if (dataGridView1.Columns.Contains("aromaIntensityDataGridViewTextBoxColumn") && row.Cells["aromaIntensityDataGridViewTextBoxColumn"].Value != null)
                    {
                        string aroma = row.Cells["aromaIntensityDataGridViewTextBoxColumn"].Value.ToString();
                        AromaIntensity.SelectedItem = aroma;
                    }

                    if (dataGridView1.Columns.Contains("acidityLevelDataGridViewTextBoxColumn") && row.Cells["acidityLevelDataGridViewTextBoxColumn"].Value != null)
                    {
                        string acidity = row.Cells["acidityLevelDataGridViewTextBoxColumn"].Value.ToString();
                        AcidityLevel.SelectedItem = acidity;
                    }

                    if (dataGridView1.Columns.Contains("bodyFeelDataGridViewTextBoxColumn") && row.Cells["bodyFeelDataGridViewTextBoxColumn"].Value != null)
                    {
                        string bodyFeel = row.Cells["bodyFeelDataGridViewTextBoxColumn"].Value.ToString();
                        BodyFeel.SelectedItem = bodyFeel;
                    }

                    // 设置文本框值
                    if (dataGridView1.Columns.Contains("flavorNotesDataGridViewTextBoxColumn") && row.Cells["flavorNotesDataGridViewTextBoxColumn"].Value != null)
                    {
                        FlavorNotes.Text = row.Cells["flavorNotesDataGridViewTextBoxColumn"].Value.ToString();
                    }

                    if (dataGridView1.Columns.Contains("scoreDataGridViewTextBoxColumn") && row.Cells["scoreDataGridViewTextBoxColumn"].Value != null)
                    {
                        Score.Text = row.Cells["scoreDataGridViewTextBoxColumn"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"数据加载失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //删除记录
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (currentRecordId == -1)
            {
                MessageBox.Show("请先选择要删除的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 确认对话框
            DialogResult result = MessageBox.Show("确定要删除这条记录吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM TASTING_RECORD WHERE RecordID = @RecordID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@RecordID", currentRecordId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("品鉴记录删除成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputs();
                            refresh_Click(null, null);
                            currentRecordId = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除记录失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //更新记录
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (currentRecordId == -1)
            {
                MessageBox.Show("请先选择要修改的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 验证必填字段
            if (string.IsNullOrWhiteSpace(CoffeeID.Text) || 
                string.IsNullOrWhiteSpace(TastingDate.Text))
            {
                MessageBox.Show("咖啡ID和品鉴日期是必填项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 验证咖啡ID是否为数字
            if (!int.TryParse(CoffeeID.Text, out int coffeeId))
            {
                MessageBox.Show("咖啡ID必须是数字！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 验证分数范围
            if (!string.IsNullOrWhiteSpace(Score.Text) && 
                (!int.TryParse(Score.Text, out int score) || score < 0 || score > 100))
            {
                MessageBox.Show("评分必须在0-100之间！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 确认对话框
            DialogResult result = MessageBox.Show("确定要修改这条记录吗？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    string sql = @"UPDATE TASTING_RECORD SET 
                                CoffeeID = @CoffeeID, 
                                TastingDate = @TastingDate, 
                                AromaIntensity = @AromaIntensity, 
                                AcidityLevel = @AcidityLevel, 
                                BodyFeel = @BodyFeel, 
                                FlavorNotes = @FlavorNotes, 
                                Score = @Score
                                WHERE RecordID = @RecordID";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@RecordID", currentRecordId);
                        command.Parameters.AddWithValue("@CoffeeID", coffeeId);
                        command.Parameters.AddWithValue("@TastingDate", TastingDate.Text.Trim());
                        
                        // 处理下拉框
                        if (AromaIntensity.SelectedIndex != -1)
                            command.Parameters.AddWithValue("@AromaIntensity", AromaIntensity.SelectedItem.ToString());
                        else
                            command.Parameters.AddWithValue("@AromaIntensity", DBNull.Value);
                            
                        if (AcidityLevel.SelectedIndex != -1)
                            command.Parameters.AddWithValue("@AcidityLevel", AcidityLevel.SelectedItem.ToString());
                        else
                            command.Parameters.AddWithValue("@AcidityLevel", DBNull.Value);
                            
                        if (BodyFeel.SelectedIndex != -1)
                            command.Parameters.AddWithValue("@BodyFeel", BodyFeel.SelectedItem.ToString());
                        else
                            command.Parameters.AddWithValue("@BodyFeel", DBNull.Value);
                        
                        // 处理文本框
                        if (!string.IsNullOrWhiteSpace(FlavorNotes.Text))
                            command.Parameters.AddWithValue("@FlavorNotes", FlavorNotes.Text.Trim());
                        else
                            command.Parameters.AddWithValue("@FlavorNotes", DBNull.Value);
                            
                        if (!string.IsNullOrWhiteSpace(Score.Text))
                            command.Parameters.AddWithValue("@Score", int.Parse(Score.Text));
                        else
                            command.Parameters.AddWithValue("@Score", DBNull.Value);

                        int rowsAffected = command.ExecuteNonQuery();
                        
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("品鉴记录修改成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputs();
                            refresh_Click(null, null); 
                            currentRecordId = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改记录失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //条件查询
        private void SelectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 构建基础SQL语句（关联COFFEE_INFO表获取咖啡品种）
                string sql = @"SELECT 
                    r.RecordID AS recordIDDataGridViewTextBoxColumn,
                    r.CoffeeID AS coffeeIDDataGridViewTextBoxColumn,
                    CONVERT(varchar, r.TastingDate, 120) AS tastingDateDataGridViewTextBoxColumn,
                    r.AromaIntensity AS aromaIntensityDataGridViewTextBoxColumn,
                    r.AcidityLevel AS acidityLevelDataGridViewTextBoxColumn,
                    r.BodyFeel AS bodyFeelDataGridViewTextBoxColumn,
                    ISNULL(r.FlavorNotes, '') AS flavorNotesDataGridViewTextBoxColumn,
                    r.Score AS scoreDataGridViewTextBoxColumn
                FROM TASTING_RECORD r
                INNER JOIN COFFEE_INFO c ON r.CoffeeID = c.CoffeeID
                WHERE 1=1"; // 初始条件永远为真

                // 2. 声明并初始化参数集合（修复：确保 parameters 已定义）
                List<SqlParameter> parameters = new List<SqlParameter>(); // 添加此行

                // 3. 动态添加查询条件
                if (!string.IsNullOrWhiteSpace(CoffeeID.Text))
                {
                    sql += " AND r.CoffeeID = @CoffeeID";
                    parameters.Add(new SqlParameter("@CoffeeID", CoffeeID.Text.Trim()));
                }

                if (!string.IsNullOrWhiteSpace(TastingDate.Text))
                {
                    sql += " AND CONVERT(date, r.TastingDate) = @TastingDate";
                    parameters.Add(new SqlParameter("@TastingDate", TastingDate.Text.Trim()));
                }

                if (AromaIntensity.SelectedIndex != -1)
                {
                    sql += " AND r.AromaIntensity = @AromaIntensity";
                    parameters.Add(new SqlParameter("@AromaIntensity", AromaIntensity.SelectedItem.ToString()));
                }

                if (AcidityLevel.SelectedIndex != -1)
                {
                    sql += " AND r.AcidityLevel = @AcidityLevel";
                    parameters.Add(new SqlParameter("@AcidityLevel", AcidityLevel.SelectedItem.ToString()));
                }

                if (BodyFeel.SelectedIndex != -1)
                {
                    sql += " AND r.BodyFeel = @BodyFeel";
                    parameters.Add(new SqlParameter("@BodyFeel", BodyFeel.SelectedItem.ToString()));
                }

                if (!string.IsNullOrWhiteSpace(FlavorNotes.Text))
                {
                    sql += " AND r.FlavorNotes LIKE @FlavorNotes";
                    parameters.Add(new SqlParameter("@FlavorNotes", "%" + FlavorNotes.Text.Trim() + "%"));
                }

                if (!string.IsNullOrWhiteSpace(Score.Text))
                {
                    sql += " AND r.Score = @Score";
                    parameters.Add(new SqlParameter("@Score", Score.Text.Trim()));
                }

                // 4. 执行查询
                using (SqlConnection connection = new SqlConnection(@"Data Source=吴宇伦的笔记本;Initial Catalog=CoffeeSystem;Integrated Security=True;TrustServerCertificate=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);

                    // 添加参数到命令（修复：确保 parameters 已定义）
                    command.Parameters.AddRange(parameters.ToArray()); // 使用 parameters

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // 5. 清除现有数据
                    dataGridView1.DataSource = null;
                    dataGridView1.Columns.Clear();

                    // 6. 检查是否查询到数据
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("没有找到匹配的品鉴记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 7. 设置数据源
                    dataGridView1.DataSource = dt;




                    // 8. 配置列显示
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.ColumnHeadersVisible = true;

                    // 9. 调整列宽和选择模式
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                    if (dataGridView1.Columns.Contains("recordIDDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["recordIDDataGridViewTextBoxColumn"].HeaderText = "记录ID";
                    if (dataGridView1.Columns.Contains("coffeeIDDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["coffeeIDDataGridViewTextBoxColumn"].HeaderText = "咖啡ID";
                    if (dataGridView1.Columns.Contains("tastingDateDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["tastingDateDataGridViewTextBoxColumn"].HeaderText = "品鉴日期";
                    if (dataGridView1.Columns.Contains("aromaIntensityDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["aromaIntensityDataGridViewTextBoxColumn"].HeaderText = "香气强度";
                    if (dataGridView1.Columns.Contains("acidityLevelDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["acidityLevelDataGridViewTextBoxColumn"].HeaderText = "酸度";
                    if (dataGridView1.Columns.Contains("bodyFeelDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["bodyFeelDataGridViewTextBoxColumn"].HeaderText = "口感";
                    if (dataGridView1.Columns.Contains("flavorNotesDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["flavorNotesDataGridViewTextBoxColumn"].HeaderText = "风味描述";
                    if (dataGridView1.Columns.Contains("scoreDataGridViewTextBoxColumn"))
                        dataGridView1.Columns["scoreDataGridViewTextBoxColumn"].HeaderText = "评分";

                    // 10. 刷新显示
                    dataGridView1.Refresh();


                }
            }
            catch (FormatException)
            {
                MessageBox.Show("请输入有效的查询条件（如：咖啡ID和评分应为数字）", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"数据库错误: {sqlEx.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // 打印按钮点击事件 - 改为显示预览
        private void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建打印文档
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
                printDoc.DocumentName = "咖啡品鉴记录报表";

                // 创建打印预览对话框
                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = printDoc;
                previewDialog.WindowState = FormWindowState.Maximized; // 最大化窗口
                previewDialog.ShowIcon = false;
                previewDialog.Text = "咖啡品鉴记录 - 打印预览";

                // 显示预览对话框
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打印预览失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打印页面事件处理（与之前相同）
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // 获取打印图形对象
            Graphics g = e.Graphics;

            // 设置字体
            Font titleFont = new Font("宋体", 16, FontStyle.Bold);
            Font headerFont = new Font("宋体", 10, FontStyle.Bold);
            Font contentFont = new Font("宋体", 9);

            // 设置边距和行高
            int leftMargin = 50;
            int topMargin = 50;
            int lineHeight = 20;
            int cellPadding = 5; // 单元格内边距

            // 打印标题
            string title = "咖啡品鉴记录报表";
            SizeF titleSize = g.MeasureString(title, titleFont);
            g.DrawString(title, titleFont, Brushes.Black,
                (e.PageBounds.Width - titleSize.Width) / 2, topMargin);

            // 打印日期
            string printDate = "打印日期: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            g.DrawString(printDate, contentFont, Brushes.Black,
                leftMargin, topMargin + lineHeight * 2);

            // 获取数据源
            DataTable dt = GetDataTableFromDataSource();

            // 计算每列所需宽度
            int[] columnWidths = new int[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                // 测量列名宽度
                string columnName = GetDisplayColumnName(dt.Columns[i].ColumnName);
                float headerWidth = g.MeasureString(columnName, headerFont).Width;

                // 测量该列所有数据内容的宽度
                float maxDataWidth = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string cellValue = row[i]?.ToString() ?? "";
                    float cellWidth = g.MeasureString(cellValue, contentFont).Width;
                    if (cellWidth > maxDataWidth)
                        maxDataWidth = cellWidth;
                }

                // 取列名和内容中较大的宽度，加上内边距
                columnWidths[i] = (int)Math.Max(headerWidth, maxDataWidth) + cellPadding * 2;
            }

            // 计算总宽度
            int totalWidth = columnWidths.Sum();

            // 如果总宽度超过页面宽度，按比例缩小所有列
            int availableWidth = e.PageBounds.Width - leftMargin * 2;
            if (totalWidth > availableWidth)
            {
                float scaleFactor = (float)availableWidth / totalWidth;
                for (int i = 0; i < columnWidths.Length; i++)
                {
                    columnWidths[i] = (int)(columnWidths[i] * scaleFactor);
                }
            }

            // 打印表头
            int currentY = topMargin + lineHeight * 4;
            int currentX = leftMargin;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string columnName = GetDisplayColumnName(dt.Columns[i].ColumnName);

                // 绘制列名（居中显示）
                float textWidth = g.MeasureString(columnName, headerFont).Width;
                float textX = currentX + (columnWidths[i] - textWidth) / 2;

                g.DrawString(columnName, headerFont, Brushes.Black, textX, currentY);

                // 绘制列边框
                g.DrawRectangle(Pens.Black, currentX, currentY, columnWidths[i], lineHeight);

                currentX += columnWidths[i];
            }

            // 打印数据行
            currentY += lineHeight;

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    // 检查是否超出页面范围
                    if (currentY > e.PageBounds.Height - topMargin)
                    {
                        e.HasMorePages = true;
                        return;
                    }

                    currentX = leftMargin;

                    // 打印每行数据
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        string cellValue = row[i]?.ToString() ?? "";

                        // 计算文本宽度
                        float textWidth = g.MeasureString(cellValue, contentFont).Width;

                        // 如果文本宽度超过列宽，则截断并添加省略号
                        if (textWidth > columnWidths[i] - cellPadding * 2)
                        {
                            while (g.MeasureString(cellValue + "...", contentFont).Width > columnWidths[i] - cellPadding * 2
                                   && cellValue.Length > 0)
                            {
                                cellValue = cellValue.Substring(0, cellValue.Length - 1);
                            }
                            cellValue += "...";
                        }

                        // 绘制单元格内容（左对齐）
                        g.DrawString(cellValue, contentFont, Brushes.Black,
                            currentX + cellPadding, currentY);

                        // 绘制单元格边框
                        g.DrawRectangle(Pens.Black, currentX, currentY, columnWidths[i], lineHeight);

                        currentX += columnWidths[i];
                    }

                    currentY += lineHeight;
                }
            }
            else
            {
                g.DrawString("没有可打印的数据", contentFont, Brushes.Black, leftMargin, currentY);
            }

            // 打印页脚
            string footer = "---- 结束 ----";
            g.DrawString(footer, contentFont, Brushes.Black,
                (e.PageBounds.Width - g.MeasureString(footer, contentFont).Width) / 2,
                e.PageBounds.Height - topMargin);

            e.HasMorePages = false;
        }

        // 辅助方法：获取显示用的列名
        private string GetDisplayColumnName(string columnName)
        {
            // 简化列名显示（去掉DataGridViewTextBoxColumn后缀）
            if (columnName.EndsWith("DataGridViewTextBoxColumn"))
            {
                columnName = columnName.Substring(0, columnName.Length - "DataGridViewTextBoxColumn".Length);
            }

            // 可以根据需要添加更多的列名转换规则
            return columnName;
        }

        // 新增方法：从DataSource获取DataTable
        private DataTable GetDataTableFromDataSource()
        {
            if (dataGridView1.DataSource == null)
                return new DataTable();

            if (dataGridView1.DataSource is DataTable)
                return (DataTable)dataGridView1.DataSource;

            if (dataGridView1.DataSource is BindingSource)
            {
                var bindingSource = (BindingSource)dataGridView1.DataSource;
                if (bindingSource.DataSource is DataTable)
                    return (DataTable)bindingSource.DataSource;
            }

            // 如果以上方式都失败，从DataGridView中提取数据
            DataTable dt = new DataTable();

            // 添加列
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.Name);
            }

            // 添加行
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                DataRow dataRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }

        // 如果需要直接从预览界面打印，可以添加这个按钮事件
        private void PrintFromPreview_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建打印文档
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
                printDoc.DocumentName = "咖啡品鉴记录报表";

                // 显示打印对话框
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打印失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //切换成统计窗体
        private void StaticBtn_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics();
            st.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NowBtn_Click(object sender, EventArgs e)
        {
            // 设置当前时间，格式为 SQL Server 接受的 datetime 格式
            TastingDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
