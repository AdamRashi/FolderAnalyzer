namespace DirectoryAnalyzer
{
    partial class FolderAnalyzator2000
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSortMethod = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.checkBoxLinqUse = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDublicates = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSortMethod
            // 
            this.btnSortMethod.BackColor = System.Drawing.Color.Gold;
            this.btnSortMethod.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSortMethod.Location = new System.Drawing.Point(43, 465);
            this.btnSortMethod.Name = "btnSortMethod";
            this.btnSortMethod.Size = new System.Drawing.Size(331, 97);
            this.btnSortMethod.TabIndex = 0;
            this.btnSortMethod.Text = "Распределение файлов по длине имени (без учёта пути к файлу)";
            this.btnSortMethod.UseVisualStyleBackColor = false;
            this.btnSortMethod.Click += new System.EventHandler(this.btnSortMethod_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.BackColor = System.Drawing.Color.Gold;
            this.btnChooseFolder.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFolder.Location = new System.Drawing.Point(73, 47);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(278, 34);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "Выбрать папку";
            this.btnChooseFolder.UseVisualStyleBackColor = false;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // checkBoxLinqUse
            // 
            this.checkBoxLinqUse.AutoSize = true;
            this.checkBoxLinqUse.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLinqUse.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxLinqUse.Location = new System.Drawing.Point(43, 108);
            this.checkBoxLinqUse.Name = "checkBoxLinqUse";
            this.checkBoxLinqUse.Size = new System.Drawing.Size(369, 33);
            this.checkBoxLinqUse.TabIndex = 2;
            this.checkBoxLinqUse.Text = "Использовать технологию LinQ?";
            this.checkBoxLinqUse.UseVisualStyleBackColor = false;
            this.checkBoxLinqUse.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(392, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбранная папка:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(43, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 105);
            this.button1.TabIndex = 4;
            this.button1.Text = "Самое часто встречающееся расширение по всем файлам";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(43, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 69);
            this.button2.TabIndex = 5;
            this.button2.Text = "N самых последних файлов (по дате создания)";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDublicates
            // 
            this.btnDublicates.BackColor = System.Drawing.Color.Gold;
            this.btnDublicates.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDublicates.Location = new System.Drawing.Point(43, 355);
            this.btnDublicates.Name = "btnDublicates";
            this.btnDublicates.Size = new System.Drawing.Size(331, 104);
            this.btnDublicates.TabIndex = 6;
            this.btnDublicates.Text = "Папки-дубликаты, у которых совпадает размер, количество и имена файлов";
            this.btnDublicates.UseVisualStyleBackColor = false;
            this.btnDublicates.Click += new System.EventHandler(this.btnDublicates_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.RoyalBlue;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(566, 583);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(823, 446);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "Время выполнения методов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(935, 393);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(380, 302);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 31);
            this.numericUpDown1.TabIndex = 9;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.RoyalBlue;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(22, 583);
            this.chart2.Name = "chart2";
            series1.BorderColor = System.Drawing.Color.Blue;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(538, 446);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(380, 209);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 31);
            this.numericUpDown2.TabIndex = 11;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // FolderAnalyzator2000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1413, 1041);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnDublicates);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxLinqUse);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.btnSortMethod);
            this.Name = "FolderAnalyzator2000";
            this.Text = "FolderAnalyzator2000";
            this.Load += new System.EventHandler(this.FolderAnalyzator2000_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSortMethod;
        private Button btnChooseFolder;
        private CheckBox checkBoxLinqUse;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button btnDublicates;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private NumericUpDown numericUpDown2;
    }
}