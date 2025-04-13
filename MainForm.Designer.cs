namespace Lab5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            numericUpDownElements = new NumericUpDown();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAbout = new Button();
            btnGenerate = new Button();
            btnShow = new Button();
            btnSort = new Button();
            radioButtonVerticalBarChart = new RadioButton();
            radioButtonHorizontalBarChart = new RadioButton();
            radioButtonPieChart = new RadioButton();
            groupBox1 = new GroupBox();
            label2 = new Label();
            numericUpDownMin = new NumericUpDown();
            label3 = new Label();
            numericUpDownMax = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownElements).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownElements
            // 
            numericUpDownElements.Cursor = Cursors.Hand;
            numericUpDownElements.ForeColor = Color.DarkViolet;
            numericUpDownElements.Location = new Point(208, 12);
            numericUpDownElements.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numericUpDownElements.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownElements.Name = "numericUpDownElements";
            numericUpDownElements.Size = new Size(119, 25);
            numericUpDownElements.TabIndex = 0;
            numericUpDownElements.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 19);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 1;
            label1.Text = "The number of elements:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(190, 179);
            dataGridView1.TabIndex = 2;
            // 
            // btnAbout
            // 
            btnAbout.BackgroundImage = (Image)resources.GetObject("btnAbout.BackgroundImage");
            btnAbout.Cursor = Cursors.Help;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.MouseOverBackColor = Color.Thistle;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Location = new Point(539, 3);
            btnAbout.Margin = new Padding(0);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(48, 48);
            btnAbout.TabIndex = 3;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Thistle;
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 2;
            btnGenerate.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.DarkMagenta;
            btnGenerate.Location = new Point(213, 185);
            btnGenerate.Margin = new Padding(0);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(114, 45);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Thistle;
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatAppearance.BorderSize = 2;
            btnShow.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.ForeColor = Color.DarkMagenta;
            btnShow.Location = new Point(338, 185);
            btnShow.Margin = new Padding(0);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(114, 45);
            btnShow.TabIndex = 5;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.Thistle;
            btnSort.Cursor = Cursors.Hand;
            btnSort.FlatAppearance.BorderSize = 2;
            btnSort.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.ForeColor = Color.DarkMagenta;
            btnSort.Location = new Point(464, 185);
            btnSort.Margin = new Padding(0);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(114, 45);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // radioButtonVerticalBarChart
            // 
            radioButtonVerticalBarChart.AutoSize = true;
            radioButtonVerticalBarChart.Cursor = Cursors.Hand;
            radioButtonVerticalBarChart.FlatAppearance.BorderSize = 0;
            radioButtonVerticalBarChart.FlatAppearance.CheckedBackColor = Color.DarkMagenta;
            radioButtonVerticalBarChart.FlatStyle = FlatStyle.Flat;
            radioButtonVerticalBarChart.ForeColor = Color.DarkViolet;
            radioButtonVerticalBarChart.Location = new Point(0, 52);
            radioButtonVerticalBarChart.Margin = new Padding(0);
            radioButtonVerticalBarChart.Name = "radioButtonVerticalBarChart";
            radioButtonVerticalBarChart.Size = new Size(132, 23);
            radioButtonVerticalBarChart.TabIndex = 7;
            radioButtonVerticalBarChart.Text = "Vertical Bar Chart";
            radioButtonVerticalBarChart.UseVisualStyleBackColor = true;
            // 
            // radioButtonHorizontalBarChart
            // 
            radioButtonHorizontalBarChart.AutoSize = true;
            radioButtonHorizontalBarChart.Cursor = Cursors.Hand;
            radioButtonHorizontalBarChart.FlatAppearance.BorderSize = 0;
            radioButtonHorizontalBarChart.FlatAppearance.CheckedBackColor = Color.DarkMagenta;
            radioButtonHorizontalBarChart.FlatStyle = FlatStyle.Flat;
            radioButtonHorizontalBarChart.ForeColor = Color.DarkViolet;
            radioButtonHorizontalBarChart.Location = new Point(0, 80);
            radioButtonHorizontalBarChart.Margin = new Padding(0);
            radioButtonHorizontalBarChart.Name = "radioButtonHorizontalBarChart";
            radioButtonHorizontalBarChart.Size = new Size(151, 23);
            radioButtonHorizontalBarChart.TabIndex = 8;
            radioButtonHorizontalBarChart.Text = "Horizontal Bar Chart";
            radioButtonHorizontalBarChart.UseVisualStyleBackColor = true;
            // 
            // radioButtonPieChart
            // 
            radioButtonPieChart.AutoSize = true;
            radioButtonPieChart.Checked = true;
            radioButtonPieChart.Cursor = Cursors.Hand;
            radioButtonPieChart.FlatAppearance.BorderSize = 0;
            radioButtonPieChart.FlatAppearance.CheckedBackColor = Color.DarkMagenta;
            radioButtonPieChart.FlatStyle = FlatStyle.Flat;
            radioButtonPieChart.ForeColor = Color.DarkViolet;
            radioButtonPieChart.Location = new Point(0, 26);
            radioButtonPieChart.Margin = new Padding(0);
            radioButtonPieChart.Name = "radioButtonPieChart";
            radioButtonPieChart.Size = new Size(82, 23);
            radioButtonPieChart.TabIndex = 9;
            radioButtonPieChart.TabStop = true;
            radioButtonPieChart.Text = "Pie Chart";
            radioButtonPieChart.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonVerticalBarChart);
            groupBox1.Controls.Add(radioButtonPieChart);
            groupBox1.Controls.Add(radioButtonHorizontalBarChart);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(338, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(198, 117);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Charts:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 55);
            label2.Name = "label2";
            label2.Size = new Size(36, 19);
            label2.TabIndex = 12;
            label2.Text = "Min:";
            // 
            // numericUpDownMin
            // 
            numericUpDownMin.Cursor = Cursors.Hand;
            numericUpDownMin.ForeColor = Color.DarkViolet;
            numericUpDownMin.Location = new Point(265, 53);
            numericUpDownMin.Name = "numericUpDownMin";
            numericUpDownMin.Size = new Size(62, 25);
            numericUpDownMin.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(213, 98);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 14;
            label3.Text = "Max:";
            // 
            // numericUpDownMax
            // 
            numericUpDownMax.Cursor = Cursors.Hand;
            numericUpDownMax.ForeColor = Color.DarkViolet;
            numericUpDownMax.Location = new Point(265, 91);
            numericUpDownMax.Name = "numericUpDownMax";
            numericUpDownMax.Size = new Size(62, 25);
            numericUpDownMax.TabIndex = 13;
            numericUpDownMax.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(586, 239);
            Controls.Add(label3);
            Controls.Add(numericUpDownMax);
            Controls.Add(label2);
            Controls.Add(numericUpDownMin);
            Controls.Add(btnSort);
            Controls.Add(btnShow);
            Controls.Add(btnGenerate);
            Controls.Add(btnAbout);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(numericUpDownElements);
            Controls.Add(groupBox1);
            Font = new Font("Nirmala UI", 10F);
            ForeColor = Color.DarkMagenta;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Parameters";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)numericUpDownElements).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownElements;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAbout;
        private Button btnGenerate;
        private Button btnShow;
        private Button btnSort;
        private RadioButton radioButtonVerticalBarChart;
        private RadioButton radioButtonHorizontalBarChart;
        private RadioButton radioButtonPieChart;
        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numericUpDownMin;
        private Label label3;
        private NumericUpDown numericUpDownMax;
    }
}
