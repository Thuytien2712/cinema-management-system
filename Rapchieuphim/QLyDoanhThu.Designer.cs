namespace Rapchieuphim
{
    partial class QLyDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label = new System.Windows.Forms.Label();
            this.lbltitlethoigian = new System.Windows.Forms.Label();
            this.lblthoigian = new System.Windows.Forms.Label();
            this.lbltongluotban = new System.Windows.Forms.Label();
            this.lbltitletongluotban = new System.Windows.Forms.Label();
            this.lbldoanhthu = new System.Windows.Forms.Label();
            this.btnThongke = new System.Windows.Forms.Button();
            this.dTPdenngay = new System.Windows.Forms.DateTimePicker();
            this.dtPtungay = new System.Windows.Forms.DateTimePicker();
            this.lbltitleTongdoanhthu = new System.Windows.Forms.Label();
            this.lbldenngay = new System.Windows.Forms.Label();
            this.lbltungay = new System.Windows.Forms.Label();
            this.chartdoanhthu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Firebrick;
            this.label.Location = new System.Drawing.Point(417, 24);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(324, 37);
            this.label.TabIndex = 24;
            this.label.Text = "Thống Kê Doanh Thu";
            // 
            // lbltitlethoigian
            // 
            this.lbltitlethoigian.AutoSize = true;
            this.lbltitlethoigian.Location = new System.Drawing.Point(53, 141);
            this.lbltitlethoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitlethoigian.Name = "lbltitlethoigian";
            this.lbltitlethoigian.Size = new System.Drawing.Size(99, 25);
            this.lbltitlethoigian.TabIndex = 23;
            this.lbltitlethoigian.Text = "Thời gian:";
            // 
            // lblthoigian
            // 
            this.lblthoigian.AutoSize = true;
            this.lblthoigian.Location = new System.Drawing.Point(233, 141);
            this.lblthoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(108, 25);
            this.lblthoigian.TabIndex = 22;
            this.lblthoigian.Text = "dd/mm/yyy";
            // 
            // lbltongluotban
            // 
            this.lbltongluotban.AutoSize = true;
            this.lbltongluotban.Location = new System.Drawing.Point(245, 227);
            this.lbltongluotban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltongluotban.Name = "lbltongluotban";
            this.lbltongluotban.Size = new System.Drawing.Size(23, 25);
            this.lbltongluotban.TabIndex = 21;
            this.lbltongluotban.Text = "0";
            // 
            // lbltitletongluotban
            // 
            this.lbltitletongluotban.AutoSize = true;
            this.lbltitletongluotban.Location = new System.Drawing.Point(53, 227);
            this.lbltitletongluotban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitletongluotban.Name = "lbltitletongluotban";
            this.lbltitletongluotban.Size = new System.Drawing.Size(138, 25);
            this.lbltitletongluotban.TabIndex = 20;
            this.lbltitletongluotban.Text = "Tổng lượt bán:";
            // 
            // lbldoanhthu
            // 
            this.lbldoanhthu.AutoSize = true;
            this.lbldoanhthu.Location = new System.Drawing.Point(245, 181);
            this.lbldoanhthu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldoanhthu.Name = "lbldoanhthu";
            this.lbldoanhthu.Size = new System.Drawing.Size(55, 25);
            this.lbldoanhthu.TabIndex = 19;
            this.lbldoanhthu.Text = "0vnd";
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(918, 181);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(198, 70);
            this.btnThongke.TabIndex = 18;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // dTPdenngay
            // 
            this.dTPdenngay.Location = new System.Drawing.Point(858, 96);
            this.dTPdenngay.Margin = new System.Windows.Forms.Padding(4);
            this.dTPdenngay.Name = "dTPdenngay";
            this.dTPdenngay.Size = new System.Drawing.Size(366, 29);
            this.dTPdenngay.TabIndex = 17;
            // 
            // dtPtungay
            // 
            this.dtPtungay.Location = new System.Drawing.Point(202, 90);
            this.dtPtungay.Margin = new System.Windows.Forms.Padding(4);
            this.dtPtungay.Name = "dtPtungay";
            this.dtPtungay.Size = new System.Drawing.Size(369, 29);
            this.dtPtungay.TabIndex = 16;
            // 
            // lbltitleTongdoanhthu
            // 
            this.lbltitleTongdoanhthu.AutoSize = true;
            this.lbltitleTongdoanhthu.Location = new System.Drawing.Point(53, 181);
            this.lbltitleTongdoanhthu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitleTongdoanhthu.Name = "lbltitleTongdoanhthu";
            this.lbltitleTongdoanhthu.Size = new System.Drawing.Size(156, 25);
            this.lbltitleTongdoanhthu.TabIndex = 15;
            this.lbltitleTongdoanhthu.Text = "Tổng doanh thu:";
            // 
            // lbldenngay
            // 
            this.lbldenngay.AutoSize = true;
            this.lbldenngay.Location = new System.Drawing.Point(657, 96);
            this.lbldenngay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldenngay.Name = "lbldenngay";
            this.lbldenngay.Size = new System.Drawing.Size(102, 25);
            this.lbldenngay.TabIndex = 14;
            this.lbldenngay.Text = "Đến ngày:";
            // 
            // lbltungay
            // 
            this.lbltungay.AutoSize = true;
            this.lbltungay.Location = new System.Drawing.Point(53, 90);
            this.lbltungay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltungay.Name = "lbltungay";
            this.lbltungay.Size = new System.Drawing.Size(90, 25);
            this.lbltungay.TabIndex = 13;
            this.lbltungay.Text = "Từ ngày:";
            // 
            // chartdoanhthu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartdoanhthu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartdoanhthu.Legends.Add(legend1);
            this.chartdoanhthu.Location = new System.Drawing.Point(33, 298);
            this.chartdoanhthu.Name = "chartdoanhthu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartdoanhthu.Series.Add(series1);
            this.chartdoanhthu.Size = new System.Drawing.Size(1200, 452);
            this.chartdoanhthu.TabIndex = 7;
            this.chartdoanhthu.Text = "chart1";
            // 
            // QLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1297, 775);
            this.Controls.Add(this.chartdoanhthu);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbltitlethoigian);
            this.Controls.Add(this.lblthoigian);
            this.Controls.Add(this.lbltongluotban);
            this.Controls.Add(this.lbltitletongluotban);
            this.Controls.Add(this.lbldoanhthu);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.dTPdenngay);
            this.Controls.Add(this.dtPtungay);
            this.Controls.Add(this.lbltitleTongdoanhthu);
            this.Controls.Add(this.lbldenngay);
            this.Controls.Add(this.lbltungay);
            this.Name = "QLyDoanhThu";
            this.Text = "QLyDoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartdoanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbltitlethoigian;
        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Label lbltongluotban;
        private System.Windows.Forms.Label lbltitletongluotban;
        private System.Windows.Forms.Label lbldoanhthu;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.DateTimePicker dTPdenngay;
        private System.Windows.Forms.DateTimePicker dtPtungay;
        private System.Windows.Forms.Label lbltitleTongdoanhthu;
        private System.Windows.Forms.Label lbldenngay;
        private System.Windows.Forms.Label lbltungay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartdoanhthu;
    }
}