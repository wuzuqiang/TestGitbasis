﻿namespace ClassLibrary1
{
    partial class FrmOperFile
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtFiles = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileNameNeedContain = new System.Windows.Forms.TextBox();
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtBrand1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择文件夹";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(196, 42);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(459, 25);
            this.txtFolder.TabIndex = 1;
            // 
            // txtFiles
            // 
            this.txtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiles.Location = new System.Drawing.Point(51, 104);
            this.txtFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(1464, 457);
            this.txtFiles.TabIndex = 2;
            this.txtFiles.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "目录下文件：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件名要包含：";
            // 
            // txtFileNameNeedContain
            // 
            this.txtFileNameNeedContain.Location = new System.Drawing.Point(834, 41);
            this.txtFileNameNeedContain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileNameNeedContain.Name = "txtFileNameNeedContain";
            this.txtFileNameNeedContain.Size = new System.Drawing.Size(148, 25);
            this.txtFileNameNeedContain.TabIndex = 5;
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Location = new System.Drawing.Point(1262, 29);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(108, 39);
            this.btnCopyFile.TabIndex = 6;
            this.btnCopyFile.Text = "转为模板文件";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1394, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "打开复制文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(1118, 13);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 25);
            this.txtProduct.TabIndex = 8;
            this.txtProduct.Text = "Product";
            // 
            // txtBrand1
            // 
            this.txtBrand1.Location = new System.Drawing.Point(1118, 49);
            this.txtBrand1.Name = "txtBrand1";
            this.txtBrand1.Size = new System.Drawing.Size(100, 25);
            this.txtBrand1.TabIndex = 9;
            this.txtBrand1.Text = "Brand1";
            // 
            // FrmOperFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 576);
            this.Controls.Add(this.txtBrand1);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCopyFile);
            this.Controls.Add(this.txtFileNameNeedContain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmOperFile";
            this.Text = "FrmOperFile";
            this.Load += new System.EventHandler(this.FrmOperFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.RichTextBox txtFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileNameNeedContain;
        private System.Windows.Forms.Button btnCopyFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtBrand1;
    }
}