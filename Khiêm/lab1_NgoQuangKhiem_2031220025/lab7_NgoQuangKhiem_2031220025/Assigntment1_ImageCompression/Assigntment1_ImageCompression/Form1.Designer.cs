namespace Assigntment1_ImageCompression
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
            this.txtPathFolder = new System.Windows.Forms.TextBox();
            this.lbImages = new System.Windows.Forms.ListBox();
            this.cbRatio = new System.Windows.Forms.ComboBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnCompress = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Folder / Images";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Images List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Compression Ratio (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prefix";
            // 
            // txtPathFolder
            // 
            this.txtPathFolder.Location = new System.Drawing.Point(40, 48);
            this.txtPathFolder.Name = "txtPathFolder";
            this.txtPathFolder.Size = new System.Drawing.Size(430, 26);
            this.txtPathFolder.TabIndex = 1;
            // 
            // lbImages
            // 
            this.lbImages.FormattingEnabled = true;
            this.lbImages.ItemHeight = 20;
            this.lbImages.Location = new System.Drawing.Point(40, 113);
            this.lbImages.Name = "lbImages";
            this.lbImages.Size = new System.Drawing.Size(724, 204);
            this.lbImages.TabIndex = 2;
            // 
            // cbRatio
            // 
            this.cbRatio.FormattingEnabled = true;
            this.cbRatio.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.cbRatio.Location = new System.Drawing.Point(46, 378);
            this.cbRatio.Name = "cbRatio";
            this.cbRatio.Size = new System.Drawing.Size(81, 28);
            this.cbRatio.TabIndex = 3;
            this.cbRatio.Text = "80";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(297, 380);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(173, 26);
            this.txtPrefix.TabIndex = 4;
            this.txtPrefix.Text = "Compressed_";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(511, 48);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(124, 35);
            this.btnSelectFolder.TabIndex = 5;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(661, 48);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(103, 35);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Tag = "";
            this.btnSelectFile.Text = "Select Files";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(555, 356);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(143, 50);
            this.btnCompress.TabIndex = 7;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCompress);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.cbRatio);
            this.Controls.Add(this.lbImages);
            this.Controls.Add(this.txtPathFolder);
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
        private System.Windows.Forms.TextBox txtPathFolder;
        private System.Windows.Forms.ListBox lbImages;
        private System.Windows.Forms.ComboBox cbRatio;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

