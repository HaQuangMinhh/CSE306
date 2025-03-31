using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsManager;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_Manager  //file program phải thêm using  Windows_Manager;
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //tạo event bên design
        private void Form1_Load(object sender, EventArgs e)
        {
            //get a list of the drives
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 3;
                        break;
                    case DriveType.Network:
                        driveImage = 6;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;
                    case DriveType.Unknown:
                        driveImage = 8;
                        break;
                    default:
                        driveImage = 2;
                        break;
                }

                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                treeView.Nodes.Add(node);
            }

        }

        //tạo event bên design
        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        //tạo event bên design
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            listBoxFiles.Items.Clear();
            listBoxFolders.Items.Clear();
            txtPathClient.Text = e.Node.Tag.ToString();
            try
            {
                string[] fileEntries = Directory.GetFiles(e.Node.Tag.ToString());

                foreach (string fileName in fileEntries)
                {
                    int _temp = listBoxFiles.Items.Add(Path.GetFileName(fileName));
                }
                fileEntries = Directory.GetDirectories(e.Node.Tag.ToString());
                foreach (string fileName in fileEntries)
                    listBoxFolders.Items.Add(Path.GetFileName(fileName));
            }
            catch { }
        }


       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetFilesAndFolders(txtServer.Text, txtUsername.Text, txtPassword.Text, "/");

        }

        private void GetFilesAndFolders(string _server, string _user, string _pass, string _path)
        {
            string path = _server + ":" + txtPort.Text + _path;
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(path);
            NetworkCredential networkCredential = new NetworkCredential(_user, _pass);
            req.Credentials = networkCredential;


            req.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            FtpWebResponse res = (FtpWebResponse)req.GetResponse();

            Stream stream = res.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string data = sr.ReadToEnd();

            txtStatus.Text = res.StatusDescription;

            sr.Close();
            res.Close();

            
            //lbFiles.Items.Clear();

            //cắt thành từng dòng và đưa vào lb
            string[] dataArray = data.Split(new string[] { "\r\n" }, StringSplitOptions.None);

            lbFolders.Items.Clear();

            foreach (string item in dataArray)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    if (item.IndexOf("<DIR>") > 0)
                    {
                        lbFolders.Items.Add(item.Substring(39));
                    }
                    else
                    {
                        lbFiles.Items.Add(item.Substring(39));
                    }
                }

            }
            //txtPath.Text = "/";
        }

        private void lbFolders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbFiles.Items.Clear();
            string path = txtPath.Text + "/" + lbFolders.SelectedItem.ToString();
            txtPath.Text = path;

              
            GetFilesAndFolders(txtServer.Text, txtUsername.Text, txtPassword.Text, path);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            string _path = txtPath.Text.TrimEnd('/');
            int index = _path.LastIndexOf("/");
            if(index > 0 )
            {
                _path = _path.Substring(0, index) ;
            }
            else
            {
                _path = "/";
            }
            txtPath.Text = _path;
            GetFilesAndFolders(txtServer.Text, txtUsername.Text, txtPassword.Text, _path);
        }

        private void btnUpload_Click(object sender, EventArgs e) //up load file selected từ sever - client
        {
            if (listBoxFiles.SelectedItem != null)
            {
                lbFiles.Items.Clear();
                string filePath = txtPathClient.Text + @"/" + listBoxFiles.SelectedItem.ToString();

                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(txtServer.Text + ":" + txtPort.Text + txtPath.Text +"/" +  listBoxFiles.SelectedItem.ToString());
                NetworkCredential networkCredential = new NetworkCredential(txtUsername.Text, txtPassword.Text);

                req.Credentials = networkCredential;
                req.Method = WebRequestMethods.Ftp.UploadFile;

                byte[] data = File.ReadAllBytes(filePath);
                using (Stream stream = req.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                }
                GetFilesAndFolders(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPath.Text);
                MessageBox.Show("Uploaded");

            }
          
        }

        private void btnDownload_Click(object sender, EventArgs e)  //down từ client-server
        {
            if (lbFiles.SelectedItem != null)
            {
                string path = txtPath.Text + "/" + lbFiles.SelectedItem.ToString();
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(txtServer.Text + ":" + txtPort.Text + path);
                NetworkCredential networkCredential = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                req.Credentials = networkCredential;

                req.UseBinary = true;
                req.UsePassive = true;
                req.KeepAlive = true;

                req.Method= WebRequestMethods.Ftp.DownloadFile;
                
                FtpWebResponse res = (FtpWebResponse)req.GetResponse();

                Stream stream = res.GetResponseStream();
                string clientFilePath = txtPathClient.Text + @"/" + lbFiles.SelectedItem.ToString();

                FileStream fs = new FileStream(clientFilePath, FileMode.Create);
                byte[] buffer = new byte[1024];
                int byteRead;
                while((byteRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fs.Write(buffer, 0, byteRead);
                }
                fs.Close();
                stream.Close();

                listBoxFiles.Items.Clear();

                string[] localFiles = Directory.GetFiles(txtPathClient.Text);
                foreach (string item in localFiles)
                {
                    listBoxFiles.Items.Add(Path.GetFileName(item));
                }
                MessageBox.Show("Downloaded");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) //detele file selected bên client
        {
            if (lbFiles.SelectedItem != null)
            {
                string path = txtPath.Text + "/" + lbFiles.SelectedItem.ToString();
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(txtServer.Text + ":" + txtPort.Text + path);
                NetworkCredential networkCredential = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                req.Credentials = networkCredential;

                req.Method = WebRequestMethods.Ftp.DeleteFile;
                FtpWebResponse res = (FtpWebResponse)req.GetResponse();
                res.Close();

                lbFiles.Items.Clear();

                GetFilesAndFolders(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPath.Text);

                MessageBox.Show("Deleted");

            }
        }

        private void btnRename_Click(object sender, EventArgs e)  // rename selected files bên client
        {
            if (lbFiles.SelectedItem != null)
            {
                RenameForm rf = new RenameForm(lbFiles.SelectedItem.ToString());
                var result = rf.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    string newName = rf.ReturnValue;
                    if(!newName.Equals(lbFiles.SelectedItem.ToString()))
                    {
                        
                        string path = txtPath.Text + "/" + lbFiles.SelectedItem.ToString();
                        FtpWebRequest req = (FtpWebRequest)WebRequest.Create(txtServer.Text + ":" + txtPort.Text + path);
                        NetworkCredential networkCredential = new NetworkCredential(txtUsername.Text, txtPassword.Text);
                        req.Credentials = networkCredential;

                        req.Method = WebRequestMethods.Ftp.Rename;
                        req.RenameTo = newName;
                        FtpWebResponse ftpResponse = (FtpWebResponse)req.GetResponse();
                        lbFiles.Items.Clear();

                        GetFilesAndFolders(txtServer.Text, txtUsername.Text, txtPassword.Text, txtPath.Text);

                    }
                }
            }
        }

      
    }

}
