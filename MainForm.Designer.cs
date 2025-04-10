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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnAbout = new Button();
            btnGenerate = new Button();
            btnShow = new Button();
            btnSort = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.ForeColor = Color.DarkViolet;
            numericUpDown1.Location = new Point(219, 17);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(62, 30);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(201, 23);
            label1.TabIndex = 1;
            label1.Text = "The number of elements:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(269, 188);
            dataGridView1.TabIndex = 2;
            // 
            // btnAbout
            // 
            btnAbout.BackgroundImage = (Image)resources.GetObject("btnAbout.BackgroundImage");
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.MouseOverBackColor = Color.Thistle;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Location = new Point(368, 6);
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
            btnGenerate.FlatAppearance.BorderSize = 2;
            btnGenerate.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.DarkViolet;
            btnGenerate.Location = new Point(302, 69);
            btnGenerate.Margin = new Padding(0);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(114, 45);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Thistle;
            btnShow.FlatAppearance.BorderSize = 2;
            btnShow.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.ForeColor = Color.DarkViolet;
            btnShow.Location = new Point(302, 212);
            btnShow.Margin = new Padding(0);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(114, 45);
            btnShow.TabIndex = 5;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.Thistle;
            btnSort.FlatAppearance.BorderSize = 2;
            btnSort.FlatAppearance.MouseOverBackColor = Color.Plum;
            btnSort.FlatStyle = FlatStyle.Flat;
            btnSort.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSort.ForeColor = Color.DarkViolet;
            btnSort.Location = new Point(302, 138);
            btnSort.Margin = new Padding(0);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(114, 45);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(425, 269);
            Controls.Add(btnSort);
            Controls.Add(btnShow);
            Controls.Add(btnGenerate);
            Controls.Add(btnAbout);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Font = new Font("Nirmala UI", 10F);
            ForeColor = Color.DarkMagenta;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Parameters";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnAbout;
        private Button btnGenerate;
        private Button btnShow;
        private Button btnSort;
    }
}
