namespace Rapchieuphim
{
    partial class QlSuatChieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QlSuatChieu));
            this.lbllichchieu = new System.Windows.Forms.Label();
            this.lblmaphong = new System.Windows.Forms.Label();
            this.lblmaphim = new System.Windows.Forms.Label();
            this.lblthoigianchieu = new System.Windows.Forms.Label();
            this.lblthoigianhet = new System.Windows.Forms.Label();
            this.dtPthoigianchieu = new System.Windows.Forms.DateTimePicker();
            this.dtPthoigianhet = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dtGVQLSuatChieu = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPhong = new System.Windows.Forms.ComboBox();
            this.comboBoxPhim = new System.Windows.Forms.ComboBox();
            this.labelSC = new System.Windows.Forms.Label();
            this.textBoxSC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVQLSuatChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllichchieu
            // 
            this.lbllichchieu.AutoSize = true;
            this.lbllichchieu.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllichchieu.ForeColor = System.Drawing.Color.Maroon;
            this.lbllichchieu.Location = new System.Drawing.Point(89, 264);
            this.lbllichchieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllichchieu.Name = "lbllichchieu";
            this.lbllichchieu.Size = new System.Drawing.Size(227, 58);
            this.lbllichchieu.TabIndex = 0;
            this.lbllichchieu.Text = "Lịch chiếu";
            // 
            // lblmaphong
            // 
            this.lblmaphong.AutoSize = true;
            this.lblmaphong.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaphong.ForeColor = System.Drawing.Color.Maroon;
            this.lblmaphong.Location = new System.Drawing.Point(399, 108);
            this.lblmaphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmaphong.Name = "lblmaphong";
            this.lblmaphong.Size = new System.Drawing.Size(100, 23);
            this.lblmaphong.TabIndex = 1;
            this.lblmaphong.Text = "Mã Phòng";
            // 
            // lblmaphim
            // 
            this.lblmaphim.AutoSize = true;
            this.lblmaphim.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaphim.ForeColor = System.Drawing.Color.Maroon;
            this.lblmaphim.Location = new System.Drawing.Point(400, 184);
            this.lblmaphim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmaphim.Name = "lblmaphim";
            this.lblmaphim.Size = new System.Drawing.Size(58, 23);
            this.lblmaphim.TabIndex = 2;
            this.lblmaphim.Text = "Phim";
            // 
            // lblthoigianchieu
            // 
            this.lblthoigianchieu.AutoSize = true;
            this.lblthoigianchieu.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoigianchieu.ForeColor = System.Drawing.Color.Maroon;
            this.lblthoigianchieu.Location = new System.Drawing.Point(861, 75);
            this.lblthoigianchieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthoigianchieu.Name = "lblthoigianchieu";
            this.lblthoigianchieu.Size = new System.Drawing.Size(151, 23);
            this.lblthoigianchieu.TabIndex = 3;
            this.lblthoigianchieu.Text = "Thời gian chiếu";
            // 
            // lblthoigianhet
            // 
            this.lblthoigianhet.AutoSize = true;
            this.lblthoigianhet.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoigianhet.ForeColor = System.Drawing.Color.Maroon;
            this.lblthoigianhet.Location = new System.Drawing.Point(862, 170);
            this.lblthoigianhet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthoigianhet.Name = "lblthoigianhet";
            this.lblthoigianhet.Size = new System.Drawing.Size(131, 23);
            this.lblthoigianhet.TabIndex = 4;
            this.lblthoigianhet.Text = "Thời gian hết";
            // 
            // dtPthoigianchieu
            // 
            this.dtPthoigianchieu.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtPthoigianchieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPthoigianchieu.Location = new System.Drawing.Point(1024, 72);
            this.dtPthoigianchieu.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dtPthoigianchieu.Name = "dtPthoigianchieu";
            this.dtPthoigianchieu.Size = new System.Drawing.Size(253, 29);
            this.dtPthoigianchieu.TabIndex = 52;
            // 
            // dtPthoigianhet
            // 
            this.dtPthoigianhet.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtPthoigianhet.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPthoigianhet.Location = new System.Drawing.Point(1027, 170);
            this.dtPthoigianhet.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dtPthoigianhet.Name = "dtPthoigianhet";
            this.dtPthoigianhet.Size = new System.Drawing.Size(247, 29);
            this.dtPthoigianhet.TabIndex = 53;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Maroon;
            this.btnHuy.Location = new System.Drawing.Point(1040, 264);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(138, 38);
            this.btnHuy.TabIndex = 57;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Maroon;
            this.btnTim.Location = new System.Drawing.Point(837, 264);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(138, 38);
            this.btnTim.TabIndex = 56;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Maroon;
            this.btnXoa.Location = new System.Drawing.Point(666, 264);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 38);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Maroon;
            this.btnthem.Location = new System.Drawing.Point(494, 264);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(138, 38);
            this.btnthem.TabIndex = 54;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // dtGVQLSuatChieu
            // 
            this.dtGVQLSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVQLSuatChieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGVQLSuatChieu.Location = new System.Drawing.Point(0, 354);
            this.dtGVQLSuatChieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtGVQLSuatChieu.Name = "dtGVQLSuatChieu";
            this.dtGVQLSuatChieu.RowHeadersWidth = 62;
            this.dtGVQLSuatChieu.RowTemplate.Height = 28;
            this.dtGVQLSuatChieu.Size = new System.Drawing.Size(1335, 382);
            this.dtGVQLSuatChieu.TabIndex = 58;
            this.dtGVQLSuatChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVQLSuatChieu_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(52, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 200);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxPhong
            // 
            this.comboBoxPhong.FormattingEnabled = true;
            this.comboBoxPhong.Location = new System.Drawing.Point(568, 102);
            this.comboBoxPhong.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPhong.Name = "comboBoxPhong";
            this.comboBoxPhong.Size = new System.Drawing.Size(234, 32);
            this.comboBoxPhong.TabIndex = 60;
            // 
            // comboBoxPhim
            // 
            this.comboBoxPhim.FormattingEnabled = true;
            this.comboBoxPhim.Location = new System.Drawing.Point(469, 180);
            this.comboBoxPhim.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPhim.Name = "comboBoxPhim";
            this.comboBoxPhim.Size = new System.Drawing.Size(333, 32);
            this.comboBoxPhim.TabIndex = 61;
            // 
            // labelSC
            // 
            this.labelSC.AutoSize = true;
            this.labelSC.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSC.ForeColor = System.Drawing.Color.Maroon;
            this.labelSC.Location = new System.Drawing.Point(399, 40);
            this.labelSC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSC.Name = "labelSC";
            this.labelSC.Size = new System.Drawing.Size(140, 23);
            this.labelSC.TabIndex = 62;
            this.labelSC.Text = "Mã Suất Chiếu";
            // 
            // textBoxSC
            // 
            this.textBoxSC.Location = new System.Drawing.Point(568, 34);
            this.textBoxSC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSC.Name = "textBoxSC";
            this.textBoxSC.Size = new System.Drawing.Size(234, 29);
            this.textBoxSC.TabIndex = 63;
            // 
            // QlSuatChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1335, 736);
            this.Controls.Add(this.textBoxSC);
            this.Controls.Add(this.labelSC);
            this.Controls.Add(this.comboBoxPhim);
            this.Controls.Add(this.comboBoxPhong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGVQLSuatChieu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtPthoigianhet);
            this.Controls.Add(this.dtPthoigianchieu);
            this.Controls.Add(this.lblthoigianhet);
            this.Controls.Add(this.lblthoigianchieu);
            this.Controls.Add(this.lblmaphim);
            this.Controls.Add(this.lblmaphong);
            this.Controls.Add(this.lbllichchieu);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "QlSuatChieu";
            this.Text = "QlSuatChieu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QlSuatChieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVQLSuatChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllichchieu;
        private System.Windows.Forms.Label lblmaphong;
        private System.Windows.Forms.Label lblmaphim;
        private System.Windows.Forms.Label lblthoigianchieu;
        private System.Windows.Forms.Label lblthoigianhet;
        private System.Windows.Forms.DateTimePicker dtPthoigianchieu;
        private System.Windows.Forms.DateTimePicker dtPthoigianhet;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dtGVQLSuatChieu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxPhong;
        private System.Windows.Forms.ComboBox comboBoxPhim;
        private System.Windows.Forms.Label labelSC;
        private System.Windows.Forms.TextBox textBoxSC;
    }
}