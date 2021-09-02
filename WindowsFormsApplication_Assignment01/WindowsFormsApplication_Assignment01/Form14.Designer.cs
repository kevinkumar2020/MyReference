namespace WindowsFormsApplication_Assignment01
{
    partial class Form14
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
            this.btnequal = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnmins = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMr = new System.Windows.Forms.Button();
            this.btnMclose = new System.Windows.Forms.Button();
            this.btnMmins = new System.Windows.Forms.Button();
            this.btnone = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnMplus = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btneight = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnMstart = new System.Windows.Forms.Button();
            this.btnseven = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(406, 398);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(80, 30);
            this.btnequal.TabIndex = 20;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnzero
            // 
            this.btnzero.Location = new System.Drawing.Point(70, 398);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(80, 30);
            this.btnzero.TabIndex = 19;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(187, 398);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(80, 30);
            this.btndot.TabIndex = 18;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(298, 398);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(80, 30);
            this.btnmultiply.TabIndex = 17;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            // 
            // btnmins
            // 
            this.btnmins.Location = new System.Drawing.Point(406, 332);
            this.btnmins.Name = "btnmins";
            this.btnmins.Size = new System.Drawing.Size(80, 27);
            this.btnmins.TabIndex = 16;
            this.btnmins.Text = "-";
            this.btnmins.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMr);
            this.groupBox1.Controls.Add(this.btnMclose);
            this.groupBox1.Controls.Add(this.btnequal);
            this.groupBox1.Controls.Add(this.btnzero);
            this.groupBox1.Controls.Add(this.btndot);
            this.groupBox1.Controls.Add(this.btnmultiply);
            this.groupBox1.Controls.Add(this.btnMmins);
            this.groupBox1.Controls.Add(this.btnmins);
            this.groupBox1.Controls.Add(this.btnone);
            this.groupBox1.Controls.Add(this.btntwo);
            this.groupBox1.Controls.Add(this.btnMplus);
            this.groupBox1.Controls.Add(this.btnthree);
            this.groupBox1.Controls.Add(this.btnplus);
            this.groupBox1.Controls.Add(this.btneight);
            this.groupBox1.Controls.Add(this.btnnine);
            this.groupBox1.Controls.Add(this.btndivision);
            this.groupBox1.Controls.Add(this.btnfour);
            this.groupBox1.Controls.Add(this.btnfive);
            this.groupBox1.Controls.Add(this.btnsix);
            this.groupBox1.Controls.Add(this.btnMstart);
            this.groupBox1.Controls.Add(this.btnseven);
            this.groupBox1.Controls.Add(this.btnmod);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnOn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 609);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnMr
            // 
            this.btnMr.Location = new System.Drawing.Point(506, 263);
            this.btnMr.Name = "btnMr";
            this.btnMr.Size = new System.Drawing.Size(80, 30);
            this.btnMr.TabIndex = 22;
            this.btnMr.Text = "Mr";
            this.btnMr.UseVisualStyleBackColor = true;
            this.btnMr.Click += new System.EventHandler(this.btnMr_Click_1);
            // 
            // btnMclose
            // 
            this.btnMclose.Location = new System.Drawing.Point(506, 184);
            this.btnMclose.Name = "btnMclose";
            this.btnMclose.Size = new System.Drawing.Size(80, 30);
            this.btnMclose.TabIndex = 21;
            this.btnMclose.Text = "Mclose";
            this.btnMclose.UseVisualStyleBackColor = true;
            this.btnMclose.Click += new System.EventHandler(this.btnMclose_Click_1);
            // 
            // btnMmins
            // 
            this.btnMmins.Location = new System.Drawing.Point(506, 400);
            this.btnMmins.Name = "btnMmins";
            this.btnMmins.Size = new System.Drawing.Size(80, 27);
            this.btnMmins.TabIndex = 16;
            this.btnMmins.Text = "M-";
            this.btnMmins.UseVisualStyleBackColor = true;
            this.btnMmins.Click += new System.EventHandler(this.btnMmins_Click);
            // 
            // btnone
            // 
            this.btnone.Location = new System.Drawing.Point(70, 332);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(80, 27);
            this.btnone.TabIndex = 15;
            this.btnone.Text = "1";
            this.btnone.UseVisualStyleBackColor = true;
            // 
            // btntwo
            // 
            this.btntwo.Location = new System.Drawing.Point(187, 332);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(80, 27);
            this.btntwo.TabIndex = 14;
            this.btntwo.Text = "2";
            this.btntwo.UseVisualStyleBackColor = true;
            // 
            // btnMplus
            // 
            this.btnMplus.Location = new System.Drawing.Point(506, 331);
            this.btnMplus.Name = "btnMplus";
            this.btnMplus.Size = new System.Drawing.Size(80, 30);
            this.btnMplus.TabIndex = 12;
            this.btnMplus.Text = "M+";
            this.btnMplus.UseVisualStyleBackColor = true;
            this.btnMplus.Click += new System.EventHandler(this.btnMplus_Click);
            // 
            // btnthree
            // 
            this.btnthree.Location = new System.Drawing.Point(298, 332);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(80, 27);
            this.btnthree.TabIndex = 13;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(406, 263);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(80, 30);
            this.btnplus.TabIndex = 12;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            // 
            // btneight
            // 
            this.btneight.Location = new System.Drawing.Point(187, 184);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(80, 30);
            this.btneight.TabIndex = 11;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = true;
            // 
            // btnnine
            // 
            this.btnnine.Location = new System.Drawing.Point(298, 184);
            this.btnnine.Name = "btnnine";
            this.btnnine.Size = new System.Drawing.Size(80, 30);
            this.btnnine.TabIndex = 10;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = true;
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(406, 184);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(80, 30);
            this.btndivision.TabIndex = 9;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.btndivision_Click);
            // 
            // btnfour
            // 
            this.btnfour.Location = new System.Drawing.Point(70, 263);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(80, 30);
            this.btnfour.TabIndex = 8;
            this.btnfour.Text = "4";
            this.btnfour.UseVisualStyleBackColor = true;
            // 
            // btnfive
            // 
            this.btnfive.Location = new System.Drawing.Point(187, 263);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(80, 30);
            this.btnfive.TabIndex = 7;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = true;
            // 
            // btnsix
            // 
            this.btnsix.Location = new System.Drawing.Point(298, 263);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(80, 30);
            this.btnsix.TabIndex = 6;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            // 
            // btnMstart
            // 
            this.btnMstart.Location = new System.Drawing.Point(506, 104);
            this.btnMstart.Name = "btnMstart";
            this.btnMstart.Size = new System.Drawing.Size(80, 30);
            this.btnMstart.TabIndex = 4;
            this.btnMstart.Text = "Mstart";
            this.btnMstart.UseVisualStyleBackColor = true;
            this.btnMstart.Click += new System.EventHandler(this.btnMstart_Click);
            // 
            // btnseven
            // 
            this.btnseven.Location = new System.Drawing.Point(70, 184);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(80, 30);
            this.btnseven.TabIndex = 5;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = true;
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(406, 104);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(80, 30);
            this.btnmod.TabIndex = 4;
            this.btnmod.Text = "%";
            this.btnmod.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(298, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(187, 104);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(80, 30);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(70, 104);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(80, 30);
            this.btnOn.TabIndex = 1;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 733);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnmultiply;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnmins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btneight;
        private System.Windows.Forms.Button btnnine;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnfour;
        private System.Windows.Forms.Button btnfive;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMmins;
        private System.Windows.Forms.Button btnMplus;
        private System.Windows.Forms.Button btnMstart;
        private System.Windows.Forms.Button btnMr;
        private System.Windows.Forms.Button btnMclose;
    }
}