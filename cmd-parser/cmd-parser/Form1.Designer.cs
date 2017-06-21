namespace cmd_parser
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.btnParser = new System.Windows.Forms.Button();
            this.btnUnParser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTgt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始字符串";
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(103, 13);
            this.tbSrc.Multiline = true;
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(701, 165);
            this.tbSrc.TabIndex = 1;
            // 
            // btnParser
            // 
            this.btnParser.Location = new System.Drawing.Point(542, 189);
            this.btnParser.Name = "btnParser";
            this.btnParser.Size = new System.Drawing.Size(93, 36);
            this.btnParser.TabIndex = 2;
            this.btnParser.Text = "↓";
            this.btnParser.UseVisualStyleBackColor = true;
            this.btnParser.Click += new System.EventHandler(this.btnParser_Click);
            // 
            // btnUnParser
            // 
            this.btnUnParser.Location = new System.Drawing.Point(268, 189);
            this.btnUnParser.Name = "btnUnParser";
            this.btnUnParser.Size = new System.Drawing.Size(91, 36);
            this.btnUnParser.TabIndex = 3;
            this.btnUnParser.Text = "↑";
            this.btnUnParser.UseVisualStyleBackColor = true;
            this.btnUnParser.Click += new System.EventHandler(this.btnUnParser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "转义后字符串";
            // 
            // tbTgt
            // 
            this.tbTgt.Location = new System.Drawing.Point(103, 238);
            this.tbTgt.Multiline = true;
            this.tbTgt.Name = "tbTgt";
            this.tbTgt.Size = new System.Drawing.Size(701, 197);
            this.tbTgt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 448);
            this.Controls.Add(this.tbTgt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnParser);
            this.Controls.Add(this.btnParser);
            this.Controls.Add(this.tbSrc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "cmd-parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.Button btnParser;
        private System.Windows.Forms.Button btnUnParser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTgt;
    }
}

