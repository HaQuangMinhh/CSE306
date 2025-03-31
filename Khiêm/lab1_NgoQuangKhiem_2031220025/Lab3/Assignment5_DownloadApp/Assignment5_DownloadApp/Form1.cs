using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;


namespace Assignment5_DownloadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            //HttpClient client = new HttpClient();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                using ( var htttpClient = new HttpClient())
                {
                    Uri uri = new Uri(txtURL.Text);
                    string filename = Path.GetFileName(uri.AbsolutePath);

                    using (var response = await htttpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead))
                    { 
                        response.EnsureSuccessStatusCode();

                        //path to save file
                        var filePath = Path.Combine(folderBrowserDialog.SelectedPath, filename);

                        using (var ms = await response.Content.ReadAsStreamAsync())
                        using (var fs = File.Create(filePath)) 
                        {
                            await ms.CopyToAsync(fs);
                            fs.Flush();
                        }
                    }
                }
                MessageBox.Show("Done!");
                //http://10.10.125.244/cse306/index.php
            }


        }
    }
}
