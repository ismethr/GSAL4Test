namespace GSAL4Test
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_clp = new System.Windows.Forms.Button();
            this.btn_resample = new System.Windows.Forms.Button();
            this.btn_VICalculation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 373);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "打开影像";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clp
            // 
            this.btn_clp.Location = new System.Drawing.Point(30, 22);
            this.btn_clp.Name = "btn_clp";
            this.btn_clp.Size = new System.Drawing.Size(75, 23);
            this.btn_clp.TabIndex = 2;
            this.btn_clp.Text = "栅格裁剪";
            this.btn_clp.UseVisualStyleBackColor = true;
            this.btn_clp.Click += new System.EventHandler(this.btn_clp_Click);
            // 
            // btn_resample
            // 
            this.btn_resample.Location = new System.Drawing.Point(127, 22);
            this.btn_resample.Name = "btn_resample";
            this.btn_resample.Size = new System.Drawing.Size(75, 23);
            this.btn_resample.TabIndex = 3;
            this.btn_resample.Text = "重采样";
            this.btn_resample.UseVisualStyleBackColor = true;
            this.btn_resample.Click += new System.EventHandler(this.btn_resample_Click);
            // 
            // btn_VICalculation
            // 
            this.btn_VICalculation.Location = new System.Drawing.Point(217, 22);
            this.btn_VICalculation.Name = "btn_VICalculation";
            this.btn_VICalculation.Size = new System.Drawing.Size(101, 23);
            this.btn_VICalculation.TabIndex = 4;
            this.btn_VICalculation.Text = "植被指数计算";
            this.btn_VICalculation.UseVisualStyleBackColor = true;
            this.btn_VICalculation.Click += new System.EventHandler(this.btn_VICalculation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 489);
            this.Controls.Add(this.btn_VICalculation);
            this.Controls.Add(this.btn_resample);
            this.Controls.Add(this.btn_clp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_clp;
        private System.Windows.Forms.Button btn_resample;
        private System.Windows.Forms.Button btn_VICalculation;
    }
}

