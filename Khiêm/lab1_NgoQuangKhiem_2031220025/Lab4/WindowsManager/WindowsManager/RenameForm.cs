using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsManager
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }
        public RenameForm(string _s)
        {
            InitializeComponent();
            txtNewName.Text = _s;
        }
        public string ReturnValue { get; private set; }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            ReturnValue = txtNewName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
