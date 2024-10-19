namespace EX01
{
    partial class Cau18
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSong = new System.Windows.Forms.ListBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.lbFavorite = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách bài hát ưa thích";
            // 
            // lbSong
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.ItemHeight = 16;
            this.lbSong.Items.AddRange(new object[] {
            "Giấc Mơ Chapi",
            "Đôi Mắt Pleiku",
            "Em Muốn Sống Bên Anh Trọn Đời",
            "H\'Zen Lên Rẫy",
            "Còn Thương Nhau Thì Về Buôn Mê Thuột",
            "Ly Cà Phê Ban Mê",
            "Đi Tìm Lời Ru Mặt Trời"});
            this.lbSong.Location = new System.Drawing.Point(50, 93);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(257, 324);
            this.lbSong.TabIndex = 2;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(328, 197);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(52, 47);
            this.btSelect.TabIndex = 3;
            this.btSelect.Text = ">";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // btSelectAll
            // 
            this.btSelectAll.Location = new System.Drawing.Point(328, 270);
            this.btSelectAll.Name = "btSelectAll";
            this.btSelectAll.Size = new System.Drawing.Size(52, 47);
            this.btSelectAll.TabIndex = 4;
            this.btSelectAll.Text = "<";
            this.btSelectAll.UseVisualStyleBackColor = true;
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
            // 
            // lbFavorite
            // 
            this.lbFavorite.FormattingEnabled = true;
            this.lbFavorite.ItemHeight = 16;
            this.lbFavorite.Location = new System.Drawing.Point(402, 93);
            this.lbFavorite.Name = "lbFavorite";
            this.lbFavorite.Size = new System.Drawing.Size(266, 324);
            this.lbFavorite.TabIndex = 5;
            // 
            // Cau18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 602);
            this.Controls.Add(this.lbFavorite);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cau18";
            this.Text = "Cau18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.ListBox lbFavorite;
    }
}