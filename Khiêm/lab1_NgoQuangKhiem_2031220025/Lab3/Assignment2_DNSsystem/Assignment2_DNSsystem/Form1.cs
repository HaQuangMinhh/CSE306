using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Assignment2_DNSsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            //cách làm
            //dns.gethostAddress-> []ip addresss ->loop[]-> print->txtbox

            //string hostName = txtHost.Text.Trim();

            //nếu không có host thì phải tb nhập
            if (string.IsNullOrEmpty(txtHost.Text))
            {
                MessageBox.Show("Please enter a host name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Dns.GetHostAddresses là một phương thức trong thư viện System.Net của C# được sử dụng để
            //lấy các địa chỉ IP liên kết với một tên máy chủ hoặc tên miền (hostname).

            IPAddress[] IPs = Dns.GetHostAddresses(txtHost.Text);

            //loop để in ip vào listbox
                    foreach (IPAddress ip in IPs)
                    {
                        lbIPAddress.Items.Add(ip.ToString());
                    }

            //nếu hostname k đúng, tức là k lấy dc ip từ host thì tb lỗi
                    if (IPs.Length == 0)
                    {
                        lbIPAddress.Items.Add("No IP addresses found.");
                    }

            //xóa hostname
            txtHost.Text = "";

          

        }
    }
}
