using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void tbSox_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"D:\Wed_IT\C#\BuiDucKiem_2122110241\Caculator.txt", true);
            sw.WriteLine(tbKetQua.Text);
            sw.Close();
        }

        private void tbSoY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "+" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void tbNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }
    }
}
