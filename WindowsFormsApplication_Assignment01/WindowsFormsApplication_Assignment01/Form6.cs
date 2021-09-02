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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter a Text", "Message");
            }
            else
            {
                timer1.Start();
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random run = new Random();
            int col1 = run.Next(0, 255);
            int col2 = run.Next(0, 255);
            int col3 = run.Next(0, 255);
            int col4 = run.Next(0, 255);
            textBox1.ForeColor = Color.FromArgb(col1, col2,col3,col4);
        }
    }
}
