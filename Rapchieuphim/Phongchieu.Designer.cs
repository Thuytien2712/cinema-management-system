namespace Rapchieuphim
{
    partial class Phongchieu
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
            this.pnlMahinh = new System.Windows.Forms.Panel();
            this.lblManhinh = new System.Windows.Forms.Label();
            this.pnlGhe = new System.Windows.Forms.Panel();
            this.labelPhong = new System.Windows.Forms.Label();
            this.pnlMahinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMahinh
            // 
            this.pnlMahinh.BackColor = System.Drawing.Color.IndianRed;
            this.pnlMahinh.Controls.Add(this.lblManhinh);
            this.pnlMahinh.Location = new System.Drawing.Point(16, 62);
            this.pnlMahinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMahinh.Name = "pnlMahinh";
            this.pnlMahinh.Size = new System.Drawing.Size(1532, 130);
            this.pnlMahinh.TabIndex = 0;
            // 
            // lblManhinh
            // 
            this.lblManhinh.AutoSize = true;
            this.lblManhinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManhinh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManhinh.Location = new System.Drawing.Point(580, 34);
            this.lblManhinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManhinh.Name = "lblManhinh";
            this.lblManhinh.Size = new System.Drawing.Size(367, 75);
            this.lblManhinh.TabIndex = 0;
            this.lblManhinh.Text = "MÀN HÌNH";
            // 
            // pnlGhe
            // 
            this.pnlGhe.BackColor = System.Drawing.Color.MistyRose;
            this.pnlGhe.Location = new System.Drawing.Point(16, 194);
            this.pnlGhe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGhe.Name = "pnlGhe";
            this.pnlGhe.Size = new System.Drawing.Size(1532, 916);
            this.pnlGhe.TabIndex = 1;
            // 
            // labelPhong
            // 
            this.labelPhong.AutoSize = true;
            this.labelPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhong.Location = new System.Drawing.Point(16, 14);
            this.labelPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhong.Name = "labelPhong";
            this.labelPhong.Size = new System.Drawing.Size(136, 38);
            this.labelPhong.TabIndex = 0;
            this.labelPhong.Text = "Phòng: ";
            // 
            // Phongchieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1565, 1128);
            this.Controls.Add(this.labelPhong);
            this.Controls.Add(this.pnlGhe);
            this.Controls.Add(this.pnlMahinh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Phongchieu";
            this.Text = "Phongchieu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMahinh.ResumeLayout(false);
            this.pnlMahinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMahinh;
        private System.Windows.Forms.Panel pnlGhe;
        private System.Windows.Forms.Label lblManhinh;
        private System.Windows.Forms.Label labelPhong;
    }
}