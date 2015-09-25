namespace GSAL4Test
{
    partial class VICalculationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VICalculationForm));
            this.cbx_VIType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewImage = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_ImageOutPath = new System.Windows.Forms.TextBox();
            this.btn_ImageOutPath = new System.Windows.Forms.Button();
            this.txt_ImageInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_InPutFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btn_OpenOutPut = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_VIType
            // 
            this.cbx_VIType.FormattingEnabled = true;
            this.cbx_VIType.Location = new System.Drawing.Point(492, 349);
            this.cbx_VIType.Name = "cbx_VIType";
            this.cbx_VIType.Size = new System.Drawing.Size(201, 20);
            this.cbx_VIType.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "指标类型：";
            // 
            // listViewImage
            // 
            this.listViewImage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewImage.FullRowSelect = true;
            this.listViewImage.GridLines = true;
            this.listViewImage.Location = new System.Drawing.Point(31, 63);
            this.listViewImage.Name = "listViewImage";
            this.listViewImage.Size = new System.Drawing.Size(634, 215);
            this.listViewImage.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewImage.TabIndex = 16;
            this.listViewImage.UseCompatibleStateImageBehavior = false;
            this.listViewImage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "                                                已添加文件";
            this.columnHeader1.Width = 634;
            // 
            // txt_ImageOutPath
            // 
            this.txt_ImageOutPath.Location = new System.Drawing.Point(31, 303);
            this.txt_ImageOutPath.Name = "txt_ImageOutPath";
            this.txt_ImageOutPath.Size = new System.Drawing.Size(634, 21);
            this.txt_ImageOutPath.TabIndex = 11;
            // 
            // btn_ImageOutPath
            // 
            this.btn_ImageOutPath.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImageOutPath.Image")));
            this.btn_ImageOutPath.Location = new System.Drawing.Point(672, 301);
            this.btn_ImageOutPath.Name = "btn_ImageOutPath";
            this.btn_ImageOutPath.Size = new System.Drawing.Size(26, 24);
            this.btn_ImageOutPath.TabIndex = 13;
            this.btn_ImageOutPath.UseVisualStyleBackColor = true;
            this.btn_ImageOutPath.Click += new System.EventHandler(this.btn_ImageOutPath_Click);
            // 
            // txt_ImageInput
            // 
            this.txt_ImageInput.Location = new System.Drawing.Point(31, 36);
            this.txt_ImageInput.Name = "txt_ImageInput";
            this.txt_ImageInput.Size = new System.Drawing.Size(634, 21);
            this.txt_ImageInput.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "输出影像";
            // 
            // btn_delete
            // 
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.Location = new System.Drawing.Point(672, 62);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(26, 24);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_InPutFile
            // 
            this.btn_InPutFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_InPutFile.Image")));
            this.btn_InPutFile.Location = new System.Drawing.Point(672, 34);
            this.btn_InPutFile.Name = "btn_InPutFile";
            this.btn_InPutFile.Size = new System.Drawing.Size(26, 24);
            this.btn_InPutFile.TabIndex = 15;
            this.btn_InPutFile.UseVisualStyleBackColor = true;
            this.btn_InPutFile.Click += new System.EventHandler(this.btn_InPutFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "输入影像";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(28, 462);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(271, 23);
            this.progressBar.TabIndex = 22;
            this.progressBar.Visible = false;
            // 
            // btn_OpenOutPut
            // 
            this.btn_OpenOutPut.Location = new System.Drawing.Point(550, 462);
            this.btn_OpenOutPut.Name = "btn_OpenOutPut";
            this.btn_OpenOutPut.Size = new System.Drawing.Size(115, 23);
            this.btn_OpenOutPut.TabIndex = 21;
            this.btn_OpenOutPut.Text = "打开输出文件夹";
            this.btn_OpenOutPut.UseVisualStyleBackColor = true;
            this.btn_OpenOutPut.Visible = false;
            this.btn_OpenOutPut.Click += new System.EventHandler(this.btn_OpenOutPut_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(454, 462);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 19;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(348, 462);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 20;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // VICalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 513);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_OpenOutPut);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cbx_VIType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewImage);
            this.Controls.Add(this.txt_ImageOutPath);
            this.Controls.Add(this.btn_ImageOutPath);
            this.Controls.Add(this.txt_ImageInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_InPutFile);
            this.Controls.Add(this.label1);
            this.Name = "VICalculationForm";
            this.Text = "VICalculationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_VIType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewImage;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox txt_ImageOutPath;
        private System.Windows.Forms.Button btn_ImageOutPath;
        private System.Windows.Forms.TextBox txt_ImageInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_InPutFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btn_OpenOutPut;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_ok;
    }
}