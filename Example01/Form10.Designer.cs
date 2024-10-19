namespace Example01
{
    partial class Form10
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
            this.btEquals = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.tbDishplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btEquals
            // 
            this.btEquals.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btEquals.Location = new System.Drawing.Point(262, 135);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(51, 54);
            this.btEquals.TabIndex = 17;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = false;
            this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Location = new System.Drawing.Point(195, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 54);
            this.button6.TabIndex = 16;
            this.button6.Text = ".";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btMul
            // 
            this.btMul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btMul.Location = new System.Drawing.Point(122, 135);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(51, 54);
            this.btMul.TabIndex = 15;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = false;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btPlus
            // 
            this.btPlus.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btPlus.Location = new System.Drawing.Point(52, 135);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(51, 54);
            this.btPlus.TabIndex = 14;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = false;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt3.Location = new System.Drawing.Point(262, 75);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(51, 54);
            this.bt3.TabIndex = 13;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt2.Location = new System.Drawing.Point(195, 75);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(51, 54);
            this.bt2.TabIndex = 12;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt1.Location = new System.Drawing.Point(122, 75);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(51, 54);
            this.bt1.TabIndex = 11;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bt0.Location = new System.Drawing.Point(52, 75);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(51, 54);
            this.bt0.TabIndex = 10;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // tbDishplay
            // 
            this.tbDishplay.Location = new System.Drawing.Point(39, 27);
            this.tbDishplay.Multiline = true;
            this.tbDishplay.Name = "tbDishplay";
            this.tbDishplay.Size = new System.Drawing.Size(274, 42);
            this.tbDishplay.TabIndex = 9;
            this.tbDishplay.UseWaitCursor = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 274);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.tbDishplay);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.TextBox tbDishplay;
    }
}