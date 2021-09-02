using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dynemic control application
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num;
        Button[,] btns;
        int size;
        private void Form1_Load(object sender, EventArgs e)
        {
            //txt is reference Here, allocate a address
            // TextBox txt = new TextBox();
            //this.Controls.Add(txt);
            // txt.TextChanged += new EventHandler(abc);
            //Button[,] btns = new Button[3,3];
            //this.Controls.Add(btns[0, 0]);
            //this.Controls.Add(btns[0, 1]);
            //this.Controls.Add(btns[0, 2]);
            //this.Controls.Add(btns[1, 0]);
            //this.Controls.Add(btns[0, 0]);
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                int location_x = 0;
                int location_y = 0;
                size = Int32.Parse(textBox1.Text);

                MessageBox.Show("Please Enter Number");
            }
            else
            {
                num = 
                Button[,] btn = new Button[3,3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        this.Controls.Add(btn[i, j]);
                    }
                }
            }
        }
        private void checkrun(object sender,EventArgs e)
        {
            int ocount = 0;
        }
        //private void abc(object sender,EventArgs e)
        //{
        //  MessageBox.Show("Hello abc");
        // }
    }
}
