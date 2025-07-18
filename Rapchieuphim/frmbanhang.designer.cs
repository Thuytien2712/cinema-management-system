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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbanhang));
            this.dgvDSMon = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_do_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanh_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTieptuc = new System.Windows.Forms.Button();
            this.lblTonkho = new System.Windows.Forms.Label();
            this.lblThem = new System.Windows.Forms.Label();
            this.btnTonKho = new System.Windows.Forms.Button();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numUpDownSL = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cbbTenMon = new System.Windows.Forms.ComboBox();
            this.DoAn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSL)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSMon
            // 
            this.dgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.id_do_an,
            this.ten,
            this.so_luong,
            this.gia,
            this.thanh_tien,
            this.edit,
            this.delete});
            this.dgvDSMon.Location = new System.Drawing.Point(0, 0);
            this.dgvDSMon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSMon.Name = "dgvDSMon";
            this.dgvDSMon.RowHeadersWidth = 62;
            this.dgvDSMon.RowTemplate.Height = 28;
            this.dgvDSMon.Size = new System.Drawing.Size(1522, 546);
            this.dgvDSMon.TabIndex = 0;
            this.dgvDSMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMon_CellContentClick);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 9;
            this.stt.Name = "stt";
            this.stt.Width = 93;
            // 
            // id_do_an
            // 
            this.id_do_an.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id_do_an.HeaderText = "Mã món";
            this.id_do_an.MinimumWidth = 8;
            this.id_do_an.Name = "id_do_an";
            this.id_do_an.Width = 124;
            // 
            // ten
            // 
            this.ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ten.HeaderText = "Tên món";
            this.ten.MinimumWidth = 8;
            this.ten.Name = "ten";
            // 
            // so_luong
            // 
            this.so_luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 8;
            this.so_luong.Name = "so_luong";
            this.so_luong.Width = 131;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.gia.HeaderText = "Đơn giá";
            this.gia.MinimumWidth = 9;
            this.gia.Name = "gia";
            this.gia.Width = 120;
            // 
            // thanh_tien
            // 
            this.thanh_tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanh_tien.HeaderText = "Thành tiền";
            this.thanh_tien.MinimumWidth = 8;
            this.thanh_tien.Name = "thanh_tien";
            // 
            // edit
            // 
            this.edit.HeaderText = "Sửa";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.MinimumWidth = 9;
            this.edit.Name = "edit";
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.HeaderText = "Xóa";
            this.delete.Image = global::Rapchieuphim.Properties.Resources.Delete_S;
            this.delete.MinimumWidth = 9;
            this.delete.Name = "delete";
            this.delete.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.btnTieptuc);
            this.panel1.Controls.Add(this.lblTonkho);
            this.panel1.Controls.Add(this.lblThem);
            this.panel1.Controls.Add(this.btnTonKho);
            this.panel1.Controls.Add(this.cbbLoai);
            this.panel1.Controls.Add(this.lblLoai);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.numUpDownSL);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.cbbTenMon);
            this.panel1.Controls.Add(this.DoAn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1522, 311);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnTieptuc.Location = new System.Drawing.Point(1100, 232);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(140, 53);
            this.btnTieptuc.TabIndex = 13;
            this.btnTieptuc.Text = "Tiếp tục";
            this.btnTieptuc.UseVisualStyleBackColor = true;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click_1);
            // 
            // lblTonkho
            // 
            this.lblTonkho.AutoSize = true;
            this.lblTonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonkho.Location = new System.Drawing.Point(960, 146);
            this.lblTonkho.Name = "lblTonkho";
            this.lblTonkho.Size = new System.Drawing.Size(175, 31);
            this.lblTonkho.TabIndex = 12;
            this.lblTonkho.Text = "Hàng tồn kho";
            // 
            // lblThem
            // 
            this.lblThem.AutoSize = true;
            this.lblThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThem.Location = new System.Drawing.Point(475, 146);
            this.lblThem.Name = "lblThem";
            this.lblThem.Size = new System.Drawing.Size(83, 31);
            this.lblThem.TabIndex = 11;
            this.lblThem.Text = "Order";
            // 
            // btnTonKho
            // 
            this.btnTonKho.BackColor = System.Drawing.Color.PeachPuff;
            this.btnTonKho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTonKho.BackgroundImage")));
            this.btnTonKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTonKho.Location = new System.Drawing.Point(1141, 131);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Size = new System.Drawing.Size(99, 67);
            this.btnTonKho.TabIndex = 10;
            this.btnTonKho.UseVisualStyleBackColor = false;
            this.btnTonKho.Click += new System.EventHandler(this.btnTonKho_Click);
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(169, 58);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(206, 32);
            this.cbbLoai.TabIndex = 9;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(29, 57);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(124, 31);
            this.lblLoai.TabIndex = 8;
            this.lblLoai.Text = "Loại món";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(618, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 67);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numUpDownSL
            // 
            this.numUpDownSL.Location = new System.Drawing.Point(169, 146);
            this.numUpDownSL.Name = "numUpDownSL";
            this.numUpDownSL.Size = new System.Drawing.Size(77, 29);
            this.numUpDownSL.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(29, 146);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(120, 31);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // cbbTenMon
            // 
            this.cbbTenMon.FormattingEnabled = true;
            this.cbbTenMon.Location = new System.Drawing.Point(618, 60);
            this.cbbTenMon.Name = "cbbTenMon";
            this.cbbTenMon.Size = new System.Drawing.Size(233, 32);
            this.cbbTenMon.TabIndex = 3;
            // 
            // DoAn
            // 
            this.DoAn.AutoSize = true;
            this.DoAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoAn.Location = new System.Drawing.Point(475, 61);
            this.DoAn.Name = "DoAn";
            this.DoAn.Size = new System.Drawing.Size(120, 31);
            this.DoAn.TabIndex = 2;
            this.DoAn.Text = "Tên món";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDSMon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1522, 546);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(0, 857);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1522, 403);
            this.panel3.TabIndex = 3;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Sửa";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 9;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 175;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Xóa";
            this.dataGridViewImageColumn2.Image = global::Rapchieuphim.Properties.Resources.Delete_S;
            this.dataGridViewImageColumn2.MinimumWidth = 9;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 175;
            // 
            // frmbanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1522, 1260);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmbanhang";
            this.Text = "Order Món";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmbanhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSL)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numUpDownSL;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cbbTenMon;
        private System.Windows.Forms.Label DoAn;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblTonkho;
        private System.Windows.Forms.Label lblThem;
        private System.Windows.Forms.Button btnTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_do_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanh_tien;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Button btnTieptuc;
    }
}