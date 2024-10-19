using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Example01
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;

            if (radioButton1.Checked == true) // rbMale thành radioButton1
            {
                msg += "Ông. ";
            }

            if (radioButton2.Checked == true) // rbFemale thành radioButton2
            {
                msg += "Bà. ";
            }

            if (checkBox1.Checked == true) // ckDiscount thành checkBox1
            {
                disc = 5;
            }

            textBox3.Text = msg + textBox1.Text + " được giảm " + disc.ToString() + "%" + "\r\n"; // tbName thành textBox1, tbResult thành textBox3
        }
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) // ckDiscount thành checkBox1
            {
                textBox2.Enabled = true; // tbDiscount thành textBox2
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
