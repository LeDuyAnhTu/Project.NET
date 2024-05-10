using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using Series = DevExpress.XtraCharts.Series;

namespace Project.NET.ExtensionMethods
{
    public static class ChartControlExtensions
    {
        /// <summary>
        /// Hỗ trợ tạo thống kê nhanh chóng với các tham số truyền vào cụ thể
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chart">biểu đồ cần tạo thống kê</param>
        /// <param name="dataPoints">Nguồn dữ liệu</param>
        /// <param name="argumentSelector">Cột thành viên</param>
        /// <param name="valueSelector">Giá trị của từng cột thành viên</param>
        /// <param name="viewType">Biểu đồ cột hoặc tròn tùy chỉnh</param>
        /// <param name="seriesName">Tên biểu đồ</param>
        /// <param name="xAxisTitle">Tên cột đứng</param>
        /// <param name="yAxisTitle">Tên cột ngang</param>
        /// <param name="chartTitle">Tiêu đề thống kê biểu đồ</param>
        public static void SuportCreateChart<T>(this ChartControl chart, List<T> dataPoints, Func<T, object> argumentSelector, Func<T, object> valueSelector, ViewType viewType, string seriesName, string xAxisTitle, string yAxisTitle, string chartTitle)
        {
            // Clear existing series
            if (chart.Series.Count > 0)
            {
                chart.Series.Clear();
            }

            // Create new series
            Series series = new Series(seriesName, viewType);

            // Add data points to series
            foreach (var dataPoint in dataPoints)
            {
                series.Points.Add(new SeriesPoint(argumentSelector(dataPoint), valueSelector(dataPoint)));
            }

            // Add series to chart
            chart.Series.Add(series);

            // Configure X axis
            XYDiagram diagram = (XYDiagram)chart.Diagram;
            if (diagram != null)
            {
                diagram.AxisX.Title.Text = xAxisTitle;
                diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

                // Configure Y axis
                diagram.AxisY.Title.Text = yAxisTitle;
                diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            }

            // Configure chart title
            if (chart.Titles.Count == 0)
            {
                chart.Titles.Add(new ChartTitle() { Text = chartTitle });
            }
        }
        /// <summary>
        /// Chart này thể hiện nhiều hơn 1 series ví dụ giới tính
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="chart">biểu đồ cần tạo thống kê</param>
        /// <param name="dataPoints">Nguồn dữ liệu</param>
        /// <param name="argumentSelector">Cột thành viên</param>
        /// <param name="valueSelector">Giá trị của từng cột thành viên</param>
        /// <param name="seriesSelector">ví dụ: Giới tính Nam/Nữ tăng thêm cột mới</param>
        /// <param name="viewType">Biểu đồ cột hoặc tròn tùy chỉnh</param>
        /// <param name="seriesName">Tên biểu đồ</param>
        /// <param name="xAxisTitle">Tên cột đứng</param>
        /// <param name="yAxisTitle">Tên cột ngang</param>
        /// <param name="chartTitle">Tiêu đề thống kê biểu đồ</param>
        public static void SuportCreateChart<T>(this ChartControl chart, List<T> dataPoints, Func<T, object> argumentSelector, Func<T, object> valueSelector, Func<T, string> seriesSelector, ViewType viewType, string xAxisTitle, string yAxisTitle, string chartTitle)
        {
            // Clear existing series
            if (chart.Series.Count > 0)
            {
                chart.Series.Clear();
            }

            // Group data points by series
            var groupedDataPoints = dataPoints.GroupBy(seriesSelector);

            // Create a series for each group
            foreach (var group in groupedDataPoints)
            {
                Series series = new Series(group.Key, viewType);

                // Add data points to series
                foreach (var dataPoint in group)
                {
                    series.Points.Add(new SeriesPoint(argumentSelector(dataPoint), valueSelector(dataPoint)));
                }

                // Add series to chart
                chart.Series.Add(series);
            }

            // Configure X axis
            XYDiagram diagram = (XYDiagram)chart.Diagram;
            if (diagram != null)
            {
                diagram.AxisX.Title.Text = xAxisTitle;
                diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

                // Configure Y axis
                diagram.AxisY.Title.Text = yAxisTitle;
                diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            }

            // Configure chart title
            if (chart.Titles.Count == 0)
            {
                chart.Titles.Add(new ChartTitle() { Text = chartTitle });
            }
        }

    }
}
