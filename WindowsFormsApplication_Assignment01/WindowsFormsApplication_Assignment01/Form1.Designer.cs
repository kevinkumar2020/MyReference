namespace WindowsFormsApplication_Assignment01
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnLeftMove = new System.Windows.Forms.Button();
            this.btnRightMove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButtonHCF = new System.Windows.Forms.RadioButton();
            this.radioButtonLCM = new System.Windows.Forms.RadioButton();
            this.labelMessage = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBoxDateDisplay = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g"});
            this.listBox1.Location = new System.Drawing.Point(85, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(421, 84);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(120, 84);
            this.listBox2.TabIndex = 1;
            // 
            // btnLeftMove
            // 
            this.btnLeftMove.Location = new System.Drawing.Point(267, 145);
            this.btnLeftMove.Name = "btnLeftMove";
            this.btnLeftMove.Size = new System.Drawing.Size(75, 23);
            this.btnLeftMove.TabIndex = 3;
            this.btnLeftMove.Text = "<<";
            this.btnLeftMove.UseVisualStyleBackColor = true;
            this.btnLeftMove.Click += new System.EventHandler(this.btnLeftMove_Click);
            this.btnLeftMove.MouseHover += new System.EventHandler(this.btnLeftMove_MouseHover);
            // 
            // btnRightMove
            // 
            this.btnRightMove.Location = new System.Drawing.Point(267, 84);
            this.btnRightMove.Name = "btnRightMove";
            this.btnRightMove.Size = new System.Drawing.Size(75, 23);
            this.btnRightMove.TabIndex = 4;
            this.btnRightMove.Text = ">>";
            this.btnRightMove.UseVisualStyleBackColor = true;
            this.btnRightMove.Click += new System.EventHandler(this.btnRightMove_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // radioButtonHCF
            // 
            this.radioButtonHCF.AutoSize = true;
            this.radioButtonHCF.Location = new System.Drawing.Point(470, 238);
            this.radioButtonHCF.Name = "radioButtonHCF";
            this.radioButtonHCF.Size = new System.Drawing.Size(56, 21);
            this.radioButtonHCF.TabIndex = 7;
            this.radioButtonHCF.TabStop = true;
            this.radioButtonHCF.Text = "HCF";
            this.radioButtonHCF.UseVisualStyleBackColor = true;
            this.radioButtonHCF.CheckedChanged += new System.EventHandler(this.radioButtonHCF_CheckedChanged);
            // 
            // radioButtonLCM
            // 
            this.radioButtonLCM.AutoSize = true;
            this.radioButtonLCM.Location = new System.Drawing.Point(470, 296);
            this.radioButtonLCM.Name = "radioButtonLCM";
            this.radioButtonLCM.Size = new System.Drawing.Size(57, 21);
            this.radioButtonLCM.TabIndex = 8;
            this.radioButtonLCM.TabStop = true;
            this.radioButtonLCM.Text = "LCM";
            this.radioButtonLCM.UseVisualStyleBackColor = true;
            this.radioButtonLCM.CheckedChanged += new System.EventHandler(this.radioButtonLCM_CheckedChanged);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(227, 351);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(46, 17);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(872, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.MouseHover += new System.EventHandler(this.dateTimePicker1_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 436);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseHover += new System.EventHandler(this.dataGridView1_MouseHover);
            // 
            // listBoxDateDisplay
            // 
            this.listBoxDateDisplay.FormattingEnabled = true;
            this.listBoxDateDisplay.ItemHeight = 16;
            this.listBoxDateDisplay.Location = new System.Drawing.Point(872, 207);
            this.listBoxDateDisplay.Name = "listBoxDateDisplay";
            this.listBoxDateDisplay.Size = new System.Drawing.Size(120, 84);
            this.listBoxDateDisplay.TabIndex = 12;
            this.listBoxDateDisplay.MouseHover += new System.EventHandler(this.listBox3_MouseHover);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(872, 146);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1039, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.listBoxDateDisplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.radioButtonLCM);
            this.Controls.Add(this.radioButtonHCF);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRightMove);
            this.Controls.Add(this.btnLeftMove);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnLeftMove;
        private System.Windows.Forms.Button btnRightMove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButtonHCF;
        private System.Windows.Forms.RadioButton radioButtonLCM;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxDateDisplay;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
    }
}

