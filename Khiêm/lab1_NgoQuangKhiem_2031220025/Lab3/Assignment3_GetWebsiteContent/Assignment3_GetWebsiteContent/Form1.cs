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


namespace Assignment3_GetWebsiteContent
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            //tb kh dc để trống url
            if (string.IsNullOrEmpty(txtURL.Text))
            {
                MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //tbao đang chạy
            txtContent.Text = "Fetching content...";

            HttpResponseMessage body = await client.GetAsync(txtURL.Text);
            string resBody = await body.Content.ReadAsStringAsync();
            txtContent.Text = resBody;
        }

      
    }
}

