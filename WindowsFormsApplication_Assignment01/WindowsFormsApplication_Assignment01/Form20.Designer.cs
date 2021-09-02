namespace WindowsFormsApplication_Assignment01
{
    partial class Form20
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblEmailMessage = new System.Windows.Forms.Label();
            this.lblDOBMessage = new System.Windows.Forms.Label();
            this.lblMobileMessage = new System.Windows.Forms.Label();
            this.lblTelephoneMessage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DateOfBirth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telephone";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(204, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(204, 78);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 22);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(204, 166);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(150, 22);
            this.textBoxTelephone.TabIndex = 6;
            this.textBoxTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelephone_Validating);
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Location = new System.Drawing.Point(204, 207);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(150, 22);
            this.textBoxMobile.TabIndex = 7;
            this.textBoxMobile.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMobile_Validating);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(204, 119);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDOB.TabIndex = 8;
            this.dateTimePickerDOB.ValueChanged += new System.EventHandler(this.dateTimePickerDOB_ValueChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(147, 312);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblEmailMessage
            // 
            this.lblEmailMessage.AutoSize = true;
            this.lblEmailMessage.Location = new System.Drawing.Point(428, 81);
            this.lblEmailMessage.Name = "lblEmailMessage";
            this.lblEmailMessage.Size = new System.Drawing.Size(46, 17);
            this.lblEmailMessage.TabIndex = 10;
            this.lblEmailMessage.Text = "label6";
            // 
            // lblDOBMessage
            // 
            this.lblDOBMessage.AutoSize = true;
            this.lblDOBMessage.Location = new System.Drawing.Point(428, 124);
            this.lblDOBMessage.Name = "lblDOBMessage";
            this.lblDOBMessage.Size = new System.Drawing.Size(46, 17);
            this.lblDOBMessage.TabIndex = 11;
            this.lblDOBMessage.Text = "label6";
            // 
            // lblMobileMessage
            // 
            this.lblMobileMessage.AutoSize = true;
            this.lblMobileMessage.Location = new System.Drawing.Point(428, 210);
            this.lblMobileMessage.Name = "lblMobileMessage";
            this.lblMobileMessage.Size = new System.Drawing.Size(46, 17);
            this.lblMobileMessage.TabIndex = 12;
            this.lblMobileMessage.Text = "label6";
            // 
            // lblTelephoneMessage
            // 
            this.lblTelephoneMessage.AutoSize = true;
            this.lblTelephoneMessage.Location = new System.Drawing.Point(428, 169);
            this.lblTelephoneMessage.Name = "lblTelephoneMessage";
            this.lblTelephoneMessage.Size = new System.Drawing.Size(46, 17);
            this.lblTelephoneMessage.TabIndex = 12;
            this.lblTelephoneMessage.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Format: 123-456-7890";
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTelephoneMessage);
            this.Controls.Add(this.lblMobileMessage);
            this.Controls.Add(this.lblDOBMessage);
            this.Controls.Add(this.lblEmailMessage);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblEmailMessage;
        private System.Windows.Forms.Label lblDOBMessage;
        private System.Windows.Forms.Label lblMobileMessage;
        private System.Windows.Forms.Label lblTelephoneMessage;
        private System.Windows.Forms.Label label6;
    }
}