using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnzero.Click += new System.EventHandler(btnone_Click);
            btntwo.Click += new System.EventHandler(btnone_Click);
            btnthree.Click += new System.EventHandler(btnone_Click);
            btnfour.Click += new System.EventHandler(btnone_Click);
            btnfive.Click += new System.EventHandler(btnone_Click);
            btnsix.Click += new System.EventHandler(btnone_Click);
            btnseven.Click += new System.EventHandler(btnone_Click);
            btneight.Click += new System.EventHandler(btnone_Click);
            btnnine.Click += new System.EventHandler(btnone_Click);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

        }
        double num = 0;
        double ans = 0;
        int optr = 0;
        bool flag = false;

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num = 0;
            ans = 0;            
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = "";
                flag = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((sender as Button).Text);
        }

        public void calculate(int optr)
        {
            switch (optr)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            optr = 1;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            calculate(optr);
        }

        private void btnmins_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            optr = 2;
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            optr = 3;
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            optr = 4;
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            optr = 5;
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Sqrt(num);
            textBox1.Text = ans.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnfloor_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Floor(num);
            textBox1.Text = ans.ToString();
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Sin(num);
            textBox1.Text = ans.ToString();
        }

        private void btnsinh_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Sinh(num);
            textBox1.Text = ans.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Cos(num);
            textBox1.Text = ans.ToString();
        }

        private void btncosh_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Cosh(num);
            textBox1.Text = ans.ToString();
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Tan(num);
            textBox1.Text = ans.ToString();
        }

        private void btntanh_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Tanh(num);
            textBox1.Text = ans.ToString();
        }

        private void btnpower2_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Pow(num, 2);
            textBox1.Text = ans.ToString();
        }

        private void btnpower3_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Pow(num, 3);
            textBox1.Text = ans.ToString();
        }

        private void btnceil_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Ceiling(num);
            textBox1.Text = ans.ToString();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Log(num);
            textBox1.Text = ans.ToString();
        }

        private void btnlog10_Click(object sender, EventArgs e)
        {
            num = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            ans = Math.Log10(num);
            textBox1.Text = ans.ToString();
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            int len = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < len; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
    }
}
