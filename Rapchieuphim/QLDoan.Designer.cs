namespace Rapchieuphim
{
    partial class QLDoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLDoan));
            this.lblGiaban = new System.Windows.Forms.Label();
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblQLMaGG = new System.Windows.Forms.Label();
            this.dgvDSMon = new System.Windows.Forms.DataGridView();
            this.id_do_an = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_con_lai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblNgayketthuc = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblTenmon = new System.Windows.Forms.Label();
            this.lblMamon = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtMamon = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtConlai = new System.Windows.Forms.TextBox();
            this.comboBoxLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiaban
            // 
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaban.Location = new System.Drawing.Point(94, 440);
            this.lblGiaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaban.Name = "lblGiaban";
            this.lblGiaban.Size = new System.Drawing.Size(131, 38);
            this.lblGiaban.TabIndex = 67;
            this.lblGiaban.Text = "Giá bán";
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(362, 256);
            this.txtTenmon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenmon.Multiline = true;
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(248, 46);
            this.txtTenmon.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(343, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // lblQLMaGG
            // 
            this.lblQLMaGG.AutoSize = true;
            this.lblQLMaGG.BackColor = System.Drawing.Color.Transparent;
            this.lblQLMaGG.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLMaGG.Location = new System.Drawing.Point(496, 42);
            this.lblQLMaGG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQLMaGG.Name = "lblQLMaGG";
            this.lblQLMaGG.Size = new System.Drawing.Size(361, 54);
            this.lblQLMaGG.TabIndex = 62;
            this.lblQLMaGG.Text = "QUẢN LÝ MÓN";
            // 
            // dgvDSMon
            // 
            this.dgvDSMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_do_an,
            this.ten,
            this.id_loai,
            this.gia,
            this.so_luong,
            this.sl_con_lai});
            this.dgvDSMon.Location = new System.Drawing.Point(38, 612);
            this.dgvDSMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDSMon.Name = "dgvDSMon";
            this.dgvDSMon.RowHeadersWidth = 51;
            this.dgvDSMon.RowTemplate.Height = 24;
            this.dgvDSMon.Size = new System.Drawing.Size(1354, 375);
            this.dgvDSMon.TabIndex = 61;
            this.dgvDSMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMon_CellClick);
            // 
            // id_do_an
            // 
            this.id_do_an.DataPropertyName = "id_do_an";
            this.id_do_an.HeaderText = "Mã món";
            this.id_do_an.MinimumWidth = 9;
            this.id_do_an.Name = "id_do_an";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên món";
            this.ten.MinimumWidth = 9;
            this.ten.Name = "ten";
            // 
            // id_loai
            // 
            this.id_loai.DataPropertyName = "id_loai";
            this.id_loai.HeaderText = "Loại";
            this.id_loai.MinimumWidth = 9;
            this.id_loai.Name = "id_loai";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 9;
            this.gia.Name = "gia";
            // 
            // so_luong
            // 
            this.so_luong.DataPropertyName = "so_luong";
            this.so_luong.HeaderText = "Số lượng";
            this.so_luong.MinimumWidth = 9;
            this.so_luong.Name = "so_luong";
            // 
            // sl_con_lai
            // 
            this.sl_con_lai.DataPropertyName = "sl_con_lai";
            this.sl_con_lai.HeaderText = "Tồn kho";
            this.sl_con_lai.MinimumWidth = 9;
            this.sl_con_lai.Name = "sl_con_lai";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSalmon;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1234, 402);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 73);
            this.btnHuy.TabIndex = 60;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1061, 402);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(114, 77);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(876, 402);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 77);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(695, 402);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 77);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblNgayketthuc
            // 
            this.lblNgayketthuc.AutoSize = true;
            this.lblNgayketthuc.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayketthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayketthuc.Location = new System.Drawing.Point(702, 256);
            this.lblNgayketthuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayketthuc.Name = "lblNgayketthuc";
            this.lblNgayketthuc.Size = new System.Drawing.Size(118, 38);
            this.lblNgayketthuc.TabIndex = 56;
            this.lblNgayketthuc.Text = "Còn lại";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(688, 167);
            this.lblSoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(145, 38);
            this.lblSoluong.TabIndex = 55;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(108, 343);
            this.lblLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(78, 38);
            this.lblLoai.TabIndex = 54;
            this.lblLoai.Text = "Loại";
            // 
            // lblTenmon
            // 
            this.lblTenmon.AutoSize = true;
            this.lblTenmon.BackColor = System.Drawing.Color.Transparent;
            this.lblTenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenmon.Location = new System.Drawing.Point(94, 247);
            this.lblTenmon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenmon.Name = "lblTenmon";
            this.lblTenmon.Size = new System.Drawing.Size(145, 38);
            this.lblTenmon.TabIndex = 53;
            this.lblTenmon.Text = "Tên món";
            // 
            // lblMamon
            // 
            this.lblMamon.AutoSize = true;
            this.lblMamon.BackColor = System.Drawing.Color.Transparent;
            this.lblMamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMamon.Location = new System.Drawing.Point(94, 167);
            this.lblMamon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMamon.Name = "lblMamon";
            this.lblMamon.Size = new System.Drawing.Size(134, 38);
            this.lblMamon.TabIndex = 52;
            this.lblMamon.Text = "Mã món";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(362, 432);
            this.txtGiaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaban.Multiline = true;
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(248, 46);
            this.txtGiaban.TabIndex = 51;
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(362, 158);
            this.txtMamon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMamon.Multiline = true;
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.ReadOnly = true;
            this.txtMamon.Size = new System.Drawing.Size(248, 46);
            this.txtMamon.TabIndex = 50;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(925, 167);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(248, 46);
            this.txtSoLuong.TabIndex = 71;
            // 
            // txtConlai
            // 
            this.txtConlai.Location = new System.Drawing.Point(925, 256);
            this.txtConlai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConlai.Multiline = true;
            this.txtConlai.Name = "txtConlai";
            this.txtConlai.Size = new System.Drawing.Size(248, 46);
            this.txtConlai.TabIndex = 72;
            // 
            // comboBoxLoai
            // 
            this.comboBoxLoai.FormattingEnabled = true;
            this.comboBoxLoai.Items.AddRange(new object[] {
            "Đồ ăn",
            "Nước uống"});
            this.comboBoxLoai.Location = new System.Drawing.Point(367, 343);
            this.comboBoxLoai.Name = "comboBoxLoai";
            this.comboBoxLoai.Size = new System.Drawing.Size(243, 32);
            this.comboBoxLoai.TabIndex = 73;
            // 
            // QLDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rapchieuphim.Properties.Resources.rapchieu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1426, 1001);
            this.Controls.Add(this.comboBoxLoai);
            this.Controls.Add(this.txtConlai);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblGiaban);
            this.Controls.Add(this.txtTenmon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQLMaGG);
            this.Controls.Add(this.dgvDSMon);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNgayketthuc);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblTenmon);
            this.Controls.Add(this.lblMamon);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.txtMamon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLDoan";
            this.Text = "QLDoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QLDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGiaban;
        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblQLMaGG;
        private System.Windows.Forms.DataGridView dgvDSMon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblNgayketthuc;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblTenmon;
        private System.Windows.Forms.Label lblMamon;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtMamon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtConlai;
        private System.Windows.Forms.ComboBox comboBoxLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_do_an;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_con_lai;
    }
}