namespace Rapchieuphim
{
    partial class Thanhtoan
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
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.lblmakhachhang = new System.Windows.Forms.Label();
            this.lblphuongthuctt = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.dtGVthanhtoan = new System.Windows.Forms.DataGridView();
            this.lblthanhtoan = new System.Windows.Forms.Label();
            this.cbBphuongthuctt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVthanhtoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(902, 82);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(185, 26);
            this.txtmanv.TabIndex = 10;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(226, 76);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(210, 26);
            this.txtmakh.TabIndex = 9;
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Location = new System.Drawing.Point(750, 85);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(103, 20);
            this.lblmanhanvien.TabIndex = 8;
            this.lblmanhanvien.Text = "Mã nhân viên";
            // 
            // lblmakhachhang
            // 
            this.lblmakhachhang.AutoSize = true;
            this.lblmakhachhang.Location = new System.Drawing.Point(20, 82);
            this.lblmakhachhang.Name = "lblmakhachhang";
            this.lblmakhachhang.Size = new System.Drawing.Size(118, 20);
            this.lblmakhachhang.TabIndex = 7;
            this.lblmakhachhang.Text = "Mã khách hàng";
            this.lblmakhachhang.Click += new System.EventHandler(this.lblmakhachhang_Click);
            // 
            // lblphuongthuctt
            // 
            this.lblphuongthuctt.AutoSize = true;
            this.lblphuongthuctt.Location = new System.Drawing.Point(19, 154);
            this.lblphuongthuctt.Name = "lblphuongthuctt";
            this.lblphuongthuctt.Size = new System.Drawing.Size(180, 20);
            this.lblphuongthuctt.TabIndex = 12;
            this.lblphuongthuctt.Text = "Phương thức thanh toán";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 558);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 26);
            this.textBox4.TabIndex = 15;
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(23, 564);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(75, 20);
            this.lbltongtien.TabIndex = 14;
            this.lbltongtien.Text = "Tổng tiền";
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(902, 558);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(176, 43);
            this.btnxacnhan.TabIndex = 13;
            this.btnxacnhan.Text = "Xác nhận";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            // 
            // dtGVthanhtoan
            // 
            this.dtGVthanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVthanhtoan.Location = new System.Drawing.Point(-8, 214);
            this.dtGVthanhtoan.Name = "dtGVthanhtoan";
            this.dtGVthanhtoan.RowHeadersWidth = 62;
            this.dtGVthanhtoan.RowTemplate.Height = 28;
            this.dtGVthanhtoan.Size = new System.Drawing.Size(1148, 283);
            this.dtGVthanhtoan.TabIndex = 16;
            // 
            // lblthanhtoan
            // 
            this.lblthanhtoan.AutoSize = true;
            this.lblthanhtoan.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhtoan.ForeColor = System.Drawing.Color.Maroon;
            this.lblthanhtoan.Location = new System.Drawing.Point(464, 19);
            this.lblthanhtoan.Name = "lblthanhtoan";
            this.lblthanhtoan.Size = new System.Drawing.Size(228, 40);
            this.lblthanhtoan.TabIndex = 17;
            this.lblthanhtoan.Text = "Thanh Toán";
            // 
            // cbBphuongthuctt
            // 
            this.cbBphuongthuctt.FormattingEnabled = true;
            this.cbBphuongthuctt.Location = new System.Drawing.Point(226, 154);
            this.cbBphuongthuctt.Name = "cbBphuongthuctt";
            this.cbBphuongthuctt.Size = new System.Drawing.Size(210, 28);
            this.cbBphuongthuctt.TabIndex = 18;
            // 
            // Thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1142, 635);
            this.Controls.Add(this.cbBphuongthuctt);
            this.Controls.Add(this.lblthanhtoan);
            this.Controls.Add(this.dtGVthanhtoan);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.lblphuongthuctt);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.lblmanhanvien);
            this.Controls.Add(this.lblmakhachhang);
            this.Name = "Thanhtoan";
            this.Text = "Thanhtoan";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVthanhtoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.Label lblmakhachhang;
        private System.Windows.Forms.Label lblphuongthuctt;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.DataGridView dtGVthanhtoan;
        private System.Windows.Forms.Label lblthanhtoan;
        private System.Windows.Forms.ComboBox cbBphuongthuctt;
    }
}