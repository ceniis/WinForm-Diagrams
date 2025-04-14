using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Chart : Form
    {
        private List<int> values;
        private int chartType;

        public Chart(List<int> values, int chartType)
        {
            InitializeComponent();

            this.values = values;
            this.chartType = chartType;
            this.Paint += Chart_Paint; // add event Paint
            this.WindowState = FormWindowState.Maximized;
        }

        public Brush GetBrush(int index)
        {
            Brush[] brushes = { Brushes.Red, Brushes.Green, Brushes.Blue, Brushes.Orange, Brushes.Purple, Brushes.Yellow, Brushes.Cyan, Brushes.Magenta };
            return brushes[index % brushes.Length];
        }

        public void Chart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (chartType == 0) // Pie Chart
            {
                DrawPieChart(g);
            }
            else if (chartType == 1) // Vertical Bar Chart
            {
                DrawVerticalBarChart(g);
            }
            else if (chartType == 2) // Horizontal Bar Chart
            {
                DrawHorizontalBarChart(g);
            }
        }

        public void DrawPieChart(Graphics g)
        {
            if (values == null || values.Count == 0) return;

            int total = values.Sum();
            float startAngle = 0;
            int x = ClientSize.Width / 4, y = 10, width = ClientSize.Height - 20, height = ClientSize.Height - 20;

            for (int i = 0; i < values.Count; i++)
            {
                float sweepAngle = (float)(360.0 * values[i] / total);
                g.FillPie(GetBrush(i), x, y, width, height, startAngle, sweepAngle);
                startAngle += sweepAngle;
            }

            label1.Text = "Pie Chart";
        }

        public void DrawVerticalBarChart(Graphics g)
        {
            if (values == null || values.Count == 0) return;

            int maxVal = values.Max();
            float barWidth = (float)ClientSize.Width / values.Count * 0.8f;
            float margin = (float)ClientSize.Width / values.Count * 0.2f / 2;

            for (int i = 0; i < values.Count; i++)
            {
                float barHeight = (float)values[i] / maxVal * ClientSize.Height * 0.8f;
                float x = i * (barWidth + margin * 2) + margin;
                float y = ClientSize.Height - barHeight - 20;

                g.FillRectangle(GetBrush(i), x, y, barWidth, barHeight);
            }

            label1.Text = "Vertical Bar Chart";
        }

        public void DrawHorizontalBarChart(Graphics g)
        {
            if (values == null || values.Count == 0) return;

            int maxVal = values.Max();
            float barHeight = (float)ClientSize.Height / values.Count * 0.8f;
            float margin = (float)ClientSize.Height / values.Count * 0.2f / 2;

            for (int i = 0; i < values.Count; i++)
            {
                float barWidth = (float)values[i] / maxVal * ClientSize.Width * 0.8f;
                float x = 20;
                float y = i * (barHeight + margin * 2) + margin;

                g.FillRectangle(GetBrush(i), x, y, barWidth, barHeight);
            }


            label1.Text = "Horizontal Bar Chart";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}