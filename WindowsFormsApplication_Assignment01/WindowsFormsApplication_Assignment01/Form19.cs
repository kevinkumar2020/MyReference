using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication_Assignment01
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            string readfile = File.ReadAllText(filename);
            richTextBox1.Text = readfile; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "E:";
            saveFileDialog1.Title = "Save Text File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files | *.txt";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            if (FD.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(richTextBox1.Text))
            {
                richTextBox1.SelectionFont = FD.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
