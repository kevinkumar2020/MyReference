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
    public partial class Form10_12 : Form
    {
        public Form10_12()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            //if (textBox12.Text == "A" || textBox12.Text == "a" || textBox12.Text == "E" || textBox12.Text == "e" ||
            //    textBox12.Text == "I" || textBox12.Text == "i" || textBox12.Text == "O" || textBox12.Text == "o" ||
            //    textBox12.Text == "U" || textBox12.Text == "u")
            //{
            //    labelMessage.Text = "Input Character Is Vowel....!";
            //}
            //else
            //{
            //    labelMessage.Text = "";
            //}
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if ("aeiouAEIOU".IndexOf((char)e.KeyValue) > 0)
            {
                labelMessage.Text = "Input Character Is Vowel....!";
            }
            else
            {
                labelMessage.Text = "";
            }
        }
    }
}
