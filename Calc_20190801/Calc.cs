using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_20190801
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 演算子を押したか押してないか判定する変数
        bool opeFlg = false;

        string firstNum = "";
        string erorr = "エラー";

        private void btn1_Click(object sender, EventArgs e)
        {
            if (opeFlg) // (opeFlg == true)と同義
            {
                txtDisplay.Text = btn1.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn2.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn2.Text;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn3.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn4.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn5.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn6.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn6.Text;
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn7.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn7.Text;
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn8.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn8.Text;
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn9.Text;
                opeFlg = false;
            }
            else
            {
                txtDisplay.Text += btn9.Text;
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            opeFlg = true;
            firstNum = txtDisplay.Text;
            lblOperation.Text = btnDivide.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            opeFlg = true;
            firstNum = txtDisplay.Text;
            lblOperation.Text = btnMinus.Text;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            opeFlg = true;
            firstNum = txtDisplay.Text;
            lblOperation.Text = btnProduct.Text;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            opeFlg = true;
            firstNum = txtDisplay.Text;
            lblOperation.Text = btnSum.Text;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            lblOperation.Text = "";
            opeFlg = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (opeFlg)
            {
                txtDisplay.Text = btn0.Text;
                opeFlg = false;
            }
            //else if(txtDisplay.Text=btn0.Text/0)              
            {
                txtDisplay.Text += btn0.Text;
            }
            if(lblOperation.Text == btnDivide.Text)
            {
                txtDisplay.Text = erorr;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (lblOperation.Text == btnSum.Text)
            {
                txtDisplay.Text = (int.Parse(firstNum) + int.Parse(txtDisplay.Text)).ToString();
            }
            else if(lblOperation.Text == btnMinus.Text)
            {
                txtDisplay.Text = (int.Parse(firstNum) - int.Parse(txtDisplay.Text)).ToString();
            }
            else if (lblOperation.Text == btnDivide.Text)
            {
                txtDisplay.Text = (int.Parse(firstNum) / int.Parse(txtDisplay.Text)).ToString();
            }
            else if(lblOperation.Text == btnProduct.Text)
            {
                txtDisplay.Text = (int.Parse(firstNum) * int.Parse(txtDisplay.Text)).ToString();
            }
          
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = System.Math.Sqrt(int.Parse(txtDisplay.Text)).ToString();
        }

        private void BtnPlusMinus_Click(object sender, EventArgs e)
        {

        }
    }
}
//0÷=えらーになるようにする
