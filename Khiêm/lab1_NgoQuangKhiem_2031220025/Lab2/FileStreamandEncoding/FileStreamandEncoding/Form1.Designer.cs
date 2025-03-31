namespace FileStreamandEncoding
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUnicode = new System.Windows.Forms.RadioButton();
            this.rbUTF8 = new System.Windows.Forms.RadioButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select an Encoding";
            // 
            // rbUnicode
            // 
            this.rbUnicode.AutoSize = true;
            this.rbUnicode.Location = new System.Drawing.Point(12, 101);
            this.rbUnicode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbUnicode.Name = "rbUnicode";
            this.rbUnicode.Size = new System.Drawing.Size(93, 24);
            this.rbUnicode.TabIndex = 8;
            this.rbUnicode.TabStop = true;
            this.rbUnicode.Text = "Unicode";
            this.rbUnicode.UseVisualStyleBackColor = true;
            // 
            // rbUTF8
            // 
            this.rbUTF8.AutoSize = true;
            this.rbUTF8.Location = new System.Drawing.Point(12, 66);
            this.rbUTF8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbUTF8.Name = "rbUTF8";
            this.rbUTF8.Size = new System.Drawing.Size(74, 24);
            this.rbUTF8.TabIndex = 9;
            this.rbUTF8.TabStop = true;
            this.rbUTF8.Text = "UTF8";
            this.rbUTF8.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPath.Location = new System.Drawing.Point(13, 189);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(732, 26);
            this.txtPath.TabIndex = 7;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 238);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(224, 35);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read from a file";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(822, 189);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 35);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 521);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save content to a file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(13, 339);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(919, 144);
            this.txtContent.TabIndex = 13;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 597);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbUnicode);
            this.Controls.Add(this.rbUTF8);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "File Stream and Encoding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbUnicode;
        private System.Windows.Forms.RadioButton rbUTF8;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

