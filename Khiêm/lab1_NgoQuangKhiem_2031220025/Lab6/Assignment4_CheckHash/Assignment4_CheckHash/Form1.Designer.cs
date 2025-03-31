namespace Assignment4_CheckHash
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnCompapre = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.txtCompareHash = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHA1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "MD5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Compare Hash";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(626, 52);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(109, 46);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnCompapre
            // 
            this.btnCompapre.Location = new System.Drawing.Point(626, 333);
            this.btnCompapre.Name = "btnCompapre";
            this.btnCompapre.Size = new System.Drawing.Size(109, 47);
            this.btnCompapre.TabIndex = 2;
            this.btnCompapre.Text = "Compare";
            this.btnCompapre.UseVisualStyleBackColor = true;
            this.btnCompapre.Click += new System.EventHandler(this.btnCompapre_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(16, 52);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(573, 61);
            this.txtPath.TabIndex = 3;
            // 
            // txtSHA1
            // 
            this.txtSHA1.Location = new System.Drawing.Point(16, 174);
            this.txtSHA1.Multiline = true;
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(317, 84);
            this.txtSHA1.TabIndex = 3;
            // 
            // txtMD5
            // 
            this.txtMD5.Location = new System.Drawing.Point(409, 174);
            this.txtMD5.Multiline = true;
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(326, 84);
            this.txtMD5.TabIndex = 3;
            // 
            // txtCompareHash
            // 
            this.txtCompareHash.Location = new System.Drawing.Point(16, 331);
            this.txtCompareHash.Multiline = true;
            this.txtCompareHash.Name = "txtCompareHash";
            this.txtCompareHash.Size = new System.Drawing.Size(587, 81);
            this.txtCompareHash.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCompareHash);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.txtSHA1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnCompapre);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnCompapre;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.TextBox txtCompareHash;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

