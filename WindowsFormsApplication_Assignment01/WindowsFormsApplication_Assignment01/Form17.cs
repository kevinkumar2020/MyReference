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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxDay.Text = monthCalendar1.SelectionRange.Start.Day.ToString();
            textBoxMonth.Text = monthCalendar1.SelectionRange.Start.Month.ToString();
            textBoxYear.Text = monthCalendar1.SelectionRange.Start.Year.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBoxDay.Text = dateTimePicker1.Value.Day.ToString();
            textBoxMonth.Text = dateTimePicker1.Value.Month.ToString();
            textBoxYear.Text = dateTimePicker1.Value.Year.ToString();
        }
    }
}
