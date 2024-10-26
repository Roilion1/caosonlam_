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
using static System.Net.Mime.MediaTypeNames;

namespace EX01
{
    public partial class Cau20 : Form
    {
        public Cau20()
        {
            InitializeComponent();
            this.Text = "Quản Lý Sinh Viên";
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbId.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbAge.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm.");
                return;
            }

            if(!long.TryParse(tbId.Text, out _) || tbId.Text.Length > 10)
            {
                MessageBox.Show("Nhập lại mã số, không chứa chữ cái và không vượt quá 10.");
                return;
            }

            if (!int.TryParse(tbAge.Text, out int age) || age < 18 || age >50)
            {
                MessageBox.Show("Nhập lại tuổi.");
                return;
            }
            string gender = rbNam.Checked ? "Nam" : "Nữ";

            dgvCustomer.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, gender);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.Rows.Count == 0 || (dgvCustomer.Rows.Count == 1 && dgvCustomer.Rows[0].IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu để xóa. Vui lòng thêm thông tin trước.");
                return;
            }

            // Tạo danh sách chứa các chỉ mục của hàng rỗng cần xóa
            List<int> toBeDeleted = new List<int>();

            // Kiểm tra từng hàng để tìm hàng rỗng
            for (int i = 0; i < dgvCustomer.Rows.Count - 1; i++) // -1 vì hàng thêm mới
            {
                bool empty = true;
                for (int j = 0; j < dgvCustomer.Columns.Count; j++)
                {
                    if (dgvCustomer.Rows[i].Cells[j].Value != null && dgvCustomer.Rows[i].Cells[j].Value.ToString() != "")
                    {
                        empty = false;
                        break;
                    }
                }
                if (empty)
                {
                    toBeDeleted.Add(i); 
                }
            }

            // Xóa các hàng rỗng từ cuối lên đầu để tránh lỗi chỉ mục
            for (int i = toBeDeleted.Count - 1; i >= 0; i--)
            {
                dgvCustomer.Rows.RemoveAt(toBeDeleted[i]);
            }

            // Kiểm tra và xóa hàng hiện tại
            if (dgvCustomer.CurrentRow != null && !dgvCustomer.CurrentRow.IsNewRow)
            {
                int idx = dgvCustomer.CurrentCell.RowIndex;
                dgvCustomer.Rows.RemoveAt(idx);
            }
        }


        private void btEdit_Click(object sender, EventArgs e)
        {

            // Kiểm tra nếu không có hàng nào được chọn
            if (dgvCustomer.CurrentRow == null || dgvCustomer.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa.");
                return;
            }

            int idx = dgvCustomer.CurrentCell.RowIndex;

            // Kiểm tra điều kiện cho ID (chỉ nhận số và không quá 10 chữ số)
            if (!long.TryParse(tbId.Text, out _) || tbId.Text.Length > 10)
            {
                MessageBox.Show("ID chỉ được chứa số và không quá 10 chữ số.");
                return;
            }

            // Kiểm tra điều kiện cho Age (tuổi từ 18 đến 50)
            if (!int.TryParse(tbAge.Text, out int age) || age < 18 || age > 50)
            {
                MessageBox.Show("Tuổi phải nằm trong khoảng từ 18 đến 50.");
                return;
            }

            // Xác định giới tính dựa trên RadioButton đã chọn
            string gender = rbNam.Checked ? "Nam" : "Nữ";

            dgvCustomer.Rows[idx].Cells[0].Value = tbId.Text;
            dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            dgvCustomer.Rows[idx].Cells[2].Value = tbAge.Text;
            dgvCustomer.Rows[idx].Cells[3].Value = gender;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idx = e.RowIndex;

                if (dgvCustomer.Rows[idx].Cells[0].Value != null)
                {
                    tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
                }
                else
                {
                    tbId.Text = string.Empty;
                }

                if (dgvCustomer.Rows[idx].Cells[1].Value != null)
                {
                    tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
                }
                else
                {
                    tbName.Text = string.Empty;
                }
                if (dgvCustomer.Rows[idx].Cells[2].Value != null)
                {
                    tbAge.Text = dgvCustomer.Rows[idx].Cells[2].Value.ToString();
                }
                else
                {
                    tbAge.Text = string.Empty;
                }

                string gender = dgvCustomer.Rows[idx].Cells[3].Value?.ToString();
                rbNam.Checked = gender == "Nam";
                rbNu.Checked = gender == "Nữ";
            }
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNam.Checked)
            {
                rbNu.Checked = false; 
            }
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNu.Checked)
            {
                rbNam.Checked = false; 
            }
        }



        //private void btFile_Click(object sender, EventArgs e)
        //{
        //    pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.Title = "Open Image";
        //    dlg.Filter = "JPEG files (*.jpg)|*.jpg";
        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        pbImage.ImageLocation = dlg.FileName;
        //    }
        //}

    }
}
