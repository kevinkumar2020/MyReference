using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_Assignment01
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            btnone.Click += new EventHandler(btnzero_Click);
            btntwo.Click += new EventHandler(btnzero_Click);
            btnthree.Click += new EventHandler(btnzero_Click);
            btnfour.Click += new EventHandler(btnzero_Click);
            btnfive.Click += new EventHandler(btnzero_Click);
            btnsix.Click += new EventHandler(btnzero_Click);
            btnseven.Click += new EventHandler(btnzero_Click);
            btneight.Click += new EventHandler(btnzero_Click);
            btnmultiply.Click += new EventHandler(btndivision_Click);
            btnplus.Click += new EventHandler(btndivision_Click);
            btnmins.Click += new EventHandler(btndivision_Click);

            btnMclose.Enabled = false;
            btnMr.Enabled = false;
        }
        int opreator;
        bool flag = false;
        string sign;
        Double memory;
        bool memoryFlag;

        private void btnzero_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" || memoryFlag == true)
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((sender as Button).Text);
            memoryFlag = false;
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sign = btn.Text;
            opreator = Int32.Parse(textBox1.Text);
            if (textBox1.Text != "")
            {
                textBox1.Text = "";
            }
            flag = true;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case "+":
                    textBox1.Text = (opreator + Int32.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (opreator - Int32.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (opreator / Int32.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (opreator * Int32.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = textBox1.Text.Length;
            i--;
            textBox1.Text = textBox1.Text.Remove(i);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnMstart_Click(object sender, EventArgs e)
        {
            memory = double.Parse(textBox1.Text);
            btnMclose.Enabled = true;
            btnMr.Enabled = true;
            memoryFlag = true;
        }

        private void btnMclose_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            memory = 0;
            btnMclose.Enabled = false;
            btnMr.Enabled = false;
        }

        private void btnMmins_Click(object sender, EventArgs e)
        {
            memory -= double.Parse(textBox1.Text);
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(textBox1.Text);
        }

        private void btnMr_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
            memoryFlag = true;
        }

        
    }
}
