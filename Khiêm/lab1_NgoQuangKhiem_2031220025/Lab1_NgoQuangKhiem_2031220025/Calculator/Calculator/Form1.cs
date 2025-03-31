using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0; // Giá trị lưu kết quả tính toán
        bool isOperatorPerformed = false; // Trạng thái có thao tác toán tử hay chưa
        string operatorPerformed = ""; // Toán tử được thực hiện
        public Form1()
        {
            InitializeComponent();
        }



        private void button_Click(object sender, EventArgs e)
        {
            //txtResult.Text = txtResult.Text + btn1.Text;
            //txtResult.AppendText(btn1.Text);
            if ((txtResult.Text == "0") || (isOperatorPerformed))
                txtResult.Clear();

            isOperatorPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + button.Text;

            }
            else
            {
                txtResult.Text = txtResult.Text + button.Text;
            }
        }

        private void operator_Click(object sender, EventArgs e)
        {
                Button button = (Button)sender;

                operatorPerformed = button.Text;
                resultValue = Double.Parse(txtResult.Text);
                isOperatorPerformed = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch(operatorPerformed)
            {
                case "+":
                    txtResult.Text = (resultValue + Double.Parse(txtResult.Text)).ToString(); break;
                case "-":
                    txtResult.Text = (resultValue - Double.Parse(txtResult.Text)).ToString(); break;
                case "X":
                    txtResult.Text = (resultValue * Double.Parse(txtResult.Text)).ToString(); break;
                case ":":
                    txtResult.Text = (resultValue / Double.Parse(txtResult.Text)).ToString(); break;
                default:
                    break;

            }
            resultValue = Double.Parse(txtResult.Text);
            operatorPerformed = "";

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


// 0-9 click
// cac dau event
