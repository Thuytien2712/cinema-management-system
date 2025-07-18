namespace Rapchieuphim
{
    partial class TimKiemPhim
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
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.pnlChitietphim = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackgroundImage = global::Rapchieuphim.Properties.Resources.system_regular_42_search;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.Location = new System.Drawing.Point(1338, 102);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(72, 69);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // pnlChitietphim
            // 
            this.pnlChitietphim.AutoScroll = true;
            this.pnlChitietphim.BackColor = System.Drawing.Color.MistyRose;
            this.pnlChitietphim.Location = new System.Drawing.Point(16, 249);
            this.pnlChitietphim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChitietphim.Name = "pnlChitietphim";
            this.pnlChitietphim.Size = new System.Drawing.Size(1392, 600);
            this.pnlChitietphim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập tên phim";
            // 
            // textBoxTen
            // 
            this.textBoxTen.Location = new System.Drawing.Point(16, 102);
            this.textBoxTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTen.Multiline = true;
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(1312, 67);
            this.textBoxTen.TabIndex = 6;
            // 
            // TimKiemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1433, 903);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlChitietphim);
            this.Controls.Add(this.btnTimkiem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimKiemPhim";
            this.Text = "`";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TimKiemPhim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Panel pnlChitietphim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTen;
    }
}