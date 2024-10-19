using System.Drawing;
using System.Windows.Forms;

namespace Example01
{
    partial class Form18
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
            lbFavorite = new ListBox();
            lbSong = new ListBox();
            btDeselect = new Button();
            btSelect = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.Location = new Point(522, 119);
            lbFavorite.Margin = new Padding(3, 4, 3, 4);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(261, 404);
            lbFavorite.TabIndex = 17;
            // 
            // lbSong
            // 
            lbSong.FormattingEnabled = true;
            lbSong.Items.AddRange(new object[] { "Giấc mơ Chapi", "Đôi Mắt Pleiku", "Em Muốn Sống Bên Anh Trọn Đời", "H'Zen Lên Rẫy", "Còn Thương Nhau Thì Về Buôn Mê Thuột", "Ly Cà Phê Ban Mê", "Đi tìm lời ru mặt trời" });
            lbSong.Location = new Point(131, 119);
            lbSong.Margin = new Padding(3, 4, 3, 4);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(261, 404);
            lbSong.TabIndex = 16;
            lbSong.SelectedIndexChanged += lbSong_SelectedIndexChanged;
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(422, 345);
            btDeselect.Margin = new Padding(3, 4, 3, 4);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(64, 63);
            btDeselect.TabIndex = 13;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(422, 247);
            btSelect.Margin = new Padding(3, 4, 3, 4);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(64, 63);
            btSelect.TabIndex = 12;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 76);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 11;
            label2.Text = "Danh sách bài hát ưa thích";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 76);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 10;
            label1.Text = "Danh sách bài hát ";
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lbFavorite);
            Controls.Add(lbSong);
            Controls.Add(btDeselect);
            Controls.Add(btSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form18";
            Text = "Form18";
            Load += Form18_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbFavorite;
        private ListBox lbSong;
        private Button btDeselect;
        private Button btSelect;
        private Label label2;
        private Label label1;
    }
}