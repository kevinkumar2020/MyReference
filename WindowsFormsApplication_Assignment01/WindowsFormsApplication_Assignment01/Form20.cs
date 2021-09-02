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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxEmail.Text == "" || textBoxTelephone.Text == "" || textBoxMobile.Text == "")
            {
                MessageBox.Show("Please File The Form Detail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = textBoxEmail.Text;
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (expr.IsMatch(email))
            {
                lblEmailMessage.Text = "Valid Email";
            }
            else
            {
                lblEmailMessage.Text = "InValid Email";
                textBoxEmail.Focus();
            }
        }

        private void textBoxMobile_Validating(object sender, CancelEventArgs e)
        {
            string mobilenum = textBoxMobile.Text;
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[7-9][0-9]{9}");
            if (expr.IsMatch(mobilenum)  && mobilenum.Length == 10)
            {
                lblMobileMessage.Text = "Valid Mobile Number";
            }
            else
            {
                lblMobileMessage.Text = "InValid Mobile Number";
                textBoxMobile.Focus();
            }
        }

        private void textBoxTelephone_Validating(object sender, CancelEventArgs e)
        {
            string telephonenum = textBoxTelephone.Text;
        System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}");
            if (expr.IsMatch(telephonenum)  && telephonenum.Length == 12)
            {
                lblTelephoneMessage.Text = "Valid Telephone Number";
            }
            else
            {
                lblTelephoneMessage.Text = "InValid Telephone Number";
                textBoxTelephone.Focus();
            }
        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {
            int year = Int32.Parse( dateTimePickerDOB.Value.Year.ToString());
            int currentYear = Int32.Parse(DateTime.Today.Year.ToString());
            if (currentYear - year > 18)
            {
                lblDOBMessage.Text = "Valid DateOfBirth";
            }else
            {
                lblDOBMessage.Text = "Invalid DateOdBith";
                dateTimePickerDOB.Focus();
            }
        }
    }
}
