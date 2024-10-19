using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX01
{
    public partial class Cau13 : Form
    {
        private object st;

        public Cau13()
        {
            InitializeComponent();
        }

        private void Cau13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name";
        }

        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Id";
            string id = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
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
            f.Name = "Quản trị kinh doan";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);
            return lst;
        }
    }
}
