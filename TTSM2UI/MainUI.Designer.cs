namespace TTSM2.UI
{
    partial class MainUI
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_LoadTestSequence = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.工序配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_StationConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DatabaseConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_DebugLog = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_PluginInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_TestSequence = new System.Windows.Forms.DataGridView();
            this.Column_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LowLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_HighLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TestValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TimeElapsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Version = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ProjectName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ResetCount = new System.Windows.Forms.Button();
            this.textBox_PassRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FailCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_PassCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SequenceFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_StationName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TestSequence)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工序配置ToolStripMenuItem,
            this.日志ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(870, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_LoadTestSequence,
            this.toolStripSeparator1,
            this.toolStripMenuItem_Exit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // toolStripMenuItem_LoadTestSequence
            // 
            this.toolStripMenuItem_LoadTestSequence.Name = "toolStripMenuItem_LoadTestSequence";
            this.toolStripMenuItem_LoadTestSequence.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem_LoadTestSequence.Text = "加载测试序列";
            this.toolStripMenuItem_LoadTestSequence.Click += new System.EventHandler(this.toolStripMenuItem_LoadTestSequence_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem_Exit.Text = "退出";
            // 
            // 工序配置ToolStripMenuItem
            // 
            this.工序配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_StationConfig,
            this.toolStripMenuItem_DatabaseConfig});
            this.工序配置ToolStripMenuItem.Name = "工序配置ToolStripMenuItem";
            this.工序配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.工序配置ToolStripMenuItem.Text = "工序配置";
            // 
            // toolStripMenuItem_StationConfig
            // 
            this.toolStripMenuItem_StationConfig.Name = "toolStripMenuItem_StationConfig";
            this.toolStripMenuItem_StationConfig.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem_StationConfig.Text = "工站配置";
            this.toolStripMenuItem_StationConfig.Click += new System.EventHandler(this.toolStripMenuItem_StationConfig_Click);
            // 
            // toolStripMenuItem_DatabaseConfig
            // 
            this.toolStripMenuItem_DatabaseConfig.Name = "toolStripMenuItem_DatabaseConfig";
            this.toolStripMenuItem_DatabaseConfig.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem_DatabaseConfig.Text = "数据库配置";
            // 
            // 日志ToolStripMenuItem
            // 
            this.日志ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_DebugLog});
            this.日志ToolStripMenuItem.Name = "日志ToolStripMenuItem";
            this.日志ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.日志ToolStripMenuItem.Text = "日志";
            // 
            // toolStripMenuItem_DebugLog
            // 
            this.toolStripMenuItem_DebugLog.Name = "toolStripMenuItem_DebugLog";
            this.toolStripMenuItem_DebugLog.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem_DebugLog.Text = "调试日志";
            this.toolStripMenuItem_DebugLog.Click += new System.EventHandler(this.toolStripMenuItem_DebugLog_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_PluginInfo});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // toolStripMenuItem_PluginInfo
            // 
            this.toolStripMenuItem_PluginInfo.Name = "toolStripMenuItem_PluginInfo";
            this.toolStripMenuItem_PluginInfo.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem_PluginInfo.Text = "插件信息";
            // 
            // dataGridView_TestSequence
            // 
            this.dataGridView_TestSequence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_TestSequence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TestSequence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Index,
            this.Column_TestName,
            this.Column_LowLimit,
            this.Column_HighLimit,
            this.Column_TestValue,
            this.Column_Status,
            this.Column_TimeElapsed});
            this.dataGridView_TestSequence.Location = new System.Drawing.Point(6, 177);
            this.dataGridView_TestSequence.Name = "dataGridView_TestSequence";
            this.dataGridView_TestSequence.RowTemplate.Height = 23;
            this.dataGridView_TestSequence.Size = new System.Drawing.Size(824, 426);
            this.dataGridView_TestSequence.TabIndex = 2;
            // 
            // Column_Index
            // 
            this.Column_Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Index.HeaderText = "序号";
            this.Column_Index.Name = "Column_Index";
            this.Column_Index.ReadOnly = true;
            this.Column_Index.Width = 75;
            // 
            // Column_TestName
            // 
            this.Column_TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_TestName.HeaderText = "测试项";
            this.Column_TestName.MinimumWidth = 50;
            this.Column_TestName.Name = "Column_TestName";
            this.Column_TestName.ReadOnly = true;
            // 
            // Column_LowLimit
            // 
            this.Column_LowLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_LowLimit.HeaderText = "下限";
            this.Column_LowLimit.Name = "Column_LowLimit";
            this.Column_LowLimit.ReadOnly = true;
            this.Column_LowLimit.Width = 75;
            // 
            // Column_HighLimit
            // 
            this.Column_HighLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_HighLimit.HeaderText = "上限";
            this.Column_HighLimit.Name = "Column_HighLimit";
            this.Column_HighLimit.ReadOnly = true;
            this.Column_HighLimit.Width = 75;
            // 
            // Column_TestValue
            // 
            this.Column_TestValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_TestValue.HeaderText = "结果";
            this.Column_TestValue.Name = "Column_TestValue";
            this.Column_TestValue.ReadOnly = true;
            this.Column_TestValue.Width = 75;
            // 
            // Column_Status
            // 
            this.Column_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_Status.HeaderText = "状态";
            this.Column_Status.Name = "Column_Status";
            this.Column_Status.ReadOnly = true;
            this.Column_Status.Width = 75;
            // 
            // Column_TimeElapsed
            // 
            this.Column_TimeElapsed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_TimeElapsed.HeaderText = "耗时(s)";
            this.Column_TimeElapsed.Name = "Column_TimeElapsed";
            this.Column_TimeElapsed.ReadOnly = true;
            this.Column_TimeElapsed.Width = 96;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Version);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_ProjectName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_ResetCount);
            this.groupBox1.Controls.Add(this.textBox_PassRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_FailCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_PassCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_SequenceFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_StationName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工序信息";
            // 
            // textBox_Version
            // 
            this.textBox_Version.Enabled = false;
            this.textBox_Version.Location = new System.Drawing.Point(552, 34);
            this.textBox_Version.Name = "textBox_Version";
            this.textBox_Version.ReadOnly = true;
            this.textBox_Version.Size = new System.Drawing.Size(278, 33);
            this.textBox_Version.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "版本号:";
            // 
            // textBox_ProjectName
            // 
            this.textBox_ProjectName.Enabled = false;
            this.textBox_ProjectName.Location = new System.Drawing.Point(112, 34);
            this.textBox_ProjectName.Name = "textBox_ProjectName";
            this.textBox_ProjectName.ReadOnly = true;
            this.textBox_ProjectName.Size = new System.Drawing.Size(299, 33);
            this.textBox_ProjectName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "项目:";
            // 
            // button_ResetCount
            // 
            this.button_ResetCount.Location = new System.Drawing.Point(718, 120);
            this.button_ResetCount.Name = "button_ResetCount";
            this.button_ResetCount.Size = new System.Drawing.Size(112, 34);
            this.button_ResetCount.TabIndex = 10;
            this.button_ResetCount.Text = "重置计数";
            this.button_ResetCount.UseVisualStyleBackColor = true;
            // 
            // textBox_PassRate
            // 
            this.textBox_PassRate.Enabled = false;
            this.textBox_PassRate.Location = new System.Drawing.Point(590, 121);
            this.textBox_PassRate.Name = "textBox_PassRate";
            this.textBox_PassRate.ReadOnly = true;
            this.textBox_PassRate.Size = new System.Drawing.Size(79, 33);
            this.textBox_PassRate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "当前直通率:";
            // 
            // textBox_FailCount
            // 
            this.textBox_FailCount.Enabled = false;
            this.textBox_FailCount.Location = new System.Drawing.Point(751, 78);
            this.textBox_FailCount.Name = "textBox_FailCount";
            this.textBox_FailCount.ReadOnly = true;
            this.textBox_FailCount.Size = new System.Drawing.Size(79, 33);
            this.textBox_FailCount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "失败数:";
            // 
            // textBox_PassCount
            // 
            this.textBox_PassCount.Enabled = false;
            this.textBox_PassCount.Location = new System.Drawing.Point(552, 78);
            this.textBox_PassCount.Name = "textBox_PassCount";
            this.textBox_PassCount.ReadOnly = true;
            this.textBox_PassCount.Size = new System.Drawing.Size(79, 33);
            this.textBox_PassCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "通过数:";
            // 
            // textBox_SequenceFile
            // 
            this.textBox_SequenceFile.Enabled = false;
            this.textBox_SequenceFile.Location = new System.Drawing.Point(112, 118);
            this.textBox_SequenceFile.Name = "textBox_SequenceFile";
            this.textBox_SequenceFile.ReadOnly = true;
            this.textBox_SequenceFile.Size = new System.Drawing.Size(299, 33);
            this.textBox_SequenceFile.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "序列文件:";
            // 
            // textBox_StationName
            // 
            this.textBox_StationName.Enabled = false;
            this.textBox_StationName.Location = new System.Drawing.Point(112, 75);
            this.textBox_StationName.Name = "textBox_StationName";
            this.textBox_StationName.ReadOnly = true;
            this.textBox_StationName.Size = new System.Drawing.Size(299, 33);
            this.textBox_StationName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "测试站名:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 148);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(824, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Status.Location = new System.Drawing.Point(6, 88);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(824, 54);
            this.textBox_Status.TabIndex = 5;
            this.textBox_Status.Text = "IDLE";
            this.textBox_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Start);
            this.groupBox2.Controls.Add(this.textBox_Status);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.dataGridView_TestSequence);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 609);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试状态";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(18, 32);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(88, 38);
            this.button_Start.TabIndex = 6;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 821);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestBench";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TestSequence)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_LoadTestSequence;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem 工序配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_StationConfig;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DatabaseConfig;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_PluginInfo;
        private System.Windows.Forms.DataGridView dataGridView_TestSequence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ResetCount;
        private System.Windows.Forms.TextBox textBox_PassRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_FailCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_PassCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SequenceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_StationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LowLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_HighLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TestValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TimeElapsed;
        private System.Windows.Forms.ToolStripMenuItem 日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_DebugLog;
        private System.Windows.Forms.TextBox textBox_Version;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ProjectName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Start;
    }
}

