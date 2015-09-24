namespace GSAL4Test
{
    partial class ReSampleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReSampleForm));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ImageOutPath = new System.Windows.Forms.TextBox();
            this.btn_ImageOutPath = new System.Windows.Forms.Button();
            this.txt_ImageInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_InPutFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_OpenOutPut = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(25, 233);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(312, 23);
            this.progressBar.TabIndex = 37;
            this.progressBar.Visible = false;
            // 
            // txt_Y
            // 
            this.txt_Y.Location = new System.Drawing.Point(431, 75);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(109, 21);
            this.txt_Y.TabIndex = 35;
            // 
            // txt_X
            // 
            this.txt_X.Location = new System.Drawing.Point(117, 75);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(109, 21);
            this.txt_X.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(419, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "X、Y方向采样比，例如输入2，代表图像变大2倍，输入0.5，代表图像缩小一倍";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "输出Y采样比：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "输入X采样比：";
            // 
            // txt_ImageOutPath
            // 
            this.txt_ImageOutPath.Enabled = false;
            this.txt_ImageOutPath.Location = new System.Drawing.Point(25, 174);
            this.txt_ImageOutPath.Name = "txt_ImageOutPath";
            this.txt_ImageOutPath.Size = new System.Drawing.Size(634, 21);
            this.txt_ImageOutPath.TabIndex = 28;
            // 
            // btn_ImageOutPath
            // 
            this.btn_ImageOutPath.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImageOutPath.Image")));
            this.btn_ImageOutPath.Location = new System.Drawing.Point(665, 174);
            this.btn_ImageOutPath.Name = "btn_ImageOutPath";
            this.btn_ImageOutPath.Size = new System.Drawing.Size(26, 24);
            this.btn_ImageOutPath.TabIndex = 30;
            this.btn_ImageOutPath.UseVisualStyleBackColor = true;
            this.btn_ImageOutPath.Click += new System.EventHandler(this.btn_ImageOutPath_Click);
            // 
            // txt_ImageInput
            // 
            this.txt_ImageInput.Location = new System.Drawing.Point(25, 38);
            this.txt_ImageInput.Name = "txt_ImageInput";
            this.txt_ImageInput.Size = new System.Drawing.Size(634, 21);
            this.txt_ImageInput.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "输出文件夹";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_InPutFile
            // 
            this.btn_InPutFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_InPutFile.Image")));
            this.btn_InPutFile.Location = new System.Drawing.Point(665, 38);
            this.btn_InPutFile.Name = "btn_InPutFile";
            this.btn_InPutFile.Size = new System.Drawing.Size(26, 24);
            this.btn_InPutFile.TabIndex = 31;
            this.btn_InPutFile.UseVisualStyleBackColor = true;
            this.btn_InPutFile.Click += new System.EventHandler(this.btn_InPutFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "输入影像路径";
            // 
            // btn_OpenOutPut
            // 
            this.btn_OpenOutPut.Location = new System.Drawing.Point(545, 233);
            this.btn_OpenOutPut.Name = "btn_OpenOutPut";
            this.btn_OpenOutPut.Size = new System.Drawing.Size(115, 23);
            this.btn_OpenOutPut.TabIndex = 25;
            this.btn_OpenOutPut.Text = "打开输出文件夹";
            this.btn_OpenOutPut.UseVisualStyleBackColor = true;
            this.btn_OpenOutPut.Visible = false;
            this.btn_OpenOutPut.Click += new System.EventHandler(this.btn_OpenOutPut_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(459, 233);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 23;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(367, 233);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 24;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ReSampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 282);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txt_Y);
            this.Controls.Add(this.txt_X);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ImageOutPath);
            this.Controls.Add(this.btn_ImageOutPath);
            this.Controls.Add(this.txt_ImageInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_InPutFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OpenOutPut);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_ok);
            this.Name = "ReSampleForm";
            this.Text = "重采样";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ImageOutPath;
        private System.Windows.Forms.Button btn_ImageOutPath;
        private System.Windows.Forms.TextBox txt_ImageInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_InPutFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OpenOutPut;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_ok;
    }
}