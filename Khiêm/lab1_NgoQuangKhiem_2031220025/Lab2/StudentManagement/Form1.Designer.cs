namespace StudentManagement
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
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSerializeandSavetoafile = new System.Windows.Forms.Button();
            this.btnReadfromaFileandDeserialize = new System.Windows.Forms.Button();
            this.btnSaveToaFile = new System.Windows.Forms.Button();
            this.btnReadFromaFile = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Location = new System.Drawing.Point(639, 129);
            this.pictureAvatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(284, 175);
            this.pictureAvatar.TabIndex = 13;
            this.pictureAvatar.TabStop = false;
            // 
            // btnAvatar
            // 
            this.btnAvatar.Location = new System.Drawing.Point(639, 63);
            this.btnAvatar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(148, 35);
            this.btnAvatar.TabIndex = 12;
            this.btnAvatar.Text = "Select/Change";
            this.btnAvatar.UseVisualStyleBackColor = true;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // dtDOB
            // 
            this.dtDOB.Location = new System.Drawing.Point(31, 274);
            this.dtDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(298, 26);
            this.dtDOB.TabIndex = 11;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(31, 154);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(404, 26);
            this.txtStudentName.TabIndex = 9;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(31, 68);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(404, 26);
            this.txtStudentID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Avatar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student ID";
            // 
            // btnSerializeandSavetoafile
            // 
            this.btnSerializeandSavetoafile.Location = new System.Drawing.Point(435, 583);
            this.btnSerializeandSavetoafile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerializeandSavetoafile.Name = "btnSerializeandSavetoafile";
            this.btnSerializeandSavetoafile.Size = new System.Drawing.Size(256, 35);
            this.btnSerializeandSavetoafile.TabIndex = 16;
            this.btnSerializeandSavetoafile.Text = "Serialize and Save to a file";
            this.btnSerializeandSavetoafile.UseVisualStyleBackColor = true;
            this.btnSerializeandSavetoafile.Click += new System.EventHandler(this.btnSerializeandSavetoafile_Click);
            // 
            // btnReadfromaFileandDeserialize
            // 
            this.btnReadfromaFileandDeserialize.Location = new System.Drawing.Point(435, 525);
            this.btnReadfromaFileandDeserialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReadfromaFileandDeserialize.Name = "btnReadfromaFileandDeserialize";
            this.btnReadfromaFileandDeserialize.Size = new System.Drawing.Size(256, 35);
            this.btnReadfromaFileandDeserialize.TabIndex = 17;
            this.btnReadfromaFileandDeserialize.Text = "Read from a file and Derialize";
            this.btnReadfromaFileandDeserialize.UseVisualStyleBackColor = true;
            this.btnReadfromaFileandDeserialize.Click += new System.EventHandler(this.btnReadfromaFileandDeserialize_Click);
            // 
            // btnSaveToaFile
            // 
            this.btnSaveToaFile.Location = new System.Drawing.Point(31, 583);
            this.btnSaveToaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveToaFile.Name = "btnSaveToaFile";
            this.btnSaveToaFile.Size = new System.Drawing.Size(182, 35);
            this.btnSaveToaFile.TabIndex = 18;
            this.btnSaveToaFile.Text = "Save to a file";
            this.btnSaveToaFile.UseVisualStyleBackColor = true;
            this.btnSaveToaFile.Click += new System.EventHandler(this.btnSaveToaFile_Click);
            // 
            // btnReadFromaFile
            // 
            this.btnReadFromaFile.Location = new System.Drawing.Point(31, 525);
            this.btnReadFromaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReadFromaFile.Name = "btnReadFromaFile";
            this.btnReadFromaFile.Size = new System.Drawing.Size(182, 35);
            this.btnReadFromaFile.TabIndex = 19;
            this.btnReadFromaFile.Text = "Read from a file";
            this.btnReadFromaFile.UseVisualStyleBackColor = true;
            this.btnReadFromaFile.Click += new System.EventHandler(this.btnReadFromaFile_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(31, 354);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(404, 136);
            this.txtAddress.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 636);
            this.Controls.Add(this.btnSerializeandSavetoafile);
            this.Controls.Add(this.btnReadfromaFileandDeserialize);
            this.Controls.Add(this.btnSaveToaFile);
            this.Controls.Add(this.btnReadFromaFile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureAvatar);
            this.Controls.Add(this.btnAvatar);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSerializeandSavetoafile;
        private System.Windows.Forms.Button btnReadfromaFileandDeserialize;
        private System.Windows.Forms.Button btnSaveToaFile;
        private System.Windows.Forms.Button btnReadFromaFile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

