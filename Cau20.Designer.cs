namespace EX01
{
    partial class Cau20
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.rbNam = new System.Windows.Forms.CheckBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExitSearch = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.rbNu = new System.Windows.Forms.CheckBox();
            this.btRead = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btFile = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearchById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btId,
            this.btName,
            this.btAge,
            this.Column4});
            this.dgvCustomer.Location = new System.Drawing.Point(12, 23);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(998, 398);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_RowEnter);
            // 
            // btId
            // 
            this.btId.HeaderText = "Mã sinh viên";
            this.btId.MinimumWidth = 6;
            this.btId.Name = "btId";
            this.btId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btId.Width = 125;
            // 
            // btName
            // 
            this.btName.HeaderText = "Họ và Tên ";
            this.btName.MinimumWidth = 6;
            this.btName.Name = "btName";
            this.btName.Width = 200;
            // 
            // btAge
            // 
            this.btAge.HeaderText = "Tuổi";
            this.btAge.MinimumWidth = 6;
            this.btAge.Name = "btAge";
            this.btAge.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tuổi";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(83, 437);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(188, 22);
            this.tbId.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(83, 477);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(188, 22);
            this.tbName.TabIndex = 5;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(83, 520);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(188, 22);
            this.tbAge.TabIndex = 6;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(101, 563);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 20);
            this.rbNam.TabIndex = 7;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.Click += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(456, 563);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(88, 34);
            this.btNew.TabIndex = 8;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(699, 563);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(88, 34);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExitSearch
            // 
            this.btExitSearch.Location = new System.Drawing.Point(816, 563);
            this.btExitSearch.Name = "btExitSearch";
            this.btExitSearch.Size = new System.Drawing.Size(91, 34);
            this.btExitSearch.TabIndex = 10;
            this.btExitSearch.Text = "Thoát";
            this.btExitSearch.UseVisualStyleBackColor = true;
            this.btExitSearch.Click += new System.EventHandler(this.btExitSearch_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(582, 563);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(84, 34);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(190, 563);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(46, 20);
            this.rbNu.TabIndex = 7;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.Click += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(289, 563);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(121, 34);
            this.btRead.TabIndex = 12;
            this.btRead.Text = "Đọc dữ liệu";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(636, 437);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(90, 99);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(732, 501);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(100, 35);
            this.btFile.TabIndex = 14;
            this.btFile.Text = "Chọn ảnh";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(357, 437);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(226, 22);
            this.tbSearch.TabIndex = 15;
            // 
            // btSearchById
            // 
            this.btSearchById.Location = new System.Drawing.Point(490, 470);
            this.btSearchById.Name = "btSearchById";
            this.btSearchById.Size = new System.Drawing.Size(93, 29);
            this.btSearchById.TabIndex = 16;
            this.btSearchById.Text = "Tìm kiếm";
            this.btSearchById.UseVisualStyleBackColor = true;
            this.btSearchById.Click += new System.EventHandler(this.btSearchById_Click);
            // 
            // Cau20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 609);
            this.Controls.Add(this.btSearchById);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btExitSearch);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomer);
            this.Name = "Cau20";
            this.Text = "Cau20";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.CheckBox rbNam;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btExitSearch;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.CheckBox rbNu;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn btId;
        private System.Windows.Forms.DataGridViewTextBoxColumn btName;
        private System.Windows.Forms.DataGridViewTextBoxColumn btAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearchById;
    }
}