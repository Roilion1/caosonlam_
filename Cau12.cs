using System;
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
    public partial class Cau12 : Form
    {
        public Cau12()
        {
            InitializeComponent();
        }

        private void Cau12_Load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2;
        }
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e) 
        {
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ : " + index.ToString();
        }
        private void btOK_Click(object sender, EventArgs e)
        {
            string item = cb_Faculty.SelectedItem.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
        }
    }
}
