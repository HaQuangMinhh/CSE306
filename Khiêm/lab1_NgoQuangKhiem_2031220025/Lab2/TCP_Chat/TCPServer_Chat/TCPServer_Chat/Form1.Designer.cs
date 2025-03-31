namespace TCPServer_Chat
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
            this.btnListen = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lbContent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server Port";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(620, 61);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(109, 38);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(635, 180);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 44);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(339, 64);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(84, 26);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "30000";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(34, 64);
            this.txtIP.Name = "txtIP";
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIP.Size = new System.Drawing.Size(212, 26);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(34, 178);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(563, 46);
            this.txtText.TabIndex = 3;
            // 
            // lbContent
            // 
            this.lbContent.FormattingEnabled = true;
            this.lbContent.ItemHeight = 20;
            this.lbContent.Location = new System.Drawing.Point(32, 290);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(697, 144);
            this.lbContent.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TCP Server - Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ListBox lbContent;
    }
}

