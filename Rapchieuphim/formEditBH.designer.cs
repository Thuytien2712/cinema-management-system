namespace Rapchieuphim
{
    partial class formEditBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditBH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblgiatien = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblhienThanhTien = new System.Windows.Forms.Label();
            this.lblhientensp = new System.Windows.Forms.Label();
            this.lbhiengiatien = new System.Windows.Forms.Label();
            this.numUpDownSL = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.lblThanhTien);
            this.panel1.Controls.Add(this.lblsoluong);
            this.panel1.Controls.Add(this.lblgiatien);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Location = new System.Drawing.Point(164, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 327);
            this.panel1.TabIndex = 0;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(430, 92);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(105, 25);
            this.lblThanhTien.TabIndex = 8;
            this.lblThanhTien.Text = "Thành tiền";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(176, 92);
            this.lblsoluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(90, 25);
            this.lblsoluong.TabIndex = 5;
            this.lblsoluong.Text = "Số lượng";
            // 
            // lblgiatien
            // 
            this.lblgiatien.AutoSize = true;
            this.lblgiatien.Location = new System.Drawing.Point(306, 92);
            this.lblgiatien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgiatien.Name = "lblgiatien";
            this.lblgiatien.Size = new System.Drawing.Size(79, 25);
            this.lblgiatien.TabIndex = 6;
            this.lblgiatien.Text = "Đơn giá";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(219, 249);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(133, 53);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.lblhienThanhTien);
            this.panel2.Controls.Add(this.lblhientensp);
            this.panel2.Controls.Add(this.lbhiengiatien);
            this.panel2.Controls.Add(this.numUpDownSL);
            this.panel2.Location = new System.Drawing.Point(164, 183);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 81);
            this.panel2.TabIndex = 0;
            // 
            // lblhienThanhTien
            // 
            this.lblhienThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblhienThanhTien.Location = new System.Drawing.Point(429, 12);
            this.lblhienThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhienThanhTien.Name = "lblhienThanhTien";
            this.lblhienThanhTien.Size = new System.Drawing.Size(112, 40);
            this.lblhienThanhTien.TabIndex = 5;
            this.lblhienThanhTien.Text = "0";
            this.lblhienThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblhientensp
            // 
            this.lblhientensp.Location = new System.Drawing.Point(13, 20);
            this.lblhientensp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhientensp.Name = "lblhientensp";
            this.lblhientensp.Size = new System.Drawing.Size(149, 40);
            this.lblhientensp.TabIndex = 0;
            this.lblhientensp.Text = "Tên sản phẩm";
            // 
            // lbhiengiatien
            // 
            this.lbhiengiatien.Location = new System.Drawing.Point(299, 12);
            this.lbhiengiatien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhiengiatien.Name = "lbhiengiatien";
            this.lbhiengiatien.Size = new System.Drawing.Size(94, 40);
            this.lbhiengiatien.TabIndex = 3;
            this.lbhiengiatien.Text = "0";
            this.lbhiengiatien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numUpDownSL
            // 
            this.numUpDownSL.Location = new System.Drawing.Point(180, 18);
            this.numUpDownSL.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownSL.Name = "numUpDownSL";
            this.numUpDownSL.Size = new System.Drawing.Size(83, 29);
            this.numUpDownSL.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 327);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // formEditBH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(718, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formEditBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblhientensp;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblgiatien;
        private System.Windows.Forms.NumericUpDown numUpDownSL;
        private System.Windows.Forms.Label lbhiengiatien;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblhienThanhTien;
    }
}