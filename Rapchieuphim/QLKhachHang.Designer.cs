namespace Rapchieuphim
{
    partial class QLKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.id_kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdbNu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdbNam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpNgaySinhKH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1607, 257);
            this.panel1.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(192, 118);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(155, 29);
            this.txtMaKH.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 60);
            this.label1.TabIndex = 34;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(683, 185);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(69, 33);
            this.rdbNu.TabIndex = 48;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã KH";
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(583, 185);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(89, 33);
            this.rdbNam.TabIndex = 47;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Họ và tên";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1337, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 29);
            this.txtEmail.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(1009, 185);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(208, 29);
            this.txtDiaChi.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Giới tính";
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(1009, 118);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(208, 29);
            this.txtSdt.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(824, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "Địa chỉ";
            // 
            // dtpNgaySinhKH
            // 
            this.dtpNgaySinhKH.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhKH.Location = new System.Drawing.Point(586, 119);
            this.dtpNgaySinhKH.Name = "dtpNgaySinhKH";
            this.dtpNgaySinhKH.Size = new System.Drawing.Size(156, 29);
            this.dtpNgaySinhKH.TabIndex = 43;
            this.dtpNgaySinhKH.Value = new System.DateTime(2025, 4, 8, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(824, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(192, 182);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(155, 29);
            this.txtTenKH.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1246, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1607, 137);
            this.panel2.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(1065, 37);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(160, 64);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(369, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 64);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(601, 37);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(160, 64);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(833, 37);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 64);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Controls.Add(this.dgvKhachHang);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1607, 647);
            this.panel3.TabIndex = 2;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kh,
            this.ho_ten,
            this.ngay_sinh,
            this.gioi_tinh,
            this.dia_chi,
            this.sdt,
            this.email});
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 72;
            this.dgvKhachHang.RowTemplate.Height = 31;
            this.dgvKhachHang.Size = new System.Drawing.Size(1607, 647);
            this.dgvKhachHang.TabIndex = 2;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // id_kh
            // 
            this.id_kh.DataPropertyName = "id_kh";
            this.id_kh.HeaderText = "Mã KH";
            this.id_kh.MinimumWidth = 9;
            this.id_kh.Name = "id_kh";
            this.id_kh.Width = 175;
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Họ và tên";
            this.ho_ten.MinimumWidth = 9;
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.Width = 136;
            // 
            // ngay_sinh
            // 
            this.ngay_sinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ngay_sinh.DataPropertyName = "ngay_sinh";
            this.ngay_sinh.HeaderText = "Ngày sinh";
            this.ngay_sinh.MinimumWidth = 9;
            this.ngay_sinh.Name = "ngay_sinh";
            this.ngay_sinh.Width = 140;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.MinimumWidth = 9;
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.Width = 123;
            // 
            // dia_chi
            // 
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Địa chỉ";
            this.dia_chi.MinimumWidth = 9;
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.Width = 175;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 9;
            this.sdt.Name = "sdt";
            this.sdt.Width = 175;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 9;
            this.email.Name = "email";
            this.email.Width = 175;
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 1041);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLKhachHang";
            this.Text = "QLKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}