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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Run(new Form19());
        }

        private void btnRightMove_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                while(listBox1.SelectedItems.Count > 0)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please Select Item", "Message"); 
            }
        }

        private void btnLeftMove_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedItems.Count > 0)
            {
                while (listBox2.SelectedItems.Count > 0)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Please Select Item", "Message");
            }
        }

        private void textBoxDay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonHCF_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                labelMessage.Text = "Enter Number";
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int j, hcf = 0;
                j = (num1 > num2) ? num1 : num2;
                for (int i = 1; i <= j; i++)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        hcf = i;
                    }
                }
                labelMessage.Text = "HCF Of " + num1.ToString() + " And " + num2.ToString() + " Is: " + hcf.ToString();
            }

        }

        private void radioButtonLCM_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "")
            {
                labelMessage.Text = "Enter Number";
            }
            else
            {
                int num1 = Int32.Parse(textBox1.Text);
                int num2 = Int32.Parse(textBox2.Text);
                int max, lcm;
                max = (num1 > num2) ? num1 : num2;
                for (int i = max; ; i += max)
                {
                    if (i % num1 == 0 && i % num2 == 0)
                    {
                        lcm = i;
                        break;
                    }
                }
                labelMessage.Text = "LCM Of " + num1.ToString() + " And " + num2.ToString() + " Is: " + lcm.ToString();
            }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnLeftMove_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = btnLeftMove.Name;
        }

        private void dateTimePicker1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Name;
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.Name;
        }

        private void listBox3_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = listBoxDateDisplay.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime();
            DateTime dt2 = new DateTime();
            dt1 = dateTimePicker1.Value;
            dt2 = dateTimePicker2.Value;
            if (dt1 == dt2)
            {
                listBoxDateDisplay.Items.Add(dt1);
            }else if (dt1 > dt2)
            {
                MessageBox.Show("This Is Invalid Selection...!", "Message");
            }
            else
            {
                listBoxDateDisplay.Items.Clear();
                listBoxDateDisplay.Items.Add(dt1);
                while (dt1 < dt2)
                {
                    dt1 = dt1.AddDays(1);
                    listBoxDateDisplay.Items.Add(dt1);
                }
            }
        }
    }
}
