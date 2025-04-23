namespace _316
{
    partial class CoffeeInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.RoastLevel = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coffeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varietyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roastLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roastDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOFFEEINFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeSystemDataSet = new _316.CoffeeSystemDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RoastDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Origin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Variety = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TastingBtn = new System.Windows.Forms.Button();
            this.StatisticsBtn = new System.Windows.Forms.Button();
            this.cOFFEE_INFOTableAdapter = new _316.CoffeeSystemDataSetTableAdapters.COFFEE_INFOTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NowBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFEEINFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.NowBtn);
            this.panel2.Controls.Add(this.refresh);
            this.panel2.Controls.Add(this.RoastLevel);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.ReadBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.InsertBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Notes);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.RoastDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Origin);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Variety);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(396, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 928);
            this.panel2.TabIndex = 4;
            // 
            // refresh
            // 
            this.refresh.Image = global::_316.Properties.Resources.refresh;
            this.refresh.Location = new System.Drawing.Point(983, 438);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(41, 40);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 25;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // RoastLevel
            // 
            this.RoastLevel.Font = new System.Drawing.Font("华文中宋", 12F);
            this.RoastLevel.FormattingEnabled = true;
            this.RoastLevel.Items.AddRange(new object[] {
            "浅度",
            "中度",
            "深度"});
            this.RoastLevel.Location = new System.Drawing.Point(469, 166);
            this.RoastLevel.Name = "RoastLevel";
            this.RoastLevel.Size = new System.Drawing.Size(194, 35);
            this.RoastLevel.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("华文中宋", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coffeeID,
            this.varietyDataGridViewTextBoxColumn,
            this.roastLevelDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.roastDateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOFFEEINFOBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.Location = new System.Drawing.Point(3, 481);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 444);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coffeeID
            // 
            this.coffeeID.DataPropertyName = "CoffeeID";
            this.coffeeID.HeaderText = "咖啡编号";
            this.coffeeID.MinimumWidth = 8;
            this.coffeeID.Name = "coffeeID";
            this.coffeeID.ReadOnly = true;
            // 
            // varietyDataGridViewTextBoxColumn
            // 
            this.varietyDataGridViewTextBoxColumn.DataPropertyName = "Variety";
            this.varietyDataGridViewTextBoxColumn.HeaderText = "品种";
            this.varietyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.varietyDataGridViewTextBoxColumn.Name = "varietyDataGridViewTextBoxColumn";
            this.varietyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roastLevelDataGridViewTextBoxColumn
            // 
            this.roastLevelDataGridViewTextBoxColumn.DataPropertyName = "RoastLevel";
            this.roastLevelDataGridViewTextBoxColumn.HeaderText = "烘焙程度";
            this.roastLevelDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roastLevelDataGridViewTextBoxColumn.Name = "roastLevelDataGridViewTextBoxColumn";
            this.roastLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "产地";
            this.originDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roastDateDataGridViewTextBoxColumn
            // 
            this.roastDateDataGridViewTextBoxColumn.DataPropertyName = "RoastDate";
            this.roastDateDataGridViewTextBoxColumn.HeaderText = "烘焙日期";
            this.roastDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roastDateDataGridViewTextBoxColumn.Name = "roastDateDataGridViewTextBoxColumn";
            this.roastDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "备注";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOFFEEINFOBindingSource
            // 
            this.cOFFEEINFOBindingSource.DataMember = "COFFEE_INFO";
            this.cOFFEEINFOBindingSource.DataSource = this.coffeeSystemDataSet;
            // 
            // coffeeSystemDataSet
            // 
            this.coffeeSystemDataSet.DataSetName = "CoffeeSystemDataSet";
            this.coffeeSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ReadBtn
            // 
            this.ReadBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.ReadBtn.Font = new System.Drawing.Font("华文中宋", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReadBtn.Location = new System.Drawing.Point(783, 339);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(166, 48);
            this.ReadBtn.TabIndex = 21;
            this.ReadBtn.Text = "查询";
            this.ReadBtn.UseVisualStyleBackColor = false;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(719, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "备注";
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Notes.Location = new System.Drawing.Point(785, 166);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(189, 39);
            this.Notes.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(360, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "烘焙日期";
            // 
            // RoastDate
            // 
            this.RoastDate.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RoastDate.ForeColor = System.Drawing.Color.Black;
            this.RoastDate.Location = new System.Drawing.Point(474, 240);
            this.RoastDate.Name = "RoastDate";
            this.RoastDate.Size = new System.Drawing.Size(254, 39);
            this.RoastDate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(83, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "产地";
            // 
            // Origin
            // 
            this.Origin.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Origin.Location = new System.Drawing.Point(149, 240);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(189, 39);
            this.Origin.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(360, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "烘焙程度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(83, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "品种";
            // 
            // Variety
            // 
            this.Variety.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Variety.Location = new System.Drawing.Point(149, 166);
            this.Variety.Name = "Variety";
            this.Variety.Size = new System.Drawing.Size(189, 39);
            this.Variety.TabIndex = 8;
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
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Font = new System.Drawing.Font("华文中宋", 16F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(86, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 83);
            this.button1.TabIndex = 6;
            this.button1.Text = "咖啡信息";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TastingBtn
            // 
            this.TastingBtn.BackColor = System.Drawing.Color.MistyRose;
            this.TastingBtn.Font = new System.Drawing.Font("华文中宋", 16F);
            this.TastingBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TastingBtn.Location = new System.Drawing.Point(86, 390);
            this.TastingBtn.Name = "TastingBtn";
            this.TastingBtn.Size = new System.Drawing.Size(240, 83);
            this.TastingBtn.TabIndex = 7;
            this.TastingBtn.Text = "品鉴记录";
            this.TastingBtn.UseVisualStyleBackColor = false;
            this.TastingBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // StatisticsBtn
            // 
            this.StatisticsBtn.BackColor = System.Drawing.Color.MistyRose;
            this.StatisticsBtn.Font = new System.Drawing.Font("华文中宋", 16F);
            this.StatisticsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatisticsBtn.Location = new System.Drawing.Point(86, 533);
            this.StatisticsBtn.Name = "StatisticsBtn";
            this.StatisticsBtn.Size = new System.Drawing.Size(240, 83);
            this.StatisticsBtn.TabIndex = 8;
            this.StatisticsBtn.Text = "统计";
            this.StatisticsBtn.UseVisualStyleBackColor = false;
            this.StatisticsBtn.Click += new System.EventHandler(this.StatisticsBtn_Click);
            // 
            // cOFFEE_INFOTableAdapter
            // 
            this.cOFFEE_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_316.Properties.Resources.leftside;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(378, 928);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // NowBtn
            // 
            this.NowBtn.Font = new System.Drawing.Font("华文中宋", 12F);
            this.NowBtn.Location = new System.Drawing.Point(646, 243);
            this.NowBtn.Name = "NowBtn";
            this.NowBtn.Size = new System.Drawing.Size(75, 36);
            this.NowBtn.TabIndex = 44;
            this.NowBtn.Text = "Now";
            this.NowBtn.UseVisualStyleBackColor = true;
            this.NowBtn.Click += new System.EventHandler(this.NowBtn_Click);
            // 
            // CoffeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(1446, 956);
            this.Controls.Add(this.StatisticsBtn);
            this.Controls.Add(this.TastingBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoffeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeInfo";
            this.Load += new System.EventHandler(this.CoffeeInfo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFEEINFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button TastingBtn;
        private System.Windows.Forms.Button StatisticsBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RoastDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Origin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Variety;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.ComboBox RoastLevel;
        private CoffeeSystemDataSet coffeeSystemDataSet;
        private System.Windows.Forms.BindingSource cOFFEEINFOBindingSource;
        private CoffeeSystemDataSetTableAdapters.COFFEE_INFOTableAdapter cOFFEE_INFOTableAdapter;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn varietyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roastLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roastDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button NowBtn;
    }
}