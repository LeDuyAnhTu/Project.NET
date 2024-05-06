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
        public static void CreateChart<T>(this ChartControl chart, List<T> dataPoints, Func<T, object> argumentSelector, Func<T, object> valueSelector, ViewType viewType, string seriesName, string xAxisTitle, string yAxisTitle, string chartTitle)
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
    }


}
