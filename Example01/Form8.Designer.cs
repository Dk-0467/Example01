namespace Example01
{
    partial class Form8
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
            this.tbCong = new System.Windows.Forms.Button();
            this.tbSox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.tbNhan = new System.Windows.Forms.Button();
            this.tbThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số x";
            // 
            // tbCong
            // 
            this.tbCong.Location = new System.Drawing.Point(67, 212);
            this.tbCong.Name = "tbCong";
            this.tbCong.Size = new System.Drawing.Size(84, 37);
            this.tbCong.TabIndex = 1;
            this.tbCong.Text = "Cộng ";
            this.tbCong.UseVisualStyleBackColor = true;
            this.tbCong.Click += new System.EventHandler(this.tbCong_Click);
            // 
            // tbSox
            // 
            this.tbSox.Location = new System.Drawing.Point(135, 39);
            this.tbSox.Name = "tbSox";
            this.tbSox.Size = new System.Drawing.Size(190, 22);
            this.tbSox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số y";
            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(135, 99);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(190, 22);
            this.tbSoY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả";
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(135, 148);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(190, 22);
            this.tbKetQua.TabIndex = 6;
            // 
            // tbNhan
            // 
            this.tbNhan.Location = new System.Drawing.Point(167, 212);
            this.tbNhan.Name = "tbNhan";
            this.tbNhan.Size = new System.Drawing.Size(79, 37);
            this.tbNhan.TabIndex = 7;
            this.tbNhan.Text = "Nhân";
            this.tbNhan.UseVisualStyleBackColor = true;
            this.tbNhan.Click += new System.EventHandler(this.tbNhan_Click);
            // 
            // tbThoat
            // 
            this.tbThoat.Location = new System.Drawing.Point(310, 212);
            this.tbThoat.Name = "tbThoat";
            this.tbThoat.Size = new System.Drawing.Size(96, 37);
            this.tbThoat.TabIndex = 8;
            this.tbThoat.Text = "Thoát";
            this.tbThoat.UseVisualStyleBackColor = true;
            this.tbThoat.Click += new System.EventHandler(this.tbThoat_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 283);
            this.Controls.Add(this.tbThoat);
            this.Controls.Add(this.tbNhan);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSox);
            this.Controls.Add(this.tbCong);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbCong;
        private System.Windows.Forms.TextBox tbSox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button tbNhan;
        private System.Windows.Forms.Button tbThoat;
    }
}

