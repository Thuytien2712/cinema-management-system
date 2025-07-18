namespace Rapchieuphim
{
    partial class LichChieu
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
            this.panelSC = new System.Windows.Forms.Panel();
            this.labelTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelSC
            // 
            this.panelSC.BackColor = System.Drawing.Color.MistyRose;
            this.panelSC.Location = new System.Drawing.Point(0, 105);
            this.panelSC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSC.Name = "panelSC";
            this.panelSC.Size = new System.Drawing.Size(1480, 770);
            this.panelSC.TabIndex = 0;
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(3, 27);
            this.labelTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(372, 44);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "LỊCH CHIẾU PHIM: ";
            // 
            // LichChieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1481, 878);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.panelSC);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LichChieu";
            this.Text = "LichChieu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LichChieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSC;
        private System.Windows.Forms.Label labelTen;
    }
}