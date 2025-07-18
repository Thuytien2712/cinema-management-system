namespace Rapchieuphim
{
    partial class formbapnuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formbapnuoc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblmakh = new System.Windows.Forms.Label();
            this.lblhienmakh = new System.Windows.Forms.Label();
            this.lbltensp = new System.Windows.Forms.Label();
            this.lbltensize = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lblgiatien = new System.Windows.Forms.Label();
            this.lblhientensp = new System.Windows.Forms.Label();
            this.llbhiengiatien = new System.Windows.Forms.Label();
            this.nudSL_pnl = new System.Windows.Forms.NumericUpDown();
            this.cbBsize = new System.Windows.Forms.ComboBox();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSL_pnl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(474, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 335);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.cbBsize);
            this.panel2.Controls.Add(this.nudSL_pnl);
            this.panel2.Controls.Add(this.llbhiengiatien);
            this.panel2.Controls.Add(this.lblhientensp);
            this.panel2.Location = new System.Drawing.Point(27, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 133);
            this.panel2.TabIndex = 0;
            // 
            // lblmakh
            // 
            this.lblmakh.AutoSize = true;
            this.lblmakh.Location = new System.Drawing.Point(617, 39);
            this.lblmakh.Name = "lblmakh";
            this.lblmakh.Size = new System.Drawing.Size(118, 20);
            this.lblmakh.TabIndex = 1;
            this.lblmakh.Text = "Mã khách hàng";
            // 
            // lblhienmakh
            // 
            this.lblhienmakh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblhienmakh.Location = new System.Drawing.Point(790, 50);
            this.lblhienmakh.Name = "lblhienmakh";
            this.lblhienmakh.Size = new System.Drawing.Size(239, 21);
            this.lblhienmakh.TabIndex = 2;
            // 
            // lbltensp
            // 
            this.lbltensp.AutoSize = true;
            this.lbltensp.Location = new System.Drawing.Point(539, 117);
            this.lbltensp.Name = "lbltensp";
            this.lbltensp.Size = new System.Drawing.Size(110, 20);
            this.lbltensp.TabIndex = 3;
            this.lbltensp.Text = "Tên sản phẩm";
            // 
            // lbltensize
            // 
            this.lbltensize.AutoSize = true;
            this.lbltensize.Location = new System.Drawing.Point(735, 117);
            this.lbltensize.Name = "lbltensize";
            this.lbltensize.Size = new System.Drawing.Size(40, 20);
            this.lbltensize.TabIndex = 4;
            this.lbltensize.Text = "Size";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(842, 117);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(72, 20);
            this.lblsoluong.TabIndex = 5;
            this.lblsoluong.Text = "Số lượng";
            // 
            // lblgiatien
            // 
            this.lblgiatien.AutoSize = true;
            this.lblgiatien.Location = new System.Drawing.Point(965, 117);
            this.lblgiatien.Name = "lblgiatien";
            this.lblgiatien.Size = new System.Drawing.Size(64, 20);
            this.lblgiatien.TabIndex = 6;
            this.lblgiatien.Text = "Giá tiền";
            // 
            // lblhientensp
            // 
            this.lblhientensp.Location = new System.Drawing.Point(35, 39);
            this.lblhientensp.Name = "lblhientensp";
            this.lblhientensp.Size = new System.Drawing.Size(122, 33);
            this.lblhientensp.TabIndex = 0;
            this.lblhientensp.Text = "Tên sản phẩm";
            // 
            // llbhiengiatien
            // 
            this.llbhiengiatien.Location = new System.Drawing.Point(471, 34);
            this.llbhiengiatien.Name = "llbhiengiatien";
            this.llbhiengiatien.Size = new System.Drawing.Size(99, 33);
            this.llbhiengiatien.TabIndex = 3;
            this.llbhiengiatien.Text = "0";
            // 
            // nudSL_pnl
            // 
            this.nudSL_pnl.Location = new System.Drawing.Point(363, 39);
            this.nudSL_pnl.Name = "nudSL_pnl";
            this.nudSL_pnl.Size = new System.Drawing.Size(68, 26);
            this.nudSL_pnl.TabIndex = 4;
            // 
            // cbBsize
            // 
            this.cbBsize.FormattingEnabled = true;
            this.cbBsize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cbBsize.Location = new System.Drawing.Point(215, 39);
            this.cbBsize.Name = "cbBsize";
            this.cbBsize.Size = new System.Drawing.Size(106, 28);
            this.cbBsize.TabIndex = 6;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Location = new System.Drawing.Point(882, 549);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(174, 43);
            this.btnthanhtoan.TabIndex = 7;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 641);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // formbapnuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1142, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.lblgiatien);
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.lbltensize);
            this.Controls.Add(this.lbltensp);
            this.Controls.Add(this.lblhienmakh);
            this.Controls.Add(this.lblmakh);
            this.Controls.Add(this.panel1);
            this.Name = "formbapnuoc";
            this.Text = "formbapnuoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSL_pnl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblmakh;
        private System.Windows.Forms.Label lblhienmakh;
        private System.Windows.Forms.Label lblhientensp;
        private System.Windows.Forms.Label lbltensp;
        private System.Windows.Forms.Label lbltensize;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lblgiatien;
        private System.Windows.Forms.ComboBox cbBsize;
        private System.Windows.Forms.NumericUpDown nudSL_pnl;
        private System.Windows.Forms.Label llbhiengiatien;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}