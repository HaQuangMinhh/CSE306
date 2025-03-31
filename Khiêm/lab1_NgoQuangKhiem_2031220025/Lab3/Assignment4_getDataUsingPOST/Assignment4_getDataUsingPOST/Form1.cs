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

namespace Assignment4_getDataUsingPOST
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
            Dictionary<string, string> values = new Dictionary<string, string>()
            {
                {txtParameter.Text, txtValue.Text},
                //{" parameter", "value}
            };
            FormUrlEncodedContent content = new FormUrlEncodedContent(values);
            HttpResponseMessage reponse = await client.PostAsync(txtURL.Text, content);
            string body = await reponse.Content.ReadAsStringAsync();
            txtContent.Text = body;
        }
    }
}
