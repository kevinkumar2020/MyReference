namespace DesignDetail
{
    partial class frmData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNodelete = new System.Windows.Forms.Button();
            this.btnNoupdate = new System.Windows.Forms.Button();
            this.lblnomsg = new System.Windows.Forms.Label();
            this.btnNoadd = new System.Windows.Forms.Button();
            this.txtDesignNo = new System.Windows.Forms.TextBox();
            this.lblDesignNo = new System.Windows.Forms.Label();
            this.showDesignNo = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.lblDesignImage = new System.Windows.Forms.Label();
            this.btndesignimage = new System.Windows.Forms.Button();
            this.comboBoxg2designno = new System.Windows.Forms.ComboBox();
            this.tbldesignnoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBDesignDataSet1 = new DesignDetail.DBDesignDataSet1();
            this.lblg2designno = new System.Windows.Forms.Label();
            this.btng2delete = new System.Windows.Forms.Button();
            this.btng2update = new System.Windows.Forms.Button();
            this.lblg2msg = new System.Windows.Forms.Label();
            this.btng2save = new System.Windows.Forms.Button();
            this.tbldesignnoTableAdapter1 = new DesignDetail.DBDesignDataSet1TableAdapters.tbldesignnoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDesignNo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldesignnoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDesignDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNodelete);
            this.groupBox1.Controls.Add(this.btnNoupdate);
            this.groupBox1.Controls.Add(this.lblnomsg);
            this.groupBox1.Controls.Add(this.btnNoadd);
            this.groupBox1.Controls.Add(this.txtDesignNo);
            this.groupBox1.Controls.Add(this.lblDesignNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Design Number";
            // 
            // btnNodelete
            // 
            this.btnNodelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodelete.Location = new System.Drawing.Point(225, 187);
            this.btnNodelete.Name = "btnNodelete";
            this.btnNodelete.Size = new System.Drawing.Size(80, 40);
            this.btnNodelete.TabIndex = 9;
            this.btnNodelete.Text = "Delete";
            this.btnNodelete.UseVisualStyleBackColor = true;
            this.btnNodelete.Click += new System.EventHandler(this.btnNodelete_Click);
            // 
            // btnNoupdate
            // 
            this.btnNoupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoupdate.Location = new System.Drawing.Point(119, 187);
            this.btnNoupdate.Name = "btnNoupdate";
            this.btnNoupdate.Size = new System.Drawing.Size(80, 36);
            this.btnNoupdate.TabIndex = 4;
            this.btnNoupdate.Text = "Update";
            this.btnNoupdate.UseVisualStyleBackColor = true;
            this.btnNoupdate.Click += new System.EventHandler(this.btnNoupdate_Click);
            // 
            // lblnomsg
            // 
            this.lblnomsg.AutoSize = true;
            this.lblnomsg.Location = new System.Drawing.Point(62, 136);
            this.lblnomsg.Name = "lblnomsg";
            this.lblnomsg.Size = new System.Drawing.Size(0, 20);
            this.lblnomsg.TabIndex = 6;
            // 
            // btnNoadd
            // 
            this.btnNoadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoadd.Location = new System.Drawing.Point(11, 187);
            this.btnNoadd.Name = "btnNoadd";
            this.btnNoadd.Size = new System.Drawing.Size(80, 40);
            this.btnNoadd.TabIndex = 6;
            this.btnNoadd.Text = "Save";
            this.btnNoadd.UseVisualStyleBackColor = true;
            this.btnNoadd.Click += new System.EventHandler(this.btnNoadd_Click);
            // 
            // txtDesignNo
            // 
            this.txtDesignNo.Location = new System.Drawing.Point(136, 75);
            this.txtDesignNo.Name = "txtDesignNo";
            this.txtDesignNo.Size = new System.Drawing.Size(169, 26);
            this.txtDesignNo.TabIndex = 5;
            // 
            // lblDesignNo
            // 
            this.lblDesignNo.AutoSize = true;
            this.lblDesignNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignNo.Location = new System.Drawing.Point(18, 76);
            this.lblDesignNo.Name = "lblDesignNo";
            this.lblDesignNo.Size = new System.Drawing.Size(94, 24);
            this.lblDesignNo.TabIndex = 3;
            this.lblDesignNo.Text = "DesignNo";
            // 
            // showDesignNo
            // 
            this.showDesignNo.AllowUserToAddRows = false;
            this.showDesignNo.AllowUserToDeleteRows = false;
            this.showDesignNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDesignNo.Location = new System.Drawing.Point(15, 27);
            this.showDesignNo.Name = "showDesignNo";
            this.showDesignNo.ReadOnly = true;
            this.showDesignNo.Size = new System.Drawing.Size(312, 275);
            this.showDesignNo.TabIndex = 3;
            this.showDesignNo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDesignNo_CellDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.showDesignNo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 320);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Design Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxImage);
            this.groupBox2.Controls.Add(this.lblDesignImage);
            this.groupBox2.Controls.Add(this.btndesignimage);
            this.groupBox2.Controls.Add(this.comboBoxg2designno);
            this.groupBox2.Controls.Add(this.lblg2designno);
            this.groupBox2.Controls.Add(this.btng2delete);
            this.groupBox2.Controls.Add(this.btng2update);
            this.groupBox2.Controls.Add(this.lblg2msg);
            this.groupBox2.Controls.Add(this.btng2save);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(400, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 595);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Design Image";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(12, 172);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(308, 236);
            this.pictureBoxImage.TabIndex = 13;
            this.pictureBoxImage.TabStop = false;
            // 
            // lblDesignImage
            // 
            this.lblDesignImage.AutoSize = true;
            this.lblDesignImage.Location = new System.Drawing.Point(18, 85);
            this.lblDesignImage.Name = "lblDesignImage";
            this.lblDesignImage.Size = new System.Drawing.Size(53, 20);
            this.lblDesignImage.TabIndex = 12;
            this.lblDesignImage.Text = "label1";
            // 
            // btndesignimage
            // 
            this.btndesignimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesignimage.Location = new System.Drawing.Point(11, 126);
            this.btndesignimage.Name = "btndesignimage";
            this.btndesignimage.Size = new System.Drawing.Size(300, 40);
            this.btndesignimage.TabIndex = 6;
            this.btndesignimage.Text = "Upload Design Image";
            this.btndesignimage.UseVisualStyleBackColor = true;
            this.btndesignimage.Click += new System.EventHandler(this.btndesignimage_Click);
            // 
            // comboBoxg2designno
            // 
            this.comboBoxg2designno.DataSource = this.tbldesignnoBindingSource1;
            this.comboBoxg2designno.DisplayMember = "DesignNo";
            this.comboBoxg2designno.FormattingEnabled = true;
            this.comboBoxg2designno.Location = new System.Drawing.Point(136, 39);
            this.comboBoxg2designno.Name = "comboBoxg2designno";
            this.comboBoxg2designno.Size = new System.Drawing.Size(169, 28);
            this.comboBoxg2designno.TabIndex = 11;
            this.comboBoxg2designno.ValueMember = "DesignNo";
            // 
            // tbldesignnoBindingSource1
            // 
            this.tbldesignnoBindingSource1.DataMember = "tbldesignno";
            this.tbldesignnoBindingSource1.DataSource = this.dBDesignDataSet1;
            // 
            // dBDesignDataSet1
            // 
            this.dBDesignDataSet1.DataSetName = "DBDesignDataSet1";
            this.dBDesignDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblg2designno
            // 
            this.lblg2designno.AutoSize = true;
            this.lblg2designno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblg2designno.Location = new System.Drawing.Point(18, 39);
            this.lblg2designno.Name = "lblg2designno";
            this.lblg2designno.Size = new System.Drawing.Size(94, 24);
            this.lblg2designno.TabIndex = 10;
            this.lblg2designno.Text = "DesignNo";
            // 
            // btng2delete
            // 
            this.btng2delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btng2delete.Location = new System.Drawing.Point(225, 448);
            this.btng2delete.Name = "btng2delete";
            this.btng2delete.Size = new System.Drawing.Size(80, 40);
            this.btng2delete.TabIndex = 9;
            this.btng2delete.Text = "Delete";
            this.btng2delete.UseVisualStyleBackColor = true;
            // 
            // btng2update
            // 
            this.btng2update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btng2update.Location = new System.Drawing.Point(119, 448);
            this.btng2update.Name = "btng2update";
            this.btng2update.Size = new System.Drawing.Size(80, 36);
            this.btng2update.TabIndex = 4;
            this.btng2update.Text = "Update";
            this.btng2update.UseVisualStyleBackColor = true;
            // 
            // lblg2msg
            // 
            this.lblg2msg.AutoSize = true;
            this.lblg2msg.Location = new System.Drawing.Point(18, 411);
            this.lblg2msg.Name = "lblg2msg";
            this.lblg2msg.Size = new System.Drawing.Size(54, 20);
            this.lblg2msg.TabIndex = 6;
            this.lblg2msg.Text = "image";
            // 
            // btng2save
            // 
            this.btng2save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btng2save.Location = new System.Drawing.Point(11, 448);
            this.btng2save.Name = "btng2save";
            this.btng2save.Size = new System.Drawing.Size(80, 40);
            this.btng2save.TabIndex = 6;
            this.btng2save.Text = "Save";
            this.btng2save.UseVisualStyleBackColor = true;
            this.btng2save.Click += new System.EventHandler(this.btng2save_Click);
            // 
            // tbldesignnoTableAdapter1
            // 
            this.tbldesignnoTableAdapter1.ClearBeforeFill = true;
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmData";
            this.Text = "frmData";
            this.Load += new System.EventHandler(this.frmData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDesignNo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldesignnoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDesignDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNoadd;
        private System.Windows.Forms.TextBox txtDesignNo;
        private System.Windows.Forms.Label lblnomsg;
        private System.Windows.Forms.DataGridView showDesignNo;
        private System.Windows.Forms.Button btnNodelete;
        private System.Windows.Forms.Button btnNoupdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxg2designno;
        protected System.Windows.Forms.Label lblg2designno;
        private System.Windows.Forms.Button btng2delete;
        private System.Windows.Forms.Button btng2update;
        private System.Windows.Forms.Label lblg2msg;
        private System.Windows.Forms.Button btng2save;
        protected System.Windows.Forms.Label lblDesignNo;
        private DBDesignDataSet1 dBDesignDataSet1;
        private System.Windows.Forms.BindingSource tbldesignnoBindingSource1;
        private DBDesignDataSet1TableAdapters.tbldesignnoTableAdapter tbldesignnoTableAdapter1;
        private System.Windows.Forms.Button btndesignimage;
        private System.Windows.Forms.Label lblDesignImage;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}