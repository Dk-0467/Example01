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
    public partial class Form10 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form10()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbDishplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbDishplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbDishplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbDishplay.Text += bt3.Text;
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(tbDishplay.Text);
            if(opr == "+")
                tbDishplay.Text = (workingMemory+ secondValue).ToString();
            if (opr == "*")
                tbDishplay.Text = (workingMemory * secondValue).ToString();
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(tbDishplay.Text);
            tbDishplay.Clear();
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(tbDishplay.Text);
            tbDishplay.Clear();
        }
    }
}
