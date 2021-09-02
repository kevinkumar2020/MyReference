using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn1.Click += new System.EventHandler(btn0_Click);
            btn2.Click += new System.EventHandler(btn0_Click);
            btn3.Click += new System.EventHandler(btn0_Click);
            btn4.Click += new System.EventHandler(btn0_Click);
            btn5.Click += new System.EventHandler(btn0_Click);
            btn6.Click += new System.EventHandler(btn0_Click);
            btn7.Click += new System.EventHandler(btn0_Click);
            btn8.Click += new System.EventHandler(btn0_Click);
            btn9.Click += new System.EventHandler(btn0_Click);

            btndivide.Click += new System.EventHandler(btndivide_Click);
            btnmulti.Click += new System.EventHandler(btndivide_Click);
            btnpluse.Click += new System.EventHandler(btndivide_Click);
            btnsubtreak.Click += new System.EventHandler(btndivide_Click);
        }

        //oprandone
        int op1;
        bool flag = false;

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = "";
                flag = false;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text ="";
            }
            textBox1.Text = textBox1.Text + ((sender as Button).Text) ;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            op1 = Int32.Parse(textBox1.Text);
            flag = true;
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "+":
                    textBox1.Text = (op1 + Int32.Parse(textBox1.Text)).ToString();
                    break;
            }
            
        }
    }
}
