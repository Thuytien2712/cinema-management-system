namespace Rapchieuphim
{
    partial class QLTichDiem
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
            this.txtbDiemtichluy = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblDiemtichluy = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblQLtichdiem = new System.Windows.Forms.Label();
            this.dtgvTichdiem = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblmatichdiem = new System.Windows.Forms.Label();
            this.txtmatichdiem = new System.Windows.Forms.TextBox();
            this.txtmaKH = new System.Windows.Forms.TextBox();
            this.lblnoidung = new System.Windows.Forms.Label();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblNgaytichdiem = new System.Windows.Forms.Label();
            this.dtpngaytichdiem = new System.Windows.Forms.DateTimePicker();
            this.lblMahoadon = new System.Windows.Forms.Label();
            this.txtbMaHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTichdiem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbDiemtichluy
            // 
            this.txtbDiemtichluy.Location = new System.Drawing.Point(945, 205);
            this.txtbDiemtichluy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbDiemtichluy.Multiline = true;
            this.txtbDiemtichluy.Name = "txtbDiemtichluy";
            this.txtbDiemtichluy.Size = new System.Drawing.Size(307, 39);
            this.txtbDiemtichluy.TabIndex = 4;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(28, 206);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(240, 38);
            this.lblMaKH.TabIndex = 9;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblDiemtichluy
            // 
            this.lblDiemtichluy.AutoSize = true;
            this.lblDiemtichluy.BackColor = System.Drawing.Color.Transparent;
            this.lblDiemtichluy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemtichluy.Location = new System.Drawing.Point(643, 205);
            this.lblDiemtichluy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiemtichluy.Name = "lblDiemtichluy";
            this.lblDiemtichluy.Size = new System.Drawing.Size(204, 38);
            this.lblDiemtichluy.TabIndex = 15;
            this.lblDiemtichluy.Text = "Điểm tích lũy";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SandyBrown;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1204, 442);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(191, 74);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblQLtichdiem
            // 
            this.lblQLtichdiem.AutoSize = true;
            this.lblQLtichdiem.BackColor = System.Drawing.Color.Bisque;
            this.lblQLtichdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLtichdiem.Location = new System.Drawing.Point(414, 11);
            this.lblQLtichdiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQLtichdiem.Name = "lblQLtichdiem";
            this.lblQLtichdiem.Size = new System.Drawing.Size(479, 54);
            this.lblQLtichdiem.TabIndex = 20;
            this.lblQLtichdiem.Text = "QUẢN LÝ TÍCH ĐIỂM";
            // 
            // dtgvTichdiem
            // 
            this.dtgvTichdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTichdiem.Location = new System.Drawing.Point(15, 571);
            this.dtgvTichdiem.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTichdiem.Name = "dtgvTichdiem";
            this.dtgvTichdiem.RowHeadersWidth = 62;
            this.dtgvTichdiem.RowTemplate.Height = 28;
            this.dtgvTichdiem.Size = new System.Drawing.Size(1459, 476);
            this.dtgvTichdiem.TabIndex = 21;
            this.dtgvTichdiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTichdiem_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(750, 442);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(191, 71);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblmatichdiem
            // 
            this.lblmatichdiem.AutoSize = true;
            this.lblmatichdiem.BackColor = System.Drawing.Color.Transparent;
            this.lblmatichdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatichdiem.Location = new System.Drawing.Point(34, 114);
            this.lblmatichdiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmatichdiem.Name = "lblmatichdiem";
            this.lblmatichdiem.Size = new System.Drawing.Size(201, 38);
            this.lblmatichdiem.TabIndex = 24;
            this.lblmatichdiem.Text = "Mã tích điểm";
            // 
            // txtmatichdiem
            // 
            this.txtmatichdiem.Location = new System.Drawing.Point(288, 114);
            this.txtmatichdiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatichdiem.Multiline = true;
            this.txtmatichdiem.Name = "txtmatichdiem";
            this.txtmatichdiem.Size = new System.Drawing.Size(263, 38);
            this.txtmatichdiem.TabIndex = 25;
            // 
            // txtmaKH
            // 
            this.txtmaKH.Location = new System.Drawing.Point(288, 206);
            this.txtmaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmaKH.Multiline = true;
            this.txtmaKH.Name = "txtmaKH";
            this.txtmaKH.Size = new System.Drawing.Size(263, 38);
            this.txtmaKH.TabIndex = 28;
            // 
            // lblnoidung
            // 
            this.lblnoidung.AutoSize = true;
            this.lblnoidung.BackColor = System.Drawing.Color.Transparent;
            this.lblnoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoidung.Location = new System.Drawing.Point(643, 299);
            this.lblnoidung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnoidung.Name = "lblnoidung";
            this.lblnoidung.Size = new System.Drawing.Size(147, 38);
            this.lblnoidung.TabIndex = 29;
            this.lblnoidung.Text = "Nội dung";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(946, 301);
            this.txtNoidung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(307, 35);
            this.txtNoidung.TabIndex = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SandyBrown;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(985, 442);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(191, 71);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(511, 442);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(191, 71);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblNgaytichdiem
            // 
            this.lblNgaytichdiem.AutoSize = true;
            this.lblNgaytichdiem.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaytichdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaytichdiem.Location = new System.Drawing.Point(643, 114);
            this.lblNgaytichdiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaytichdiem.Name = "lblNgaytichdiem";
            this.lblNgaytichdiem.Size = new System.Drawing.Size(233, 38);
            this.lblNgaytichdiem.TabIndex = 10;
            this.lblNgaytichdiem.Text = "Ngày tích điểm";
            // 
            // dtpngaytichdiem
            // 
            this.dtpngaytichdiem.Location = new System.Drawing.Point(945, 119);
            this.dtpngaytichdiem.Margin = new System.Windows.Forms.Padding(4);
            this.dtpngaytichdiem.Name = "dtpngaytichdiem";
            this.dtpngaytichdiem.Size = new System.Drawing.Size(307, 29);
            this.dtpngaytichdiem.TabIndex = 27;
            // 
            // lblMahoadon
            // 
            this.lblMahoadon.AutoSize = true;
            this.lblMahoadon.BackColor = System.Drawing.Color.Transparent;
            this.lblMahoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMahoadon.Location = new System.Drawing.Point(34, 298);
            this.lblMahoadon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMahoadon.Name = "lblMahoadon";
            this.lblMahoadon.Size = new System.Drawing.Size(188, 38);
            this.lblMahoadon.TabIndex = 26;
            this.lblMahoadon.Text = "Mã hóa đơn";
            // 
            // txtbMaHD
            // 
            this.txtbMaHD.Location = new System.Drawing.Point(288, 298);
            this.txtbMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbMaHD.Multiline = true;
            this.txtbMaHD.Name = "txtbMaHD";
            this.txtbMaHD.Size = new System.Drawing.Size(263, 39);
            this.txtbMaHD.TabIndex = 0;
            // 
            // QLTichDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rapchieuphim.Properties.Resources.rcp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1489, 1062);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtNoidung);
            this.Controls.Add(this.lblnoidung);
            this.Controls.Add(this.txtmaKH);
            this.Controls.Add(this.dtpngaytichdiem);
            this.Controls.Add(this.lblMahoadon);
            this.Controls.Add(this.txtmatichdiem);
            this.Controls.Add(this.lblmatichdiem);
            this.Controls.Add(this.dtgvTichdiem);
            this.Controls.Add(this.lblQLtichdiem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblDiemtichluy);
            this.Controls.Add(this.lblNgaytichdiem);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.txtbDiemtichluy);
            this.Controls.Add(this.txtbMaHD);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QLTichDiem";
            this.Text = "i";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLTichDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTichdiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbDiemtichluy;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblDiemtichluy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblQLtichdiem;
        private System.Windows.Forms.DataGridView dtgvTichdiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblmatichdiem;
        private System.Windows.Forms.TextBox txtmatichdiem;
        private System.Windows.Forms.TextBox txtmaKH;
        private System.Windows.Forms.Label lblnoidung;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblNgaytichdiem;
        private System.Windows.Forms.DateTimePicker dtpngaytichdiem;
        private System.Windows.Forms.Label lblMahoadon;
        private System.Windows.Forms.TextBox txtbMaHD;
    }
}