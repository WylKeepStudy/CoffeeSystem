namespace _316
{
    partial class TastingRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StatisticsBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NowBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.BodyFeel = new System.Windows.Forms.ComboBox();
            this.AcidityLevel = new System.Windows.Forms.ComboBox();
            this.AromaIntensity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FlavorNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TastingDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CoffeeID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tastingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aromaIntensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acidityLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyFeelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flavorNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tASTINGRECORDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeSystemDataSet1 = new _316.CoffeeSystemDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tASTING_RECORDTableAdapter = new _316.CoffeeSystemDataSet1TableAdapters.TASTING_RECORDTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASTINGRECORDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StatisticsBtn
            // 
            this.StatisticsBtn.BackColor = System.Drawing.Color.MistyRose;
            this.StatisticsBtn.Font = new System.Drawing.Font("华文中宋", 16F);
            this.StatisticsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatisticsBtn.Location = new System.Drawing.Point(87, 535);
            this.StatisticsBtn.Name = "StatisticsBtn";
            this.StatisticsBtn.Size = new System.Drawing.Size(240, 89);
            this.StatisticsBtn.TabIndex = 13;
            this.StatisticsBtn.Text = "统计";
            this.StatisticsBtn.UseVisualStyleBackColor = false;
            this.StatisticsBtn.Click += new System.EventHandler(this.StaticBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("华文中宋", 16F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(87, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 89);
            this.button2.TabIndex = 12;
            this.button2.Text = "品鉴记录";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.NowBtn);
            this.panel2.Controls.Add(this.PrintBtn);
            this.panel2.Controls.Add(this.refresh);
            this.panel2.Controls.Add(this.BodyFeel);
            this.panel2.Controls.Add(this.AcidityLevel);
            this.panel2.Controls.Add(this.AromaIntensity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Score);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.FlavorNotes);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TastingDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CoffeeID);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.SelectBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.InsertBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(397, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 934);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // NowBtn
            // 
            this.NowBtn.Font = new System.Drawing.Font("华文中宋", 12F);
            this.NowBtn.Location = new System.Drawing.Point(653, 172);
            this.NowBtn.Name = "NowBtn";
            this.NowBtn.Size = new System.Drawing.Size(75, 36);
            this.NowBtn.TabIndex = 43;
            this.NowBtn.Text = "Now";
            this.NowBtn.UseVisualStyleBackColor = true;
            this.NowBtn.Click += new System.EventHandler(this.NowBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.PrintBtn.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PrintBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrintBtn.Location = new System.Drawing.Point(3, 3);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(166, 48);
            this.PrintBtn.TabIndex = 42;
            this.PrintBtn.Text = "打印报表";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // refresh
            // 
            this.refresh.Image = global::_316.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(993, 438);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(41, 40);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 41;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // BodyFeel
            // 
            this.BodyFeel.Font = new System.Drawing.Font("华文中宋", 12F);
            this.BodyFeel.FormattingEnabled = true;
            this.BodyFeel.Items.AddRange(new object[] {
            "轻盈",
            "中等",
            "厚重"});
            this.BodyFeel.Location = new System.Drawing.Point(389, 243);
            this.BodyFeel.Name = "BodyFeel";
            this.BodyFeel.Size = new System.Drawing.Size(99, 35);
            this.BodyFeel.TabIndex = 40;
            // 
            // AcidityLevel
            // 
            this.AcidityLevel.Font = new System.Drawing.Font("华文中宋", 12F);
            this.AcidityLevel.FormattingEnabled = true;
            this.AcidityLevel.Items.AddRange(new object[] {
            "柔和",
            "明亮",
            "尖锐"});
            this.AcidityLevel.Location = new System.Drawing.Point(146, 244);
            this.AcidityLevel.Name = "AcidityLevel";
            this.AcidityLevel.Size = new System.Drawing.Size(99, 35);
            this.AcidityLevel.TabIndex = 39;
            // 
            // AromaIntensity
            // 
            this.AromaIntensity.Font = new System.Drawing.Font("华文中宋", 12F);
            this.AromaIntensity.FormattingEnabled = true;
            this.AromaIntensity.Items.AddRange(new object[] {
            "低",
            "中",
            "高"});
            this.AromaIntensity.Location = new System.Drawing.Point(883, 169);
            this.AromaIntensity.Name = "AromaIntensity";
            this.AromaIntensity.Size = new System.Drawing.Size(99, 35);
            this.AromaIntensity.TabIndex = 38;
            this.AromaIntensity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(820, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 27);
            this.label6.TabIndex = 37;
            this.label6.Text = "评分";
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Score.Location = new System.Drawing.Point(886, 240);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(96, 39);
            this.Score.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(532, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "风味描述";
            // 
            // FlavorNotes
            // 
            this.FlavorNotes.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FlavorNotes.Location = new System.Drawing.Point(646, 240);
            this.FlavorNotes.Name = "FlavorNotes";
            this.FlavorNotes.Size = new System.Drawing.Size(96, 39);
            this.FlavorNotes.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(323, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 27);
            this.label9.TabIndex = 33;
            this.label9.Text = "口感";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(35, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 27);
            this.label10.TabIndex = 31;
            this.label10.Text = "酸度等级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(772, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "香气强度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(278, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 27;
            this.label4.Text = "品鉴时间";
            // 
            // TastingDate
            // 
            this.TastingDate.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TastingDate.Location = new System.Drawing.Point(392, 169);
            this.TastingDate.Name = "TastingDate";
            this.TastingDate.Size = new System.Drawing.Size(350, 39);
            this.TastingDate.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(56, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "咖啡ID";
            // 
            // CoffeeID
            // 
            this.CoffeeID.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CoffeeID.Location = new System.Drawing.Point(149, 169);
            this.CoffeeID.Name = "CoffeeID";
            this.CoffeeID.Size = new System.Drawing.Size(96, 39);
            this.CoffeeID.TabIndex = 24;
            this.CoffeeID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("华文中宋", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.coffeeIDDataGridViewTextBoxColumn,
            this.tastingDateDataGridViewTextBoxColumn,
            this.aromaIntensityDataGridViewTextBoxColumn,
            this.acidityLevelDataGridViewTextBoxColumn,
            this.bodyFeelDataGridViewTextBoxColumn,
            this.flavorNotesDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tASTINGRECORDBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.Location = new System.Drawing.Point(3, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 444);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "记录ID";
            this.recordIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coffeeIDDataGridViewTextBoxColumn
            // 
            this.coffeeIDDataGridViewTextBoxColumn.DataPropertyName = "CoffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.HeaderText = "咖啡ID";
            this.coffeeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coffeeIDDataGridViewTextBoxColumn.Name = "coffeeIDDataGridViewTextBoxColumn";
            this.coffeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tastingDateDataGridViewTextBoxColumn
            // 
            this.tastingDateDataGridViewTextBoxColumn.DataPropertyName = "TastingDate";
            this.tastingDateDataGridViewTextBoxColumn.HeaderText = "品鉴日期";
            this.tastingDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tastingDateDataGridViewTextBoxColumn.Name = "tastingDateDataGridViewTextBoxColumn";
            this.tastingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aromaIntensityDataGridViewTextBoxColumn
            // 
            this.aromaIntensityDataGridViewTextBoxColumn.DataPropertyName = "AromaIntensity";
            this.aromaIntensityDataGridViewTextBoxColumn.HeaderText = "香气强度";
            this.aromaIntensityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aromaIntensityDataGridViewTextBoxColumn.Name = "aromaIntensityDataGridViewTextBoxColumn";
            this.aromaIntensityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acidityLevelDataGridViewTextBoxColumn
            // 
            this.acidityLevelDataGridViewTextBoxColumn.DataPropertyName = "AcidityLevel";
            this.acidityLevelDataGridViewTextBoxColumn.HeaderText = "酸度";
            this.acidityLevelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.acidityLevelDataGridViewTextBoxColumn.Name = "acidityLevelDataGridViewTextBoxColumn";
            this.acidityLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bodyFeelDataGridViewTextBoxColumn
            // 
            this.bodyFeelDataGridViewTextBoxColumn.DataPropertyName = "BodyFeel";
            this.bodyFeelDataGridViewTextBoxColumn.HeaderText = "口感";
            this.bodyFeelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bodyFeelDataGridViewTextBoxColumn.Name = "bodyFeelDataGridViewTextBoxColumn";
            this.bodyFeelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flavorNotesDataGridViewTextBoxColumn
            // 
            this.flavorNotesDataGridViewTextBoxColumn.DataPropertyName = "FlavorNotes";
            this.flavorNotesDataGridViewTextBoxColumn.HeaderText = "风味描述";
            this.flavorNotesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.flavorNotesDataGridViewTextBoxColumn.Name = "flavorNotesDataGridViewTextBoxColumn";
            this.flavorNotesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "评分";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tASTINGRECORDBindingSource
            // 
            this.tASTINGRECORDBindingSource.DataMember = "TASTING_RECORD";
            this.tASTINGRECORDBindingSource.DataSource = this.coffeeSystemDataSet1;
            // 
            // coffeeSystemDataSet1
            // 
            this.coffeeSystemDataSet1.DataSetName = "CoffeeSystemDataSet1";
            this.coffeeSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(464, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 27);
            this.label8.TabIndex = 22;
            this.label8.Text = "全部信息";
            // 
            // SelectBtn
            // 
            this.SelectBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.SelectBtn.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectBtn.Location = new System.Drawing.Point(783, 339);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(166, 48);
            this.SelectBtn.TabIndex = 21;
            this.SelectBtn.Text = "查询";
            this.SelectBtn.UseVisualStyleBackColor = false;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.DeleteBtn.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBtn.Location = new System.Drawing.Point(562, 339);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(166, 48);
            this.DeleteBtn.TabIndex = 20;
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.UpdateBtn.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateBtn.Location = new System.Drawing.Point(331, 339);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(166, 48);
            this.UpdateBtn.TabIndex = 19;
            this.UpdateBtn.Text = "修改";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.InsertBtn.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InsertBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InsertBtn.Location = new System.Drawing.Point(100, 339);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(166, 48);
            this.InsertBtn.TabIndex = 18;
            this.InsertBtn.Text = "插入";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(992, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 45);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_316.Properties.Resources.java;
            this.pictureBox1.Location = new System.Drawing.Point(286, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("华文中宋", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.Location = new System.Drawing.Point(347, 69);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(374, 50);
            this.label.TabIndex = 0;
            this.label.Text = "咖啡品鉴记录系统";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("华文中宋", 16F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(87, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 89);
            this.button1.TabIndex = 11;
            this.button1.Text = "咖啡信息";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_316.Properties.Resources.leftside;
            this.pictureBox2.Location = new System.Drawing.Point(13, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 934);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // tASTING_RECORDTableAdapter
            // 
            this.tASTING_RECORDTableAdapter.ClearBeforeFill = true;
            // 
            // TastingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1446, 956);
            this.Controls.Add(this.StatisticsBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TastingRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TastingRecord";
            this.Load += new System.EventHandler(this.TastingRecord_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tASTINGRECORDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StatisticsBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FlavorNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TastingDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoffeeID;
        private System.Windows.Forms.ComboBox AromaIntensity;
        private System.Windows.Forms.ComboBox BodyFeel;
        private System.Windows.Forms.ComboBox AcidityLevel;
        private CoffeeSystemDataSet1 coffeeSystemDataSet1;
        private System.Windows.Forms.BindingSource tASTINGRECORDBindingSource;
        private CoffeeSystemDataSet1TableAdapters.TASTING_RECORDTableAdapter tASTING_RECORDTableAdapter;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tastingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aromaIntensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acidityLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyFeelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flavorNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.Button NowBtn;
    }
}