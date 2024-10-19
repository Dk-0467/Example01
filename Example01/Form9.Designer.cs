namespace Example01
{
    partial class Form9
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
            this.tbThoat = new System.Windows.Forms.Button();
            this.tbNhan = new System.Windows.Forms.Button();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSox = new System.Windows.Forms.TextBox();
            this.tbCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbThoat
            // 
            this.tbThoat.Location = new System.Drawing.Point(346, 313);
            this.tbThoat.Name = "tbThoat";
            this.tbThoat.Size = new System.Drawing.Size(96, 37);
            this.tbThoat.TabIndex = 17;
            this.tbThoat.Text = "Thoát";
            this.tbThoat.UseVisualStyleBackColor = true;
            // 
            // tbNhan
            // 
            this.tbNhan.Location = new System.Drawing.Point(261, 313);
            this.tbNhan.Name = "tbNhan";
            this.tbNhan.Size = new System.Drawing.Size(79, 37);
            this.tbNhan.TabIndex = 16;
            this.tbNhan.Text = "Nhân";
            this.tbNhan.UseVisualStyleBackColor = true;
            this.tbNhan.Click += new System.EventHandler(this.tbNhan_Click);
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(89, 134);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(337, 161);
            this.tbKetQua.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kết quả";
            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(89, 85);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(190, 22);
            this.tbSoY.TabIndex = 13;
            this.tbSoY.TextChanged += new System.EventHandler(this.tbSoY_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số y";
            // 
            // tbSox
            // 
            this.tbSox.Location = new System.Drawing.Point(89, 25);
            this.tbSox.Name = "tbSox";
            this.tbSox.Size = new System.Drawing.Size(190, 22);
            this.tbSox.TabIndex = 11;
            this.tbSox.TextChanged += new System.EventHandler(this.tbSox_TextChanged);
            // 
            // tbCong
            // 
            this.tbCong.Location = new System.Drawing.Point(171, 313);
            this.tbCong.Name = "tbCong";
            this.tbCong.Size = new System.Drawing.Size(84, 37);
            this.tbCong.TabIndex = 10;
            this.tbCong.Text = "Cộng ";
            this.tbCong.UseVisualStyleBackColor = true;
            this.tbCong.Click += new System.EventHandler(this.tbCong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số x";
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(30, 313);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(84, 37);
            this.btLuu.TabIndex = 18;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 378);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbThoat);
            this.Controls.Add(this.tbNhan);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSox);
            this.Controls.Add(this.tbCong);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbThoat;
        private System.Windows.Forms.Button tbNhan;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSox;
        private System.Windows.Forms.Button tbCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLuu;
    }
}