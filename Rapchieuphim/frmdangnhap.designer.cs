namespace Rapchieuphim
{
    partial class frmdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(242, 326);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(101, 23);
            this.lblpassword.TabIndex = 12;
            this.lblpassword.Text = "Mật khẩu:";
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(647, 426);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(125, 50);
            this.btnhuy.TabIndex = 11;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(370, 326);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(471, 29);
            this.txtpassword.TabIndex = 10;
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.Location = new System.Drawing.Point(370, 250);
            this.txtdangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(471, 29);
            this.txtdangnhap.TabIndex = 9;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(242, 250);
            this.lblusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(61, 23);
            this.lblusername.TabIndex = 8;
            this.lblusername.Text = "Email";
            // 
            // btndangnhap
            // 
            this.btndangnhap.Font = new System.Drawing.Font("Constantia", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(417, 426);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(141, 50);
            this.btndangnhap.TabIndex = 7;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(543, 108);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 539);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtdangnhap);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btndangnhap);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmdangnhap";
            this.Text = "frmdangnhap";
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btndangnhap;
    }
}