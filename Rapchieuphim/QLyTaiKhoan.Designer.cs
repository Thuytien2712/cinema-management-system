namespace Rapchieuphim
{
    partial class QLyTaiKhoan
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
            this.dtgvtaikhoan = new System.Windows.Forms.DataGridView();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.textBoxMatkhau = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.lblPhanquyen = new System.Windows.Forms.Label();
            this.lblidnhanvien = new System.Windows.Forms.Label();
            this.txtidNhanVien = new System.Windows.Forms.TextBox();
            this.cbBPhanquyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvtaikhoan
            // 
            this.dtgvtaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtaikhoan.Location = new System.Drawing.Point(-2, 386);
            this.dtgvtaikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvtaikhoan.Name = "dtgvtaikhoan";
            this.dtgvtaikhoan.RowHeadersWidth = 62;
            this.dtgvtaikhoan.RowTemplate.Height = 28;
            this.dtgvtaikhoan.Size = new System.Drawing.Size(983, 383);
            this.dtgvtaikhoan.TabIndex = 57;
            this.dtgvtaikhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvtaikhoan_CellContentClick);
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.BackColor = System.Drawing.Color.Bisque;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(13, 187);
            this.lblMatkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(151, 38);
            this.lblMatkhau.TabIndex = 56;
            this.lblMatkhau.Text = "Mật khẩu";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Bisque;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(13, 103);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 38);
            this.lblEmail.TabIndex = 55;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(277, 96);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 45);
            this.txtEmail.TabIndex = 54;
            // 
            // textBoxMatkhau
            // 
            this.textBoxMatkhau.Location = new System.Drawing.Point(277, 187);
            this.textBoxMatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMatkhau.Multiline = true;
            this.textBoxMatkhau.Name = "textBoxMatkhau";
            this.textBoxMatkhau.Size = new System.Drawing.Size(250, 45);
            this.textBoxMatkhau.TabIndex = 53;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSalmon;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(734, 265);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(147, 77);
            this.btnHuy.TabIndex = 52;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(494, 265);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 77);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(19, 265);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 78);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCapnhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(241, 265);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(139, 78);
            this.btnCapnhat.TabIndex = 49;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // lblPhanquyen
            // 
            this.lblPhanquyen.AutoSize = true;
            this.lblPhanquyen.BackColor = System.Drawing.Color.Bisque;
            this.lblPhanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanquyen.Location = new System.Drawing.Point(671, 18);
            this.lblPhanquyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhanquyen.Name = "lblPhanquyen";
            this.lblPhanquyen.Size = new System.Drawing.Size(191, 38);
            this.lblPhanquyen.TabIndex = 48;
            this.lblPhanquyen.Text = "Phân quyền";
            // 
            // lblidnhanvien
            // 
            this.lblidnhanvien.AutoSize = true;
            this.lblidnhanvien.BackColor = System.Drawing.Color.Bisque;
            this.lblidnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidnhanvien.Location = new System.Drawing.Point(10, 18);
            this.lblidnhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidnhanvien.Name = "lblidnhanvien";
            this.lblidnhanvien.Size = new System.Drawing.Size(212, 38);
            this.lblidnhanvien.TabIndex = 47;
            this.lblidnhanvien.Text = "Mã nhân viên";
            // 
            // txtidNhanVien
            // 
            this.txtidNhanVien.Location = new System.Drawing.Point(277, 11);
            this.txtidNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidNhanVien.Multiline = true;
            this.txtidNhanVien.Name = "txtidNhanVien";
            this.txtidNhanVien.Size = new System.Drawing.Size(250, 45);
            this.txtidNhanVien.TabIndex = 46;
            // 
            // cbBPhanquyen
            // 
            this.cbBPhanquyen.FormattingEnabled = true;
            this.cbBPhanquyen.Location = new System.Drawing.Point(681, 101);
            this.cbBPhanquyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBPhanquyen.Name = "cbBPhanquyen";
            this.cbBPhanquyen.Size = new System.Drawing.Size(192, 32);
            this.cbBPhanquyen.TabIndex = 45;
            // 
            // QLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(978, 781);
            this.Controls.Add(this.dtgvtaikhoan);
            this.Controls.Add(this.lblMatkhau);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.textBoxMatkhau);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.lblPhanquyen);
            this.Controls.Add(this.lblidnhanvien);
            this.Controls.Add(this.txtidNhanVien);
            this.Controls.Add(this.cbBPhanquyen);
            this.Name = "QLyTaiKhoan";
            this.Text = "QLyTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvtaikhoan;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox textBoxMatkhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Label lblPhanquyen;
        private System.Windows.Forms.Label lblidnhanvien;
        private System.Windows.Forms.TextBox txtidNhanVien;
        private System.Windows.Forms.ComboBox cbBPhanquyen;
    }
}