using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//set  openpfiledialog: multiple-true thì mới chọn dc nhiều
namespace Multi_Thread_Uploadimage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread[] threadArray;
        int numberOfFile = 0;
        int addition = 0;
        string destinationDirectory = "./Images/";


        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg; *.png|Text Files (*.txt)|*.txt| All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = openFileDialog.FileNames;
                numberOfFile = filePaths.Length;
                threadArray = new Thread[numberOfFile];
                for (int i = 0; i < numberOfFile; i++)
                {
                    txtPaths.AppendText(filePaths[i] + Environment.NewLine);
                    threadArray[i] = new Thread(UploadFile);
                    threadArray[i].Start(filePaths[i]);
                }
                Thread t = new Thread(JoinAllThread);
                t.Start();
            }

        }

        // tất cả các thread đều chạy chung 
        void JoinAllThread()
        {
            for (int i = 0; i < numberOfFile; i++)
            {
                threadArray[i].Join();
                
            }
            MessageBox.Show("Finished!", "Information");

        }

        void UploadFile(object _filePath)
        {
            string filePath = (string) _filePath;
            string fileName = Path.GetFileName(filePath);


            //cập nhật thông báo đang upload
            Action _uploading = delegate ()
            {
                lbStatus.Items.Add("Uploading: " + fileName);
            };
            lbStatus.Invoke(_uploading);


            //giả lập thời gian đợi
            Random r = new Random();
            int randomNumber = r.Next(3, 8);
            Thread.Sleep(randomNumber * 1000);

            //cập nhật tbao đã upload
            Action _act = delegate ()
            {
                lbStatus.Items.Add("* Uploaded: " + fileName);
            };
            lbStatus.Invoke(_act);
        }

        void copyFiletoFolder (string filePath)
        {
            var targetDirectoryInfo = new DirectoryInfo(destinationDirectory);
            if (!targetDirectoryInfo.Exists)   
                targetDirectoryInfo.Create();
            File.Copy(filePath, destinationDirectory + Path.GetFileName(filePath));
        }

     
    }
}
