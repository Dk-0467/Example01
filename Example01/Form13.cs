using System;
using System.Collections;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
        }

        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Faculty selectedFaculty = (Faculty)cb_Faculty.SelectedItem;
            tbDisplay.Text = "Bạn là sinh viên khoa: " + selectedFaculty.Name;
        }
    }

    public class Faculty
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public int Quantity { get; set; }
    }
}
