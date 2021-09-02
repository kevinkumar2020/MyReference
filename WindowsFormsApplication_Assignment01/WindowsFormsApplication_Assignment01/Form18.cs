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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        int totalSeconds;
        int questionNumber = 0;
        int Score = 0;
        int totalQuestionNumber = 10;

        private void Form18_Load(object sender, EventArgs e)
        {
            btnResult.Enabled = false;
            button1.Enabled = false;

            lblqus.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            questionNumber = 1;
            btnStart.Enabled = false;
            int Minutes = 5;
            int Secondes = 0;
            totalSeconds = (Minutes * 60) + Secondes;
            timer1.Enabled = true;
            lblqus.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            button1.Enabled = true;
            handelQuestions(questionNumber);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                int Minutes = (totalSeconds / 60);
                int Secondes = totalSeconds - (Minutes * 60);
                lblTimer.Text = Minutes.ToString() + ":" + Secondes.ToString();
                totalSeconds--;
            }else
            {
                timer1.Stop();
                lblTimer.Text = "00:00";
                MessageBox.Show("Time's Up..!");
                hendelEnabled();
                btnStart.Enabled = true;
            }
        }

        private void handelQuestions(int qnums)
        {
            switch (qnums)
            {
                case 1:
                    lblqus.Text = "1).Which organisation has released the ‘Global Forest Goals Report 2021’?";
                    radioButton1.Text = "World Bank";
                    radioButton2.Text = "FAO";
                    radioButton3.Text = "UN ECOSOC/";//
                    radioButton4.Text = "WWF";
                    if (radioButton3.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 2:
                    lblqus.Text = "2).The SDRF contribution is released in two equal instalments to the states, as per the recommendation of ……...?";
                    radioButton1.Text = "Plannig Commission";
                    radioButton2.Text = "Finance Commission/";//
                    radioButton3.Text = "NITI Aayog";
                    radioButton4.Text = "Supreme Court Of India";
                    if (radioButton2.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 3:
                    lblqus.Text = "3).Litani river and Qaraoun lake, which were making the mews recently, are located in which country?";
                    radioButton1.Text = "Laos";
                    radioButton2.Text = "Iran";
                    radioButton3.Text =  "Lebanon/";//
                    radioButton4.Text = "Israel";
                    if (radioButton2.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 4:
                    lblqus.Text = "4).As per the recent SEBI Guidelines, ……….. % salary of top executives be paid in mutual fund units ? ";
                    radioButton1.Text = "10";
                    radioButton2.Text = "20/";//
                    radioButton3.Text = "25";
                    radioButton4.Text = "50";
                    if (radioButton2.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 5:
                    lblqus.Text = "5).PM Jan Arogya Yojana was launched in line with which Sustainable Development Goal (SDG)? ";
                    radioButton1.Text = "SDG 1";
                    radioButton2.Text = "SDG 5";
                    radioButton3.Text = "SDG 3/";//
                    radioButton4.Text = "SDF 10";
                    if (radioButton2.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 6:
                    lblqus.Text = "6).Central Farm Machinery Training and Testing Institute (CFMTTI) is located in which state?";
                    radioButton1.Text = "Tamil Nadu";
                    radioButton2.Text = "Madhya Pradesh/";//
                    radioButton3.Text = "Andhra Pradesh";
                    radioButton4.Text = "Karnataka";
                    if (radioButton2.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 7:
                    lblqus.Text = "7).Which is the first Small Finance Bank formed from a cooperative bank in India?";
                    radioButton1.Text = "Equitas Small Finance Bank";
                    radioButton2.Text = "Jana Small Finance Bank";
                    radioButton3.Text = "Bandhan Small Finance Bank";
                    radioButton4.Text = "Shivalik Small Finance Bank/";//
                    if (radioButton4.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 8:
                    lblqus.Text = "8).Which business major has decided to buy online grocer Big Basket, and has approved CCI’s approval?";
                    radioButton1.Text = "Reliance Industries";
                    radioButton2.Text = "Adani Group";
                    radioButton3.Text = "Tata Group/";//
                    radioButton4.Text = "Aditya Birla Group";
                    if (radioButton3.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 9:
                    lblqus.Text = "9).Which country has launched the ‘Tianhe’ module to space?";
                    radioButton1.Text = "Russia";
                    radioButton2.Text = "Japan";
                    radioButton3.Text = "USA";
                    radioButton4.Text = "China/";//
                    if (radioButton4.Checked)
                    {
                        Score += 1;
                    }
                    break;
                case 10:
                    lblqus.Text = "10).Which company has constructed India’s first 3D-printed house?";
                    radioButton1.Text = "L&T";
                    radioButton2.Text = "Tata Construction";
                    radioButton3.Text = "Tvasta Manufacturing Solutions/";//
                    radioButton4.Text = "GMR Infra";
                    if (radioButton3.Checked)
                    {
                        Score += 1;
                    }
                    break;
            }
        }

       private void hendelEnabled()
        {
            timer1.Stop();
            MessageBox.Show("End Quiz");
            lblqus.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            button1.Enabled = false;
            btnResult.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(totalSeconds > 0)
            {
                if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
                {
                    questionNumber++;
                    if (totalQuestionNumber >= questionNumber)
                    {
                        handelQuestions(questionNumber);
                    }
                    else
                    {
                        hendelEnabled();
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Options", "Message");
                }

            }else
            {
                hendelEnabled();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Score + "/" + totalQuestionNumber, "Result");
        }
    }
}
