namespace Example01
{
    partial class Form13
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Location = new System.Drawing.Point(12, 29);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(414, 24);
            this.cb_Faculty.TabIndex = 12;
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedIndexChanged); // Gán sự kiện
            this.btOK.Location = new System.Drawing.Point(331, 221);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(84, 47);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click); // Gán sự kiện

            this.button1.Location = new System.Drawing.Point(230, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.tbDisplay.Location = new System.Drawing.Point(12, 78);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(414, 118);
            this.tbDisplay.TabIndex = 9;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 308);
            this.Controls.Add(this.cb_Faculty);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDisplay);
            this.Name = "Form13";
            this.Text = "Form13";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}
