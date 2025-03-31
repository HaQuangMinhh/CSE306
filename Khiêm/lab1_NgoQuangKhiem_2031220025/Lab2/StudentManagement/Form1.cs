using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAvatar_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "file jpg (*.jpg)|*.jpg| all file (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureAvatar.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnReadfromaFileandDeserialize_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string jsonString = File.ReadAllText(openFileDialog.FileName);
                Student st = JsonSerializer.Deserialize<Student>(jsonString);
                txtStudentID.Text = st.Id.ToString(); 
                txtStudentName.Text = st.Name;  
                dtDOB.Value = st.dob;
                txtAddress.Text = st.Address;
                openFileDialog.FileName = st.Avatar;
                pictureAvatar.Image = Image.FromFile(st.Avatar);
             
            }    

        }

        private void btnSerializeandSavetoafile_Click(object sender, EventArgs e)
        {
           

            Student st = new Student(Int32.Parse(txtStudentID.Text), txtStudentName.Text, DateTime.Parse(dtDOB.Text), txtAddress.Text, openFileDialog.FileName);
            string jsonString = JsonSerializer.Serialize(st);

            MessageBox.Show(jsonString);
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(saveFileDialog.FileName, jsonString);
                MessageBox.Show("Saved!", "Notice");
            }
            ClearAllFields(); //chạy funtion xóa 

        }
        private void ClearAllFields()
        {

            txtStudentID.Clear();
            txtStudentName.Clear();
            dtDOB.Value = DateTime.Now; 
            txtAddress.Clear();
            pictureAvatar.Image = null;
        }

        private void btnReadFromaFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Student st;
                using (BinaryReader br = new BinaryReader(new FileStream(openFileDialog.FileName, FileMode.Open)))
                {
                    st = new Student(
                        br.ReadInt32(),          
                        br.ReadString(),         
                        DateTime.Parse(br.ReadString()),
                        br.ReadString(),          
                        br.ReadString()
                        );
                };


                txtStudentID.Text = st.Id.ToString();
                txtStudentName.Text = st.Name;
                dtDOB.Value = st.dob;
                txtAddress.Text = st.Address;
                openFileDialog.FileName = st.Avatar;
                pictureAvatar.Image = Image.FromFile(st.Avatar);

            }
        }

        private void btnSaveToaFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (BinaryWriter bw = new BinaryWriter(new FileStream(saveFileDialog.FileName, FileMode.Create)))
                {
                    bw.Write(Int32.Parse(txtStudentID.Text));
                    bw.Write(txtStudentName.Text);
                    bw.Write(dtDOB.Value.ToString());
                    bw.Write(txtAddress.Text);
                    bw.Write(openFileDialog.FileName);
                }    

                
                ClearAllFields();
                MessageBox.Show("Saved!", "Notice");
            }
            
        }
    }
}
