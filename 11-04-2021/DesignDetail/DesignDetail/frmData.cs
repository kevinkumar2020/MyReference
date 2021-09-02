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
using System.IO;

namespace DesignDetail
{
    public partial class frmData : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\kevin\OneDrive\Documents\visual studio 2015\Projects\DesignDetail\DesignDetail\DBDesign.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //use for update and delete recode
        int idNo;
        //fordesignimage
        //String imageLocation = "";
        public frmData()
        {
            InitializeComponent();
            designnoDisplay();
        }

        private void btnNoadd_Click(object sender, EventArgs e)
        {
            if( txtDesignNo.Text != "")
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM tbldesignno WHERE DesignNo = '" + txtDesignNo.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Detail Already Exist");
                    txtDesignNo.Clear();
                }
                else
                {
                    String q = "INSERT INTO tbldesignno VALUES('" + txtDesignNo.Text + "')";
                    cmd = new SqlCommand(q, con);
                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            lblnomsg.Text = "Add Detail SuccessFully";
                            txtDesignNo.Clear();
                            con.Close();
                            designnoDisplay();
                            con.Open();
                        }
                        else
                        {
                            lblnomsg.Text = "Oops Somethig Wents Worng";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Problem In Insert");
                    }

                }
            }else
            {
                lblnomsg.Text = "Please Enter Design Number";
            }
            
            //String q = "INSERT INTO tbldesignno VALUES(@designno)";
            //cmd.Parameters.AddWithValue("@designno", txtDesignNo);
            con.Close();
        }
        public void designnoDisplay()
        {
            con.Open();
            string q = "SELECT * FROM tbldesignno";
            da = new SqlDataAdapter(q, con);
            dt = new DataTable();
            da.Fill(dt);
            showDesignNo.DataSource = dt;
            con.Close();
        }


        private void showDesignNo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idNo = Convert.ToInt32(showDesignNo.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtDesignNo.Text = showDesignNo.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnNoupdate_Click(object sender, EventArgs e)
        {
            if (txtDesignNo.Text != "")
            {
                con.Open();
                da = new SqlDataAdapter("SELECT * FROM tbldesignno WHERE DesignNo = '" + txtDesignNo.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Detail Already Exist");
                    txtDesignNo.Clear();
                }
                else
                {
                    cmd = new SqlCommand("UPDATE tbldesignno set DesignNo = '" + txtDesignNo.Text + "' WHERE IdNo = '" + idNo + "'", con);
                    try
                    {
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            lblnomsg.Text = "Update Detail SuccessFully";
                            txtDesignNo.Clear();
                            con.Close();
                            designnoDisplay();
                            con.Open();
                        }
                        else
                        {
                            lblnomsg.Text = "Oops Somethig Wents Worng";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Problem In Update");
                    }
                }

                con.Close();
            }
            else
            {
                lblnomsg.Text = "Please Select Design Number";
            }
            
        }

        private void btnNodelete_Click(object sender, EventArgs e)
        {
            if (txtDesignNo.Text != "")
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM tbldesignno WHERE IdNo='" + idNo + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data record deleted!", "Conform Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                    designnoDisplay();
                    //Clear();
                    //DisableButtons();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Problem In Delete");
                }
            }else
            {
                lblnomsg.Text = "Please Enter Design Number";
            }
            
            
        }

        private void frmData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDesignDataSet1.tbldesignno' table. You can move, or remove it, as needed.
            this.tbldesignnoTableAdapter1.Fill(this.dBDesignDataSet1.tbldesignno);

        }

        private void btndesignimage_Click(object sender, EventArgs e)
        {
            //To where your opendialog box get starting location. My initial directory location is desktop.
            //openFileDialog1.InitialDirectory = "C://Desktop";
            //Your opendialog box title name.
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Select image to be upload.";
            //which type image format you want to upload in database. just add them.
            open.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            //FilterIndex property represents the index of the filter currently selected in the file dialog box.
            open.FilterIndex = 1;
            try
            { 
                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        string path = Path.GetFullPath(open.FileName);
                        //label1.Text = path;
                        pictureBoxImage.ImageLocation = path;
                        pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }

        }

        private void btng2save_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                string filename = Path.GetFileName(open.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid image.");
                }
                else
                {
                    //we already define our connection globaly. We are just calling the object of connection.
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbldesignimage values('" + comboBoxg2designno.Text.ToString() + "','\\DesignImages\\" + filename+ "')", con);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    File.Copy(open.FileName, path + "\\DesignImages\\" + filename);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lblg2msg.Text = "Image uploaded successfully.";
                    //MessageBox.Show("Image uploaded successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "File Already exits");
            }
        }
    }
}
