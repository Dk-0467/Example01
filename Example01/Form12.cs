using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2; // Chọn chỉ số mặc định cho ComboBox
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString(); // Hiển thị chỉ số đã chọn
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string item = cb_Faculty.SelectedItem.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa: " + item; // Hiển thị thông tin khoa đã chọn
        }
    }
}
