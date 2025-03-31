using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagemnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "file txt (*.txt)|*.txt| all file (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnSerializeandSavetoafile_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveToaFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog.FileName);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}
