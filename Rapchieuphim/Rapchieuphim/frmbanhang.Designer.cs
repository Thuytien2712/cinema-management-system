namespace Rapchieuphim
{
    partial class frmbanhang
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
            this.dtgvdshh = new System.Windows.Forms.DataGridView();
            this.lblmakhachhang = new System.Windows.Forms.Label();
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.lblmagiamgia = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.cbBmagiamgia = new System.Windows.Forms.ComboBox();
            this.nUDsoluong = new System.Windows.Forms.NumericUpDown();
            this.btncatnhap = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.lblmahanghoa = new System.Windows.Forms.Label();
            this.cbBmahanghoa = new System.Windows.Forms.ComboBox();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdshh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDsoluong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvdshh
            // 
            this.dtgvdshh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvdshh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHH,
            this.TenHH,
            this.Soluong,
            this.Tongtien});
            this.dtgvdshh.Location = new System.Drawing.Point(-3, 284);
            this.dtgvdshh.Name = "dtgvdshh";
            this.dtgvdshh.RowHeadersWidth = 62;
            this.dtgvdshh.RowTemplate.Height = 28;
            this.dtgvdshh.Size = new System.Drawing.Size(1183, 339);
            this.dtgvdshh.TabIndex = 0;
            // 
            // lblmakhachhang
            // 
            this.lblmakhachhang.AutoSize = true;
            this.lblmakhachhang.Location = new System.Drawing.Point(40, 81);
            this.lblmakhachhang.Name = "lblmakhachhang";
            this.lblmakhachhang.Size = new System.Drawing.Size(118, 20);
            this.lblmakhachhang.TabIndex = 1;
            this.lblmakhachhang.Text = "Mã khách hàng";
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Location = new System.Drawing.Point(40, 148);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(103, 20);
            this.lblmanhanvien.TabIndex = 2;
            this.lblmanhanvien.Text = "Mã nhân viên";
            // 
            // lblmagiamgia
            // 
            this.lblmagiamgia.AutoSize = true;
            this.lblmagiamgia.Location = new System.Drawing.Point(459, 84);
            this.lblmagiamgia.Name = "lblmagiamgia";
            this.lblmagiamgia.Size = new System.Drawing.Size(94, 20);
            this.lblmagiamgia.TabIndex = 3;
            this.lblmagiamgia.Text = "Mã giảm giá";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(472, 155);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(72, 20);
            this.lblsoluong.TabIndex = 4;
            this.lblsoluong.Text = "Số lượng";
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(192, 81);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(185, 26);
            this.txtmakh.TabIndex = 5;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(192, 145);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(185, 26);
            this.txtmanv.TabIndex = 6;
            // 
            // cbBmagiamgia
            // 
            this.cbBmagiamgia.FormattingEnabled = true;
            this.cbBmagiamgia.Location = new System.Drawing.Point(570, 81);
            this.cbBmagiamgia.Name = "cbBmagiamgia";
            this.cbBmagiamgia.Size = new System.Drawing.Size(136, 28);
            this.cbBmagiamgia.TabIndex = 7;
            // 
            // nUDsoluong
            // 
            this.nUDsoluong.Location = new System.Drawing.Point(580, 153);
            this.nUDsoluong.Name = "nUDsoluong";
            this.nUDsoluong.Size = new System.Drawing.Size(102, 26);
            this.nUDsoluong.TabIndex = 8;
            // 
            // btncatnhap
            // 
            this.btncatnhap.BackColor = System.Drawing.Color.PeachPuff;
            this.btncatnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncatnhap.ForeColor = System.Drawing.Color.Black;
            this.btncatnhap.Location = new System.Drawing.Point(764, 84);
            this.btncatnhap.Name = "btncatnhap";
            this.btncatnhap.Size = new System.Drawing.Size(165, 33);
            this.btncatnhap.TabIndex = 9;
            this.btncatnhap.Text = "Cật nhập";
            this.btncatnhap.UseVisualStyleBackColor = false;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.PeachPuff;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.Location = new System.Drawing.Point(764, 155);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(165, 33);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.PeachPuff;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Location = new System.Drawing.Point(988, 84);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(165, 33);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.PeachPuff;
            this.btnluu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnluu.ForeColor = System.Drawing.Color.Black;
            this.btnluu.Location = new System.Drawing.Point(988, 155);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(165, 33);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            // 
            // lblmahanghoa
            // 
            this.lblmahanghoa.AutoSize = true;
            this.lblmahanghoa.Location = new System.Drawing.Point(41, 212);
            this.lblmahanghoa.Name = "lblmahanghoa";
            this.lblmahanghoa.Size = new System.Drawing.Size(102, 20);
            this.lblmahanghoa.TabIndex = 13;
            this.lblmahanghoa.Text = "Mã hàng hóa";
            // 
            // cbBmahanghoa
            // 
            this.cbBmahanghoa.FormattingEnabled = true;
            this.cbBmahanghoa.Location = new System.Drawing.Point(192, 212);
            this.cbBmahanghoa.Name = "cbBmahanghoa";
            this.cbBmahanghoa.Size = new System.Drawing.Size(136, 28);
            this.cbBmahanghoa.TabIndex = 14;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHH.HeaderText = "Mã hàng hóa";
            this.MaHH.MinimumWidth = 8;
            this.MaHH.Name = "MaHH";
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHH.HeaderText = "Tên hàng hóa";
            this.TenHH.MinimumWidth = 8;
            this.TenHH.Name = "TenHH";
            // 
            // Soluong
            // 
            this.Soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 8;
            this.Soluong.Name = "Soluong";
            // 
            // Tongtien
            // 
            this.Tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tongtien.HeaderText = "Tổng tiền";
            this.Tongtien.MinimumWidth = 8;
            this.Tongtien.Name = "Tongtien";
            // 
            // frmbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1180, 621);
            this.Controls.Add(this.cbBmahanghoa);
            this.Controls.Add(this.lblmahanghoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btncatnhap);
            this.Controls.Add(this.nUDsoluong);
            this.Controls.Add(this.cbBmagiamgia);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.lblmagiamgia);
            this.Controls.Add(this.lblmanhanvien);
            this.Controls.Add(this.lblmakhachhang);
            this.Controls.Add(this.dtgvdshh);
            this.Name = "frmbanhang";
            this.Text = "frmbanhang";
            this.Load += new System.EventHandler(this.frmbanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvdshh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDsoluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvdshh;
        private System.Windows.Forms.Label lblmakhachhang;
        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.Label lblmagiamgia;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.ComboBox cbBmagiamgia;
        private System.Windows.Forms.NumericUpDown nUDsoluong;
        private System.Windows.Forms.Button btncatnhap;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Label lblmahanghoa;
        private System.Windows.Forms.ComboBox cbBmahanghoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
    }
}