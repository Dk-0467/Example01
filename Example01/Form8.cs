using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void tbCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKetQua.Text =kq.ToString();
        }

        private void tbNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKetQua.Text = kq.ToString();
        }

        private void tbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
