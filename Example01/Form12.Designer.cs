namespace Example01
{
    partial class Form12
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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.btOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Kế toán",
            "Cơ khí",
            "Điện",
            "Hóa"});
            this.cb_Faculty.Location = new System.Drawing.Point(12, 13);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(414, 24);
            this.cb_Faculty.TabIndex = 8;
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedIndexChanged); // Gán sự kiện
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(331, 205);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(84, 47);
            this.btOK.TabIndex = 7;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click); // Gán sự kiện
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 62);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(414, 118);
            this.tbDisplay.TabIndex = 5;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 268);
            this.Controls.Add(this.cb_Faculty);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDisplay);
            this.Name = "Form12";
            this.Text = "Chọn Khoa";
            this.Load += new System.EventHandler(this.Form12_Load); // Gán sự kiện cho Load
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbDisplay;
    }
}
