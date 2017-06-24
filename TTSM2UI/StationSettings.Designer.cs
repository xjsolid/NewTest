namespace TTSM2.UI
{
    partial class StationSettings
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Comport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ConnectType = new System.Windows.Forms.ComboBox();
            this.textBox_InstrAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PSAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_RFLossConfig = new System.Windows.Forms.DataGridView();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.Column_BandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ULLossMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DLLossMain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ULLossDiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DLLossDiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RFLossConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "串口号:";
            // 
            // textBox_Comport
            // 
            this.textBox_Comport.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Comport.Location = new System.Drawing.Point(111, 12);
            this.textBox_Comport.Name = "textBox_Comport";
            this.textBox_Comport.Size = new System.Drawing.Size(120, 33);
            this.textBox_Comport.TabIndex = 4;
            this.textBox_Comport.TextChanged += new System.EventHandler(this.textBox_Comport_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "仪表连接类型:";
            // 
            // comboBox_ConnectType
            // 
            this.comboBox_ConnectType.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ConnectType.FormattingEnabled = true;
            this.comboBox_ConnectType.Items.AddRange(new object[] {
            "GPIB",
            "IP"});
            this.comboBox_ConnectType.Location = new System.Drawing.Point(149, 51);
            this.comboBox_ConnectType.Name = "comboBox_ConnectType";
            this.comboBox_ConnectType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_ConnectType.Size = new System.Drawing.Size(82, 33);
            this.comboBox_ConnectType.TabIndex = 6;
            this.comboBox_ConnectType.Text = "GPIB";
            this.comboBox_ConnectType.SelectedValueChanged += new System.EventHandler(this.comboBox_ConnectType_SelectedValueChanged);
            // 
            // textBox_InstrAddr
            // 
            this.textBox_InstrAddr.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_InstrAddr.Location = new System.Drawing.Point(352, 51);
            this.textBox_InstrAddr.Name = "textBox_InstrAddr";
            this.textBox_InstrAddr.Size = new System.Drawing.Size(127, 33);
            this.textBox_InstrAddr.TabIndex = 7;
            this.textBox_InstrAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_InstrAddr.TextChanged += new System.EventHandler(this.textBox_InstrAddr_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(253, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "电源地址:";
            // 
            // textBox_PSAddr
            // 
            this.textBox_PSAddr.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_PSAddr.Location = new System.Drawing.Point(352, 12);
            this.textBox_PSAddr.Name = "textBox_PSAddr";
            this.textBox_PSAddr.Size = new System.Drawing.Size(127, 33);
            this.textBox_PSAddr.TabIndex = 9;
            this.textBox_PSAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_PSAddr.TextChanged += new System.EventHandler(this.textBox_PSAddr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(253, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "仪表地址:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_RFLossConfig);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(17, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 573);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "线损配置";
            // 
            // dataGridView_RFLossConfig
            // 
            this.dataGridView_RFLossConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RFLossConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_BandName,
            this.Column_Channel,
            this.Column_ULLossMain,
            this.Column_DLLossMain,
            this.Column_ULLossDiv,
            this.Column_DLLossDiv});
            this.dataGridView_RFLossConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RFLossConfig.Location = new System.Drawing.Point(3, 25);
            this.dataGridView_RFLossConfig.Name = "dataGridView_RFLossConfig";
            this.dataGridView_RFLossConfig.RowTemplate.Height = 23;
            this.dataGridView_RFLossConfig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_RFLossConfig.Size = new System.Drawing.Size(822, 545);
            this.dataGridView_RFLossConfig.TabIndex = 0;
            this.dataGridView_RFLossConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RFLossConfig_CellClick);
            this.dataGridView_RFLossConfig.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RFLossConfig_CellValueChanged);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Confirm.Location = new System.Drawing.Point(609, 688);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(112, 34);
            this.button_Confirm.TabIndex = 12;
            this.button_Confirm.Text = "确定";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cancel.Location = new System.Drawing.Point(727, 688);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(112, 34);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Column_BandName
            // 
            this.Column_BandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_BandName.HeaderText = "频段";
            this.Column_BandName.Name = "Column_BandName";
            this.Column_BandName.ReadOnly = true;
            this.Column_BandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Channel
            // 
            this.Column_Channel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Channel.HeaderText = "信道";
            this.Column_Channel.Name = "Column_Channel";
            this.Column_Channel.ReadOnly = true;
            this.Column_Channel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_ULLossMain
            // 
            this.Column_ULLossMain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ULLossMain.HeaderText = "上行线损";
            this.Column_ULLossMain.Name = "Column_ULLossMain";
            this.Column_ULLossMain.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_DLLossMain
            // 
            this.Column_DLLossMain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_DLLossMain.HeaderText = "下行线损";
            this.Column_DLLossMain.Name = "Column_DLLossMain";
            this.Column_DLLossMain.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_ULLossDiv
            // 
            this.Column_ULLossDiv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_ULLossDiv.HeaderText = "上行线损DIV";
            this.Column_ULLossDiv.Name = "Column_ULLossDiv";
            this.Column_ULLossDiv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_DLLossDiv
            // 
            this.Column_DLLossDiv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_DLLossDiv.HeaderText = "下行线损DIV";
            this.Column_DLLossDiv.Name = "Column_DLLossDiv";
            this.Column_DLLossDiv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StationSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 736);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_PSAddr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_InstrAddr);
            this.Controls.Add(this.comboBox_ConnectType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Comport);
            this.Controls.Add(this.label2);
            this.Name = "StationSettings";
            this.Text = "StationSettings";
            this.Shown += new System.EventHandler(this.StationSettings_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RFLossConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Comport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ConnectType;
        private System.Windows.Forms.TextBox textBox_InstrAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PSAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.DataGridView dataGridView_RFLossConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_BandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ULLossMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DLLossMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ULLossDiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DLLossDiv;
    }
}