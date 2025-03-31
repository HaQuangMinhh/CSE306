namespace WindowsManager
{
    partial class RenameForm
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
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(107, 56);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(540, 26);
            this.txtNewName.TabIndex = 0;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(286, 104);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(190, 31);
            this.btnChangeName.TabIndex = 1;
            this.btnChangeName.Text = "Change Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 189);
            this.Controls.Add(this.btnChangeName);
            this.Controls.Add(this.txtNewName);
            this.Name = "RenameForm";
            this.Text = "RenameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Button btnChangeName;
    }
}