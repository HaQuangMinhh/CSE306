namespace ChatApp_Windows
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnSendContent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your content";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(39, 39);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(484, 20);
            this.txtContent.TabIndex = 1;
            // 
            // btnSendContent
            // 
            this.btnSendContent.Location = new System.Drawing.Point(553, 36);
            this.btnSendContent.Name = "btnSendContent";
            this.btnSendContent.Size = new System.Drawing.Size(75, 23);
            this.btnSendContent.TabIndex = 2;
            this.btnSendContent.Text = "Send";
            this.btnSendContent.UseVisualStyleBackColor = true;
            this.btnSendContent.Click += new System.EventHandler(this.btnSendContent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chat content";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbContent
            // 
            this.lbContent.FormattingEnabled = true;
            this.lbContent.Location = new System.Drawing.Point(39, 148);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(589, 173);
            this.lbContent.TabIndex = 4;
            this.lbContent.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnSendContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbContent;
    }
}

