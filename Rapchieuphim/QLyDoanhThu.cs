using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Rapchieuphim
{
    public partial class QLyDoanhThu : Form
    {
        private QLYDOANHTHUBL doanhThuBL = new QLYDOANHTHUBL();

        public QLyDoanhThu()
        {
            InitializeComponent();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtPtungay.Value;
            DateTime denNgay = dTPdenngay.Value;

            decimal tongDoanhThu = doanhThuBL.TinhTongDoanhThu(tuNgay, denNgay);
            lblthoigian.Text = $"{tuNgay.ToShortDateString()} đến {denNgay.ToShortDateString()}";
            lbldoanhthu.Text = $"{tongDoanhThu:N0} VND";

            Dictionary<DateTime, decimal> doanhThuTheoNgay = doanhThuBL.LayDoanhThuTheoNgay(tuNgay, denNgay);
            Dictionary<DateTime, decimal> doanhThuVeTheoNgay = doanhThuBL.LayDoanhThuVeTheoNgay(tuNgay, denNgay);
            Dictionary<DateTime, decimal> doanhThuDoAnTheoNgay = doanhThuBL.LayDoanhThuDoAnTheoNgay(tuNgay, denNgay);
            Dictionary<DateTime, int> soLuongHoaDonTheoNgay = doanhThuBL.LaySoLuongHoaDonTheoNgay(tuNgay, denNgay);
            // Tính tổng số lượt bán
            int tongLuotBan = soLuongHoaDonTheoNgay.Sum(item => item.Value);
            lbltongluotban.Text = $"{tongLuotBan}";

            // Hiển thị doanh thu theo ngày trên biểu đồ (sử dụng Chart control)
            chartdoanhthu.Series.Clear();
            chartdoanhthu.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("DoanhThuArea");
            chartdoanhthu.ChartAreas.Add(chartArea);



            // Thêm series cho Doanh Thu Vé
            var seriesVe = new Series("Doanh Thu Vé");
            seriesVe.ChartType = SeriesChartType.Column;
            foreach (var item in doanhThuVeTheoNgay)
            {
                seriesVe.Points.AddXY(item.Key.ToShortDateString(), item.Value);
            }
            chartdoanhthu.Series.Add(seriesVe);

            // Thêm series cho Doanh Thu Đồ Ăn
            var seriesDoAn = new Series("Doanh Thu Đồ Ăn");
            seriesDoAn.ChartType = SeriesChartType.Column;
            foreach (var item in doanhThuDoAnTheoNgay)
            {
                seriesDoAn.Points.AddXY(item.Key.ToShortDateString(), item.Value);
            }
            chartdoanhthu.Series.Add(seriesDoAn);

            if (chartdoanhthu.ChartAreas.Count > 0)
            {
                chartdoanhthu.ChartAreas[0].AxisX.Title = "Ngày";
                chartdoanhthu.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            }


            // Thiết lập thuộc tính để các cột không bị chồng lên nhau hoàn toàn
            chartdoanhthu.ChartAreas[0].AxisX.Interval = 1; // Hiển thị tất cả các ngày trên trục X

            chartdoanhthu.Series["Doanh Thu Vé"].IsValueShownAsLabel = true;
            chartdoanhthu.Series["Doanh Thu Đồ Ăn"].IsValueShownAsLabel = true;
            chartdoanhthu.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Xoay nhãn ngày nếu cần

            //// Để các cột không bị chồng hoàn toàn
            //chartdoanhthu.ChartAreas[0].AxisX.IsMarginVisible = true;
            //chartdoanhthu.ChartAreas[0].InnerPlotPosition.Auto = true;
        }
    }
}
