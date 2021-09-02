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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public int handelMin(params int[] arr)
        {
            int min = int.MaxValue;
            foreach (int value in arr)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxAddvalue_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxAddvalue.Text == "")
            {
                MessageBox.Show("Enter Value", "Message");
            }else
            {
                comboBox1.Items.Add(textBoxAddvalue.Text);
                int[] array = new int[comboBox1.Items.Count];
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    object obj = comboBox1.Items[i];
                    array[i] = Convert.ToInt32(obj);
                }
                textBoxAddvalue.Clear();
                textBox1.Text = handelMin(array).ToString();
            }
            
        }
    }
}
