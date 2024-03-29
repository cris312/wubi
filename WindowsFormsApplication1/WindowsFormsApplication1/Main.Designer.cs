﻿namespace WindowsFormsApplication1
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.inputBox = new WindowsFormsApplication1.Main.MyTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.passage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.index = new System.Windows.Forms.Label();
            this.restTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.speedShow = new System.Windows.Forms.TextBox();
            this.accuracyShow = new System.Windows.Forms.TextBox();
            this.reviseShow = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.accLabel = new System.Windows.Forms.Label();
            this.reviseLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.startBt = new System.Windows.Forms.Button();
            this.countDownTime = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.processLabel = new System.Windows.Forms.Label();
            this.processBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputBox.Location = new System.Drawing.Point(29, 568);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(1200, 450);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(41, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.passage);
            this.splitContainer1.Panel1.Controls.Add(this.inputBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.speedChart);
            this.splitContainer1.Panel2.Controls.Add(this.index);
            this.splitContainer1.Panel2.Controls.Add(this.restTime);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.startBt);
            this.splitContainer1.Panel2.Controls.Add(this.countDownTime);
            this.splitContainer1.Size = new System.Drawing.Size(1806, 1055);
            this.splitContainer1.SplitterDistance = 1285;
            this.splitContainer1.TabIndex = 2;
            // 
            // passage
            // 
            this.passage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.passage.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passage.Location = new System.Drawing.Point(29, 63);
            this.passage.Multiline = true;
            this.passage.Name = "passage";
            this.passage.ReadOnly = true;
            this.passage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.passage.Size = new System.Drawing.Size(1200, 450);
            this.passage.TabIndex = 1;
            this.passage.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(204, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "实时速率";
            // 
            // speedChart
            // 
            chartArea5.Name = "ChartArea1";
            this.speedChart.ChartAreas.Add(chartArea5);
            this.speedChart.Location = new System.Drawing.Point(58, 391);
            this.speedChart.Name = "speedChart";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.speedChart.Series.Add(series5);
            this.speedChart.Size = new System.Drawing.Size(411, 300);
            this.speedChart.TabIndex = 10;
            this.speedChart.Text = "chart1";
            // 
            // index
            // 
            this.index.AutoSize = true;
            this.index.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.index.Location = new System.Drawing.Point(187, 21);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(127, 36);
            this.index.TabIndex = 9;
            this.index.Text = "实时指标";
            // 
            // restTime
            // 
            this.restTime.AutoSize = true;
            this.restTime.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restTime.Location = new System.Drawing.Point(207, 744);
            this.restTime.Name = "restTime";
            this.restTime.Size = new System.Drawing.Size(127, 36);
            this.restTime.TabIndex = 8;
            this.restTime.Text = "剩余时间";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.speedShow, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.accuracyShow, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.reviseShow, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.speedLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.accLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.reviseLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.processLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.processBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(58, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(411, 240);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // speedShow
            // 
            this.speedShow.Location = new System.Drawing.Point(126, 3);
            this.speedShow.Name = "speedShow";
            this.speedShow.ReadOnly = true;
            this.speedShow.Size = new System.Drawing.Size(213, 28);
            this.speedShow.TabIndex = 0;
            // 
            // accuracyShow
            // 
            this.accuracyShow.Location = new System.Drawing.Point(126, 66);
            this.accuracyShow.Name = "accuracyShow";
            this.accuracyShow.ReadOnly = true;
            this.accuracyShow.Size = new System.Drawing.Size(213, 28);
            this.accuracyShow.TabIndex = 1;
            // 
            // reviseShow
            // 
            this.reviseShow.Location = new System.Drawing.Point(126, 129);
            this.reviseShow.Name = "reviseShow";
            this.reviseShow.ReadOnly = true;
            this.reviseShow.Size = new System.Drawing.Size(213, 28);
            this.reviseShow.TabIndex = 2;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(3, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(44, 18);
            this.speedLabel.TabIndex = 3;
            this.speedLabel.Text = "速度";
            // 
            // accLabel
            // 
            this.accLabel.AutoSize = true;
            this.accLabel.Location = new System.Drawing.Point(3, 63);
            this.accLabel.Name = "accLabel";
            this.accLabel.Size = new System.Drawing.Size(62, 18);
            this.accLabel.TabIndex = 4;
            this.accLabel.Text = "准确率";
            // 
            // reviseLabel
            // 
            this.reviseLabel.AutoSize = true;
            this.reviseLabel.Location = new System.Drawing.Point(3, 126);
            this.reviseLabel.Name = "reviseLabel";
            this.reviseLabel.Size = new System.Drawing.Size(62, 18);
            this.reviseLabel.TabIndex = 5;
            this.reviseLabel.Text = "修改率";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(284, 933);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 59);
            this.button2.TabIndex = 5;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startBt
            // 
            this.startBt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startBt.Location = new System.Drawing.Point(128, 934);
            this.startBt.Name = "startBt";
            this.startBt.Size = new System.Drawing.Size(114, 59);
            this.startBt.TabIndex = 4;
            this.startBt.Text = "开始";
            this.startBt.UseVisualStyleBackColor = true;
            this.startBt.Click += new System.EventHandler(this.startBt_Click);
            // 
            // countDownTime
            // 
            this.countDownTime.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.countDownTime.Location = new System.Drawing.Point(79, 800);
            this.countDownTime.Name = "countDownTime";
            this.countDownTime.ReadOnly = true;
            this.countDownTime.Size = new System.Drawing.Size(390, 67);
            this.countDownTime.TabIndex = 3;
            this.countDownTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 39);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 35);
            this.toolStripMenuItem1.Text = "文件";
            // 
            // setItem
            // 
            this.setItem.Name = "setItem";
            this.setItem.Size = new System.Drawing.Size(184, 36);
            this.setItem.Text = "设置字体";
            this.setItem.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(184, 36);
            this.toolStripMenuItem5.Text = "退出";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripSeparator1,
            this.toolStripMenuItem7});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(74, 35);
            this.toolStripMenuItem2.Text = "测试";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(184, 36);
            this.toolStripMenuItem6.Text = "设置时间";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(184, 36);
            this.toolStripMenuItem7.Text = "选择试题";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(74, 35);
            this.toolStripMenuItem4.Text = "我的";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(136, 36);
            this.toolStripMenuItem3.Text = "成绩";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(3, 183);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(44, 18);
            this.processLabel.TabIndex = 6;
            this.processLabel.Text = "进度";
            // 
            // processBox
            // 
            this.processBox.Location = new System.Drawing.Point(126, 186);
            this.processBox.Name = "processBox";
            this.processBox.ReadOnly = true;
            this.processBox.Size = new System.Drawing.Size(214, 28);
            this.processBox.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1169);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "我爱五笔";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        class MyTextBox : System.Windows.Forms.TextBox
        {
            protected override void WndProc(ref System.Windows.Forms.Message m)
            {
                if (m.Msg != 0x007B && m.Msg != 0x0301 && m.Msg != 0x0302)
                {
                    base.WndProc(ref m);
                }
            }
        }
        private MyTextBox inputBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button startBt;
        private System.Windows.Forms.TextBox countDownTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox speedShow;
        private System.Windows.Forms.TextBox accuracyShow;
        private System.Windows.Forms.TextBox reviseShow;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label accLabel;
        private System.Windows.Forms.Label reviseLabel;
        private System.Windows.Forms.Label index;
        private System.Windows.Forms.Label restTime;
        private System.Windows.Forms.ToolStripMenuItem setItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart speedChart;
        public System.Windows.Forms.TextBox passage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.TextBox processBox;

    }
}

