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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassWord.Text;

            // Kiểm tra thông tin đăng nhập (ví dụ đơn giản)
            if (username == "CaoSonLam" && password == "2122110089")
            {
                // Mở form chính và ẩn form đăng nhập
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                // Đăng nhập thất bại
                txtMassage.Text = "Tên đăng nhập hoặc mật khẩu không đúng.";  // Thông báo khi đăng nhập sai
                txtMassage.ForeColor = System.Drawing.Color.Red;               // Đổi màu thông báo thành màu đỏ
            }
        }
    }
}
