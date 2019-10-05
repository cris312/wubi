namespace WindowsFormsApplication1
{
    partial class Record
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
            this.gradeRecord = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // gradeRecord
            // 
            this.gradeRecord.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gradeRecord.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gradeRecord.FormattingEnabled = true;
            this.gradeRecord.ItemHeight = 28;
            this.gradeRecord.Location = new System.Drawing.Point(74, 45);
            this.gradeRecord.Name = "gradeRecord";
            this.gradeRecord.ScrollAlwaysVisible = true;
            this.gradeRecord.Size = new System.Drawing.Size(836, 816);
            this.gradeRecord.TabIndex = 0;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(989, 903);
            this.Controls.Add(this.gradeRecord);
            this.Name = "Record";
            this.Text = "record";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox gradeRecord;
    }
}