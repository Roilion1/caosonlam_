using System.Windows.Forms;

namespace EX01
{
    partial class Cau09
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbLuu = new System.Windows.Forms.Button();
            this.tbCong = new System.Windows.Forms.Button();
            this.tbNhan = new System.Windows.Forms.Button();
            this.tbThoat = new System.Windows.Forms.Button();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "So x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "So y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ket qua";
            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(125, 43);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(274, 22);
            this.tbSoX.TabIndex = 3;
            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(125, 93);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(274, 22);
            this.tbSoY.TabIndex = 4;
            // 
            // tbLuu
            // 
            this.tbLuu.Location = new System.Drawing.Point(12, 283);
            this.tbLuu.Name = "tbLuu";
            this.tbLuu.Size = new System.Drawing.Size(75, 23);
            this.tbLuu.TabIndex = 6;
            this.tbLuu.Text = "Lưu";
            this.tbLuu.UseVisualStyleBackColor = true;
            this.tbLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbCong
            // 
            this.tbCong.Location = new System.Drawing.Point(144, 283);
            this.tbCong.Name = "tbCong";
            this.tbCong.Size = new System.Drawing.Size(75, 23);
            this.tbCong.TabIndex = 2;
            this.tbCong.Text = "Cộng";
            this.tbCong.UseVisualStyleBackColor = true;
            this.tbCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // tbNhan
            // 
            this.tbNhan.Location = new System.Drawing.Point(234, 283);
            this.tbNhan.Name = "tbNhan";
            this.tbNhan.Size = new System.Drawing.Size(75, 23);
            this.tbNhan.TabIndex = 2;
            this.tbNhan.Text = "Nhân";
            this.tbNhan.UseVisualStyleBackColor = true;
            this.tbNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // tbThoat
            // 
            this.tbThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbThoat.Location = new System.Drawing.Point(324, 283);
            this.tbThoat.Name = "tbThoat";
            this.tbThoat.Size = new System.Drawing.Size(75, 23);
            this.tbThoat.TabIndex = 2;
            this.tbThoat.Text = "Thoát";
            this.tbThoat.UseVisualStyleBackColor = true;
            this.tbThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(125, 135);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(274, 142);
            this.tbKetQua.TabIndex = 4;
            // 
            // Cau09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 318);
            this.Controls.Add(this.tbThoat);
            this.Controls.Add(this.tbNhan);
            this.Controls.Add(this.tbCong);
            this.Controls.Add(this.tbLuu);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cau09";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.Button tbLuu;
        private System.Windows.Forms.Button tbCong;
        private System.Windows.Forms.Button tbNhan;
        private System.Windows.Forms.Button tbThoat;
        private TextBox tbKetQua;
    }
}