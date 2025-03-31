namespace StreamReaderAndWriter
{
    partial class form1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnReadandShow = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path to read";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(716, 63);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(96, 33);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnReadandShow
            // 
            this.btnReadandShow.Location = new System.Drawing.Point(50, 102);
            this.btnReadandShow.Name = "btnReadandShow";
            this.btnReadandShow.Size = new System.Drawing.Size(274, 34);
            this.btnReadandShow.TabIndex = 2;
            this.btnReadandShow.Text = "Read file and show";
            this.btnReadandShow.UseVisualStyleBackColor = true;
            this.btnReadandShow.Click += new System.EventHandler(this.btnReadandShow_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(50, 361);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(274, 31);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save content to a new file";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(50, 63);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(638, 33);
            this.txtPath.TabIndex = 3;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(50, 191);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(762, 147);
            this.txtContent.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // form1
            // 
            this.ClientSize = new System.Drawing.Size(852, 411);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.btnReadandShow);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Stream Reader and Writer";
            this.Load += new System.EventHandler(this.btnSave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnReadandShow;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }

}