using System.Drawing;
using System.Windows.Forms;

namespace Example01
{
    partial class Form28
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
            SuspendLayout();
            // 
            // lblScore
            // 
            // 
            // Form28
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            System.Windows.Forms.AutoScaleMode autoScaleMode = AutoScaleMode;
            ClientSize = new Size(800, 450);
            Controls.Add(lblScore);
            Name = "Form28";
            Text = "Form28";
            Load += Form28_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
    }
}