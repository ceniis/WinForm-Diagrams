using Lab5;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace TestProjectLab5
{
    [TestFixture]
    public class ChartTests
    {
        [Test]
        public void GetBrush_ReturnsCorrectBrush()
        {
            Chart chart = new Chart(new List<int>(), 0); // Create an instance of Chart
            Brush brush1 = chart.GetBrush(0);
            Brush brush2 = chart.GetBrush(1);
            Brush brush8 = chart.GetBrush(8);

            Assert.AreEqual(Brushes.Red, brush1);
            Assert.AreEqual(Brushes.Green, brush2);
            Assert.AreEqual(Brushes.Red, brush8); // Check for wrap around
        }

        [Test]
        public void DrawPieChart_HandlesEmptyValues()
        {
            Chart chart = new Chart(new List<int>(), 0);
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);

            // This should not throw an exception
            Assert.DoesNotThrow(() => chart.DrawPieChart(g));
        }

        [Test]
        public void DrawVerticalBarChart_HandlesEmptyValues()
        {
            Chart chart = new Chart(new List<int>(), 1);
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);

            // This should not throw an exception
            Assert.DoesNotThrow(() => chart.DrawVerticalBarChart(g));
        }

        [Test]
        public void DrawHorizontalBarChart_HandlesEmptyValues()
        {
            Chart chart = new Chart(new List<int>(), 2);
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);

            // This should not throw an exception
            Assert.DoesNotThrow(() => chart.DrawHorizontalBarChart(g));
        }
    }
}