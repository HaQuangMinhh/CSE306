﻿namespace FileStreamAndEncoding2
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.rbUTF8 = new System.Windows.Forms.RadioButton();
            this.rbUnicode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(867, 263);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(112, 35);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(58, 325);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(224, 35);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read from a file";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFilePath.Location = new System.Drawing.Point(58, 263);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(732, 26);
            this.txtFilePath.TabIndex = 2;
            // 
            // rbUTF8
            // 
            this.rbUTF8.AutoSize = true;
            this.rbUTF8.Location = new System.Drawing.Point(58, 103);
            this.rbUTF8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbUTF8.Name = "rbUTF8";
            this.rbUTF8.Size = new System.Drawing.Size(74, 24);
            this.rbUTF8.TabIndex = 3;
            this.rbUTF8.TabStop = true;
            this.rbUTF8.Text = "UTF8";
            this.rbUTF8.UseVisualStyleBackColor = true;
            this.rbUTF8.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbUnicode
            // 
            this.rbUnicode.AutoSize = true;
            this.rbUnicode.Location = new System.Drawing.Point(58, 138);
            this.rbUnicode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbUnicode.Name = "rbUnicode";
            this.rbUnicode.Size = new System.Drawing.Size(93, 24);
            this.rbUnicode.TabIndex = 3;
            this.rbUnicode.TabStop = true;
            this.rbUnicode.Text = "Unicode";
            this.rbUnicode.UseVisualStyleBackColor = true;
            this.rbUnicode.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select an Encoding";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Path";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 395);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Content";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(58, 438);
            this.tbContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(919, 144);
            this.tbContent.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(63, 620);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(186, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save content to a file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbUnicode);
            this.Controls.Add(this.rbUTF8);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnBrowse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "file Stream and Encoding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.RadioButton rbUTF8;
        private System.Windows.Forms.RadioButton rbUnicode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

