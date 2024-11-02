using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EX01
{
    public partial class Cau20 : Form
    {
        public Cau20()
        {
            InitializeComponent();
            this.Text = "Quản Lý Sinh Viên";

            // Đăng ký sự kiện Resize
            this.Resize += new EventHandler(Cau20_Resize);

            // Tạo DataGridViewImageColumn và thiết lập các thuộc tính cần thiết
            var imageColumn = new DataGridViewImageColumn
            {
                Name = "Image",
                HeaderText = "Image",
                Width = 120, // Chiều rộng cho khung ảnh
                ImageLayout = DataGridViewImageCellLayout.Zoom // điều chỉnh kích thước ảnh để vừa khung
            };

            // Thêm cột hình ảnh vào DataGridView
            dgvCustomer.Columns.Add(imageColumn);

            //  lưu đường dẫn hình ảnh
            dgvCustomer.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ImagePath",
                HeaderText = "Image Path",
                Visible = false
            });

            dgvCustomer.RowTemplate.Height = 80; // Chiều cao phù hợp với khung ảnh 

            LoadDataGridView();
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

            if (!long.TryParse(tbId.Text, out _) || tbId.Text.Length > 10)
            {
                MessageBox.Show("Nhập lại mã số, không chứa chữ cái và không vượt quá 10.");
                return;
            }

            if (!int.TryParse(tbAge.Text, out int age) || age < 18 || age > 50)
            {
                MessageBox.Show("Nhập lại tuổi.");
                return;
            }

            string gender = rbNam.Checked ? "Nam" : "Nu";
            string imagePath = pbImage.ImageLocation ?? string.Empty;

            byte[] imageBytes = null;
            if (pbImage.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageBytes = ms.ToArray();
                }
            }

            using (SqlConnection connection = new SqlConnection("Data Source=ROILION; Initial Catalog=sale; User Id=sa; Password=sa"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Customer (id, name, age, gender, image) VALUES (@id, @name, @age, @gender, @image)", connection))
                {
                    command.Parameters.Add(new SqlParameter("@id", tbId.Text));
                    command.Parameters.Add(new SqlParameter("@name", tbName.Text));
                    command.Parameters.Add(new SqlParameter("@age", tbAge.Text));
                    command.Parameters.Add(new SqlParameter("@gender", gender));
                    command.Parameters.Add(new SqlParameter("@image", imageBytes != null ? (object)imageBytes : DBNull.Value));
                    command.ExecuteNonQuery();
                }
            }

            System.Drawing.Image image = null;
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                image = System.Drawing.Image.FromFile(imagePath);
            }

            dgvCustomer.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, gender, image);
            LoadDataGridView(); 
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null || dgvCustomer.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Không có hàng nào để xóa.");
                return;
            }

            int idx = dgvCustomer.CurrentCell.RowIndex;
            string idToDelete = dgvCustomer.Rows[idx].Cells[0].Value.ToString();

            using (SqlConnection connection = new SqlConnection("Data Source=ROILION; Initial Catalog=sale; User Id=sa; Password=sa"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE id = @id", connection))
                {
                    command.Parameters.Add(new SqlParameter("@id", idToDelete));
                    command.ExecuteNonQuery();
                }
            }

            dgvCustomer.Rows.RemoveAt(idx);
            LoadDataGridView();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null || dgvCustomer.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa.");
                return;
            }

            int idx = dgvCustomer.CurrentCell.RowIndex;

            if (!long.TryParse(tbId.Text, out long id) || tbId.Text.Length > 19) // 19 là chiều dài tối đa cho bigint
            {
                MessageBox.Show("ID chỉ được chứa số và không quá 19 ký tự.");
                return;
            }

            if (!int.TryParse(tbAge.Text, out int age) || age < 18 || age > 50)
            {
                MessageBox.Show("Tuổi phải nằm trong khoảng từ 18 đến 50.");
                return;
            }

            string gender = rbNam.Checked ? "Nam" : "Nu";
            string imagePath = pbImage.ImageLocation ?? string.Empty;
            byte[] imageBytes = null;

            // Chuyển đổi hình ảnh thành mảng byte nếu có hình ảnh
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        imageBytes = br.ReadBytes((int)fs.Length);
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection("Data Source=ROILION; Initial Catalog=sale; User Id=sa; Password=sa"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE customer SET name = @name, age = @age, gender = @gender, image = @image WHERE id = @id", connection))
                {
                    command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = id });
                    command.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar) { Value = tbName.Text });
                    command.Parameters.Add(new SqlParameter("@age", SqlDbType.Int) { Value = age });
                    command.Parameters.Add(new SqlParameter("@gender", SqlDbType.VarChar) { Value = gender });
                    command.Parameters.Add(new SqlParameter("@image", SqlDbType.VarBinary) { Value = (object)imageBytes ?? DBNull.Value });

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Lỗi SQL: {ex.Message}");
                        return;
                    }
                }
            }

            // Cập nhật DataGridView
            dgvCustomer.Rows[idx].Cells[0].Value = id;
            dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            dgvCustomer.Rows[idx].Cells[2].Value = tbAge.Text;
            dgvCustomer.Rows[idx].Cells[3].Value = gender;

            // Cập nhật hình ảnh
            if (imageBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    dgvCustomer.Rows[idx].Cells[4].Value = System.Drawing.Image.FromStream(ms);
                }
            }
            else
            {
                dgvCustomer.Rows[idx].Cells[4].Value = null;
            }

            LoadDataGridView();
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

                tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value?.ToString() ?? string.Empty;
                tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value?.ToString() ?? string.Empty;
                tbAge.Text = dgvCustomer.Rows[idx].Cells[2].Value?.ToString() ?? string.Empty;

                string gender = dgvCustomer.Rows[idx].Cells[3].Value?.ToString();
                rbNam.Checked = gender == "Nam";
                rbNu.Checked = gender == "Nữ";

                string imagePath = dgvCustomer.Rows[idx].Cells["ImagePath"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pbImage.ImageLocation = imagePath;
                }
                else
                {
                    pbImage.Image = null; 
                }
            }
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = dlg.FileName;
            }
        }

        private void LoadDataGridView()
        {
            dgvCustomer.Rows.Clear();

            using (SqlConnection connection = new SqlConnection("Data Source=ROILION;Initial Catalog=sale;User Id=sa; Password=sa"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT id, name, age, gender, image FROM Customer", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int age = reader.GetInt32(2);
                            string gender = reader.GetString(3);
                            byte[] imageData = reader["image"] as byte[];

                            System.Drawing.Image image = null;
                            if (imageData != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    image = System.Drawing.Image.FromStream(ms);
                                }
                            }

                            dgvCustomer.Rows.Add(id, name, age, gender, image);
                        }
                    }
                }
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=ROILION; Initial Catalog=sale; User Id=sa; Password=sa"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                    }
                }
                conn.Close();
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

        private void btSearchById_Click(object sender, EventArgs e)
        {
            string id = tbSearch.Text;
            List<CustomerBEL> result = SearchById(id);
            DisplaySearchResults(result);
        }

        private List<CustomerBEL> SearchById(string id)
        {
            List<CustomerBEL> results = new List<CustomerBEL>();

            using (SqlConnection connection = new SqlConnection("Data Source=ROILION; Initial Catalog=sale; User Id=sa; Password=sa"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE id = @id", connection))
                {
                    command.Parameters.Add(new SqlParameter("@id", id));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerBEL customer = new CustomerBEL
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Age = reader.GetInt32(2),
                                Gender = reader.GetString(3)
                            };

                            if (!reader.IsDBNull(4))
                            {
                                byte[] imageData = (byte[])reader["image"];
                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    customer.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }

                            results.Add(customer);
                        }
                    }
                }
            }
            return results;
        }

        private void DisplaySearchResults(List<CustomerBEL> customers)
        {
            dgvCustomer.Rows.Clear();
            foreach (CustomerBEL customer in customers)
            {
                dgvCustomer.Rows.Add(customer.Id, customer.Name, customer.Age, customer.Gender, customer.Image);
            }
        }

        private void btExitSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Clear(); 
            LoadDataGridView(); 
        }

        private void Cau20_Resize(object sender, EventArgs e)
        {
            // Thay đổi kích thước của DataGridView dựa trên kích thước mới của Form
            dgvCustomer.Width = this.ClientSize.Width - 20; // Chỉnh khoảng cách cho phù hợp
            dgvCustomer.Height = this.ClientSize.Height - 100; // Chỉnh chiều cao cho phù hợp
        }
    }
}
