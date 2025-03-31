using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace Assigntment1_ImageCompression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            Int64 ratio = Int64.Parse(cbRatio.Text); //Lấy ratio 
            foreach (var item in lbImages.Items)
            {
                string imagePath = item.ToString(); // Lấy từng mục trong ListBox
                //MessageBox.Show(imagePath); // Hiển thị đường dẫn của từng mục
                string compressedImagePath = Path.GetDirectoryName(imagePath) + @"\" + txtPrefix.Text + Path.GetFileName(imagePath);
                //MessageBox.Show(compressedImagePath, "Nontification");
                using (Bitmap bm = new Bitmap(imagePath))
                {
                    EncoderParameters encoderParameters = new EncoderParameters(1);

                    System.Drawing.Imaging.Encoder qualityEncoder = System.Drawing.Imaging.Encoder.Quality;

                    EncoderParameter qualityEncoderParameter = new EncoderParameter(qualityEncoder,ratio ); //put ratio vào

                    //save
                    ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                    encoderParameters.Param[0] = qualityEncoderParameter;
                    bm.Save(compressedImagePath, jpgEncoder, encoderParameters);

                }
            }


            MessageBox.Show("Done!", "Nontification");
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
         
                var filers = new String[] { "jpg", " png" };
                List<String> files = new List<String>();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPathFolder.Text = folderBrowserDialog.SelectedPath;
                }

                foreach( var f in filers)
                {
                    files.AddRange(Directory.GetFiles(folderBrowserDialog.SelectedPath, string.Format("*.{0}",f)));
                }
            lbImages.Items.Clear();
            lbImages.Items.AddRange(files.ToArray());
            
        }
        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //chọn nhiều file đặt mutiselect trong open = true
            openFileDialog.Filter = "Image Files (*.jpg, *.png)|*.jpg; *.png|Text Files (*.txt)|*.txt| All files (*.*)|*.*";
            //openFileDialog.Multiselect = true;
           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                lbImages.Items.Clear(); // Xóa danh sách cũ
                lbImages.Items.AddRange(openFileDialog.FileNames); // Thêm danh sách các tệp

            }
        }
    }
}
