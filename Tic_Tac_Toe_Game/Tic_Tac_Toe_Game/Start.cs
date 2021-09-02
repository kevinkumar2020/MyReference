using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class Start : Form
    {
        int SetValueForX;
        int SetValueForY;
       // string SetValueForXorO = "";
        public Start()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (textBoxX.Text != null && textBoxY.Text != null
                && !string.IsNullOrWhiteSpace(textBoxX.Text)
                && !string.IsNullOrWhiteSpace(textBoxY.Text))
            {
                SetValueForX = Convert.ToInt32(textBoxX.Text);
                SetValueForY = Convert.ToInt32(textBoxY.Text);
                if (SetValueForX == SetValueForY)
                {
                    Start start = new Start();
                    if (checkBoxForX.Checked)
                    {
                        Form1 frm1 = new Form1(SetValueForX, SetValueForY, checkBoxForX.Text);
                        this.Hide();
                        frm1.Closed += (s, args) => this.Close();
                        frm1.Show();
                    }
                    if (checkBoxFor0.Checked)
                    {
                        Form1 frm1 = new Form1(SetValueForX, SetValueForY, checkBoxFor0.Text);
                        this.Hide();
                        frm1.Closed += (s, args) => this.Close();
                        frm1.Show();
                    }
                }
                else
                {
                    MessageBox.Show("We can't create Tic-Tac-Toe game for " +
                    SetValueForX + "x" + SetValueForY + " table X-O");
                }
            }
            else
            {
                MessageBox.Show("Fill Values");
            }

        }

        private void Start_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;
        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

    }
}
