using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesignDetail
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kevin\OneDrive\Documents\visual studio 2015\Projects\DesignDetail\DesignDetail\DBDesign.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter ds;
        public Form1()
        {
            InitializeComponent();
            checkConnection();
        }
        public void checkConnection()
        {
            try
            {
                con.Open();
                lblConnection.Text = "Connect..!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

       
        private void dataEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach ( Form f in Application.OpenForms)
            {
                if (f.Text == "frmData")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                frmData f2 = new frmData();
                //f2.MdiParent = this;
                f2.Show();
            }
        }
    }
}
