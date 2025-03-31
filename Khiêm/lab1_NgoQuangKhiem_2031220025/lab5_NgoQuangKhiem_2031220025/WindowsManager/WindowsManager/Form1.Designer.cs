namespace Windows_Manager
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPathClient = new System.Windows.Forms.TextBox();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.treeView = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbFolders = new System.Windows.Forms.ListBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tree View";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Folders";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Files";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(138, 9);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(407, 26);
            this.txtServer.TabIndex = 6;
            this.txtServer.Text = "ftp://127.0.0.1";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(138, 51);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 26);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.Text = "anonymous";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(395, 51);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(150, 26);
            this.txtPort.TabIndex = 8;
            this.txtPort.Text = "21";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // txtPathClient
            // 
            this.txtPathClient.Location = new System.Drawing.Point(138, 147);
            this.txtPathClient.Name = "txtPathClient";
            this.txtPathClient.Size = new System.Drawing.Size(407, 26);
            this.txtPathClient.TabIndex = 6;
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.ItemHeight = 20;
            this.listBoxFolders.Location = new System.Drawing.Point(318, 218);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(227, 144);
            this.listBoxFolders.TabIndex = 9;
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 20;
            this.listBoxFiles.Location = new System.Drawing.Point(318, 385);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(224, 164);
            this.listBoxFiles.TabIndex = 10;
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(38, 218);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(261, 331);
            this.treeView.TabIndex = 11;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(711, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(713, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(770, 143);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(356, 26);
            this.txtPath.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(713, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Folders";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(711, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Files";
            // 
            // lbFolders
            // 
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.ItemHeight = 20;
            this.lbFolders.Location = new System.Drawing.Point(715, 205);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(411, 144);
            this.lbFolders.TabIndex = 9;

            this.lbFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFolders_MouseDoubleClick);
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.ItemHeight = 20;
            this.lbFiles.Location = new System.Drawing.Point(715, 405);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(411, 144);
            this.lbFiles.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(578, 53);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 60);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(578, 218);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(105, 47);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(578, 283);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(105, 47);
            this.btnDownload.TabIndex = 14;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(578, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 47);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(578, 417);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(105, 47);
            this.btnRename.TabIndex = 14;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(715, 32);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(411, 105);
            this.txtStatus.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(879, 358);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 38);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.lbFolders);
            this.Controls.Add(this.listBoxFolders);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtPathClient);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPathClient;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbFolders;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnBack;
    }
}

