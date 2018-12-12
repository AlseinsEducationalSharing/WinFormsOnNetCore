namespace WinFormsTest1
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
            this.btnSay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSay
            // 
            this.btnSay.BackColor = System.Drawing.Color.Black;
            this.btnSay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSay.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSay.ForeColor = System.Drawing.Color.White;
            this.btnSay.Location = new System.Drawing.Point(191, 116);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(151, 50);
            this.btnSay.TabIndex = 0;
            this.btnSay.Text = "Say!";
            this.btnSay.UseVisualStyleBackColor = false;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 305);
            this.Controls.Add(this.btnSay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSay;
    }
}

