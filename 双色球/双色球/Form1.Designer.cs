namespace 双色球
{
    partial class Form1
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Begin = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.labRed1 = new System.Windows.Forms.Label();
            this.labRed2 = new System.Windows.Forms.Label();
            this.labRed3 = new System.Windows.Forms.Label();
            this.labRed4 = new System.Windows.Forms.Label();
            this.labRed5 = new System.Windows.Forms.Label();
            this.labRed6 = new System.Windows.Forms.Label();
            this.labBlue = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labBlue);
            this.groupBox.Controls.Add(this.labRed6);
            this.groupBox.Controls.Add(this.labRed5);
            this.groupBox.Controls.Add(this.labRed4);
            this.groupBox.Controls.Add(this.labRed3);
            this.groupBox.Controls.Add(this.labRed2);
            this.groupBox.Controls.Add(this.labRed1);
            this.groupBox.Location = new System.Drawing.Point(13, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(416, 188);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "结果";
            // 
            // Begin
            // 
            this.Begin.Location = new System.Drawing.Point(85, 225);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(75, 23);
            this.Begin.TabIndex = 1;
            this.Begin.Text = "开始";
            this.Begin.UseVisualStyleBackColor = true;
            this.Begin.Click += new System.EventHandler(this.Begin_Click);
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(235, 225);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(75, 23);
            this.End.TabIndex = 2;
            this.End.Text = "结束";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // labRed1
            // 
            this.labRed1.AutoSize = true;
            this.labRed1.ForeColor = System.Drawing.Color.Crimson;
            this.labRed1.Location = new System.Drawing.Point(7, 79);
            this.labRed1.Name = "labRed1";
            this.labRed1.Size = new System.Drawing.Size(17, 12);
            this.labRed1.TabIndex = 0;
            this.labRed1.Text = "00";
            // 
            // labRed2
            // 
            this.labRed2.AutoSize = true;
            this.labRed2.ForeColor = System.Drawing.Color.Crimson;
            this.labRed2.Location = new System.Drawing.Point(61, 79);
            this.labRed2.Name = "labRed2";
            this.labRed2.Size = new System.Drawing.Size(17, 12);
            this.labRed2.TabIndex = 1;
            this.labRed2.Text = "00";
            // 
            // labRed3
            // 
            this.labRed3.AutoSize = true;
            this.labRed3.ForeColor = System.Drawing.Color.Crimson;
            this.labRed3.Location = new System.Drawing.Point(114, 79);
            this.labRed3.Name = "labRed3";
            this.labRed3.Size = new System.Drawing.Size(17, 12);
            this.labRed3.TabIndex = 2;
            this.labRed3.Text = "00";
            // 
            // labRed4
            // 
            this.labRed4.AutoSize = true;
            this.labRed4.ForeColor = System.Drawing.Color.Crimson;
            this.labRed4.Location = new System.Drawing.Point(160, 79);
            this.labRed4.Name = "labRed4";
            this.labRed4.Size = new System.Drawing.Size(17, 12);
            this.labRed4.TabIndex = 3;
            this.labRed4.Text = "00";
            // 
            // labRed5
            // 
            this.labRed5.AutoSize = true;
            this.labRed5.ForeColor = System.Drawing.Color.Crimson;
            this.labRed5.Location = new System.Drawing.Point(211, 79);
            this.labRed5.Name = "labRed5";
            this.labRed5.Size = new System.Drawing.Size(17, 12);
            this.labRed5.TabIndex = 4;
            this.labRed5.Text = "00";
            // 
            // labRed6
            // 
            this.labRed6.AutoSize = true;
            this.labRed6.ForeColor = System.Drawing.Color.Crimson;
            this.labRed6.Location = new System.Drawing.Point(265, 79);
            this.labRed6.Name = "labRed6";
            this.labRed6.Size = new System.Drawing.Size(17, 12);
            this.labRed6.TabIndex = 5;
            this.labRed6.Text = "00";
            // 
            // labBlue
            // 
            this.labBlue.AutoSize = true;
            this.labBlue.ForeColor = System.Drawing.Color.Blue;
            this.labBlue.Location = new System.Drawing.Point(359, 79);
            this.labBlue.Name = "labBlue";
            this.labBlue.Size = new System.Drawing.Size(17, 12);
            this.labBlue.TabIndex = 6;
            this.labBlue.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 260);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.groupBox);
            this.Name = "Form1";
            this.Text = "双色球";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button Begin;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.Label labBlue;
        private System.Windows.Forms.Label labRed6;
        private System.Windows.Forms.Label labRed5;
        private System.Windows.Forms.Label labRed4;
        private System.Windows.Forms.Label labRed3;
        private System.Windows.Forms.Label labRed2;
        private System.Windows.Forms.Label labRed1;
    }
}

