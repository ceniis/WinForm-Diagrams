using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace Lab5
{
    public partial class MainForm : Form
    {
        List<int> values = new List<int>();
        int chartType;
        public MainForm()
        {
            InitializeComponent();
            if (dataGridView1.Columns.Count == 0)
                dataGridView1.Columns.Add("Value", "Value");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int numberOfElements = (int)numericUpDownElements.Value;
            int min = (int)numericUpDownMin.Value;
            int max = (int)numericUpDownMax.Value;
            values.Clear();

            Random random = new();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < numberOfElements; i++)
            {
                int value = random.Next(min, max + 1);
                values.Add(value);
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, value);
                row.DefaultCellStyle.ForeColor = Color.Purple;
                dataGridView1.Rows.Add(row);
            }

            dataGridView1.Refresh();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (values.Count == 0)
            {
                MessageBox.Show("Please, generate values.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radioButtonVerticalBarChart.Checked) chartType = 1; // Vertical Bar Chart
            else if (radioButtonHorizontalBarChart.Checked) chartType = 2; // Horizontal Bar Chart
            else chartType = 0; // Pie Chart (by default)

            Chart charts = new Chart(values, chartType);
            charts.Show();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int numberOfElements = (int)numericUpDownElements.Value;
            int min = (int)numericUpDownMin.Value;
            int max = (int)numericUpDownMax.Value;
            values.Sort();
            dataGridView1.Rows.Clear();
            foreach (int value in values)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1, value);
                row.DefaultCellStyle.ForeColor = Color.Purple;
                dataGridView1.Rows.Add(row);
            }

            dataGridView1.Refresh();
        }
    }
}