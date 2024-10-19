using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EX01
{
    public partial class Cau16 : Form
    {
        private int stt = 1;

        public Cau16()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            string hoTen = tbName.Text;               
            string ngaySinh = dtpDate.Text;           
            string khoa = cb_Faculty.SelectedItem?.ToString(); 

            // Giới tính
            string gioiTinh = rbMale.Checked ? "Nam" : (rbFemale.Checked ? "Nữ" : "Chưa chọn");

            // Thêm thông tin vào tbDisplay
            tbDisplay.AppendText($"{stt}. Họ và tên: {hoTen}\r\n");
            tbDisplay.AppendText($"   Ngày sinh: {ngaySinh}\r\n");
            tbDisplay.AppendText($"   Giới tính: {gioiTinh}\r\n");
            tbDisplay.AppendText($"   Khoa: {khoa}\r\n");
            tbDisplay.AppendText("--------------------\r\n");

            stt++;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Cập nhật tiêu đề form với ngày sinh được chọn
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}