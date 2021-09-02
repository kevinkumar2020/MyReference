namespace WindowsFormsApplication_Assignment01
{
    partial class Form11
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelOn = new System.Windows.Forms.Label();
            this.textBoxOn = new System.Windows.Forms.TextBox();
            this.textBoxOff = new System.Windows.Forms.TextBox();
            this.labelOff = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNToolStripMenuItem,
            this.oFFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oNToolStripMenuItem
            // 
            this.oNToolStripMenuItem.Name = "oNToolStripMenuItem";
            this.oNToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.oNToolStripMenuItem.Text = "ON";
            this.oNToolStripMenuItem.Click += new System.EventHandler(this.oNToolStripMenuItem_Click);
            // 
            // oFFToolStripMenuItem
            // 
            this.oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
            this.oFFToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.oFFToolStripMenuItem.Text = "OFF";
            this.oFFToolStripMenuItem.Click += new System.EventHandler(this.oFFToolStripMenuItem_Click);
            // 
            // labelOn
            // 
            this.labelOn.AutoSize = true;
            this.labelOn.Location = new System.Drawing.Point(39, 82);
            this.labelOn.Name = "labelOn";
            this.labelOn.Size = new System.Drawing.Size(27, 17);
            this.labelOn.TabIndex = 0;
            this.labelOn.Text = "On";
            // 
            // textBoxOn
            // 
            this.textBoxOn.Location = new System.Drawing.Point(97, 79);
            this.textBoxOn.Name = "textBoxOn";
            this.textBoxOn.Size = new System.Drawing.Size(100, 22);
            this.textBoxOn.TabIndex = 1;
            // 
            // textBoxOff
            // 
            this.textBoxOff.Location = new System.Drawing.Point(97, 127);
            this.textBoxOff.Name = "textBoxOff";
            this.textBoxOff.Size = new System.Drawing.Size(100, 22);
            this.textBoxOff.TabIndex = 3;
            // 
            // labelOff
            // 
            this.labelOff.AutoSize = true;
            this.labelOff.Location = new System.Drawing.Point(39, 130);
            this.labelOff.Name = "labelOff";
            this.labelOff.Size = new System.Drawing.Size(27, 17);
            this.labelOff.TabIndex = 2;
            this.labelOff.Text = "Off";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 388);
            this.Controls.Add(this.textBoxOff);
            this.Controls.Add(this.labelOff);
            this.Controls.Add(this.textBoxOn);
            this.Controls.Add(this.labelOn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form11";
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem;
        private System.Windows.Forms.Label labelOn;
        private System.Windows.Forms.TextBox textBoxOn;
        private System.Windows.Forms.TextBox textBoxOff;
        private System.Windows.Forms.Label labelOff;
    }
}