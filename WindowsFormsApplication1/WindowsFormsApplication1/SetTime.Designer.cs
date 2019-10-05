namespace WindowsFormsApplication1
{
    partial class SetTime
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
            this.timeNumber = new System.Windows.Forms.NumericUpDown();
            this.pickTimeLabel = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // timeNumber
            // 
            this.timeNumber.Location = new System.Drawing.Point(168, 195);
            this.timeNumber.Name = "timeNumber";
            this.timeNumber.Size = new System.Drawing.Size(115, 28);
            this.timeNumber.TabIndex = 0;
            // 
            // pickTimeLabel
            // 
            this.pickTimeLabel.AutoSize = true;
            this.pickTimeLabel.Location = new System.Drawing.Point(187, 146);
            this.pickTimeLabel.Name = "pickTimeLabel";
            this.pickTimeLabel.Size = new System.Drawing.Size(98, 18);
            this.pickTimeLabel.TabIndex = 1;
            this.pickTimeLabel.Text = "请选择时间";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.min.Location = new System.Drawing.Point(289, 195);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(68, 28);
            this.min.TabIndex = 2;
            this.min.Text = "分钟";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(122, 290);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(79, 32);
            this.ok.TabIndex = 3;
            this.ok.Text = "确认";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(267, 290);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(79, 32);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // SetTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 448);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.min);
            this.Controls.Add(this.pickTimeLabel);
            this.Controls.Add(this.timeNumber);
            this.Name = "SetTime";
            this.Text = "SetTime";
            ((System.ComponentModel.ISupportInitialize)(this.timeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown timeNumber;
        private System.Windows.Forms.Label pickTimeLabel;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}