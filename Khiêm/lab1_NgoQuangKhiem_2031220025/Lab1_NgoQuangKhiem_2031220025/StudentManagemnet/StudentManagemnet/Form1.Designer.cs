namespace StudentManagemnet
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.btnReadFromaFile = new System.Windows.Forms.Button();
            this.btnSaveToaFile = new System.Windows.Forms.Button();
            this.btnReadfromaFileandDeserialize = new System.Windows.Forms.Button();
            this.btnSerializeandSavetoafile = new System.Windows.Forms.Button();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Avatar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(404, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 380);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(404, 136);
            this.textBox3.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(60, 268);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnAvatar
            // 
            this.btnAvatar.Location = new System.Drawing.Point(668, 57);
            this.btnAvatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(148, 35);
            this.btnAvatar.TabIndex = 3;
            this.btnAvatar.Text = "Select/Change";
            this.btnAvatar.UseVisualStyleBackColor = true;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // btnReadFromaFile
            // 
            this.btnReadFromaFile.Location = new System.Drawing.Point(60, 551);
            this.btnReadFromaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReadFromaFile.Name = "btnReadFromaFile";
            this.btnReadFromaFile.Size = new System.Drawing.Size(182, 35);
            this.btnReadFromaFile.TabIndex = 3;
            this.btnReadFromaFile.Text = "Read from a file";
            this.btnReadFromaFile.UseVisualStyleBackColor = true;
            this.btnReadFromaFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveToaFile
            // 
            this.btnSaveToaFile.Location = new System.Drawing.Point(60, 609);
            this.btnSaveToaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveToaFile.Name = "btnSaveToaFile";
            this.btnSaveToaFile.Size = new System.Drawing.Size(182, 35);
            this.btnSaveToaFile.TabIndex = 3;
            this.btnSaveToaFile.Text = "Save to a file";
            this.btnSaveToaFile.UseVisualStyleBackColor = true;
            this.btnSaveToaFile.Click += new System.EventHandler(this.btnSaveToaFile_Click);
            // 
            // btnReadfromaFileandDeserialize
            // 
            this.btnReadfromaFileandDeserialize.Location = new System.Drawing.Point(464, 551);
            this.btnReadfromaFileandDeserialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReadfromaFileandDeserialize.Name = "btnReadfromaFileandDeserialize";
            this.btnReadfromaFileandDeserialize.Size = new System.Drawing.Size(256, 35);
            this.btnReadfromaFileandDeserialize.TabIndex = 3;
            this.btnReadfromaFileandDeserialize.Text = "Read from a file and Derialize";
            this.btnReadfromaFileandDeserialize.UseVisualStyleBackColor = true;
            this.btnReadfromaFileandDeserialize.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSerializeandSavetoafile
            // 
            this.btnSerializeandSavetoafile.Location = new System.Drawing.Point(464, 609);
            this.btnSerializeandSavetoafile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerializeandSavetoafile.Name = "btnSerializeandSavetoafile";
            this.btnSerializeandSavetoafile.Size = new System.Drawing.Size(256, 35);
            this.btnSerializeandSavetoafile.TabIndex = 3;
            this.btnSerializeandSavetoafile.Text = "Serialize and Save to a file";
            this.btnSerializeandSavetoafile.UseVisualStyleBackColor = true;
            this.btnSerializeandSavetoafile.Click += new System.EventHandler(this.btnSerializeandSavetoafile_Click);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Location = new System.Drawing.Point(668, 123);
            this.pictureAvatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(284, 175);
            this.pictureAvatar.TabIndex = 4;
            this.pictureAvatar.TabStop = false;
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
            this.Controls.Add(this.pictureAvatar);
            this.Controls.Add(this.btnSerializeandSavetoafile);
            this.Controls.Add(this.btnReadfromaFileandDeserialize);
            this.Controls.Add(this.btnSaveToaFile);
            this.Controls.Add(this.btnReadFromaFile);
            this.Controls.Add(this.btnAvatar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.Button btnReadFromaFile;
        private System.Windows.Forms.Button btnSaveToaFile;
        private System.Windows.Forms.Button btnReadfromaFileandDeserialize;
        private System.Windows.Forms.Button btnSerializeandSavetoafile;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

