using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DirectoryAnalyzer
{
    public partial class FolderAnalyzator2000 : Form
    {
        public string selectedPath;


        LinqSolver linqSolver = new LinqSolver();
        NoLinqSolver noLinqSolver = new NoLinqSolver();

        public FolderAnalyzator2000()
        {
            InitializeComponent();
            selectedPath = Directory.GetCurrentDirectory();
            
            label1.Text = "Выбранная папка: " + selectedPath;

            DrawStatistics();
            numericUpDown1.Maximum = Directory
                .GetFiles(selectedPath, "*", SearchOption.TopDirectoryOnly)
                .Length;


            numericUpDown1.Minimum = 0;
            numericUpDown1.Value = numericUpDown1.Maximum;

            var extensions = Directory.GetFiles(selectedPath)
                              .Select(file => Path.GetExtension(file))
                              .GroupBy(ext => ext)
                              .OrderByDescending(group => group.Count())
                              .ToDictionary(g => g.Key, g => g.Count());


            numericUpDown2.Maximum = extensions.Count;

            numericUpDown2.Minimum = 0;
            numericUpDown2.Value = numericUpDown2.Maximum;

            DrawPieChart(numericUpDown2.Value);
        }


        private void DrawStatistics()
        {
            chart1.Series.Clear();
            
            Dictionary<string, double> data = new Dictionary<string, double>();
            
            string[] methodNames = { "GetNRecentFiles",
                                "FindMostFrequentExtension",
                                    "GetDuplicateFolders",
                                    "SortFilesByName"};

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            linqSolver.GetType().GetMethod(methodNames[0]).Invoke(linqSolver, new object[] { selectedPath, 10 });
            stopwatch.Stop();
            double linqTimes = stopwatch.ElapsedMilliseconds;

            stopwatch.Reset();
            stopwatch.Start();
            noLinqSolver.GetType().GetMethod(methodNames[0]).Invoke(noLinqSolver, new object[] { selectedPath, 10 });
            stopwatch.Stop();
            double noLinqTimes = stopwatch.ElapsedMilliseconds;


            data.Add(methodNames[0] + " (LINQ)", linqTimes);
            data.Add(methodNames[0] + " (no LINQ)", noLinqTimes);

            
            for (int i = 1; i < methodNames.Length; i++)
            {
                stopwatch.Reset();

                stopwatch.Start();
                linqSolver.GetType().GetMethod(methodNames[i]).Invoke(linqSolver, new object[] { selectedPath });
                stopwatch.Stop();
                linqTimes = stopwatch.ElapsedMilliseconds;

                stopwatch.Reset();
                stopwatch.Start();
                noLinqSolver.GetType().GetMethod(methodNames[i]).Invoke(noLinqSolver, new object[] { selectedPath });
                stopwatch.Stop();
                noLinqTimes = stopwatch.ElapsedMilliseconds;


                data.Add(methodNames[i] + " (LINQ)", linqTimes);
                data.Add(methodNames[i] + " (no LINQ)", noLinqTimes);

            }


            Series linqSeries = new Series("LINQ");
            Series noLinqSeries = new Series("NO LINQ");

            linqSeries.Color = Color.Red;
            noLinqSeries.Color = Color.Orange;
            linqSeries.Points.AddXY(0, data[methodNames[0] + " (LINQ)"]);
            noLinqSeries.Points.AddXY(0, data[methodNames[0] + " (no LINQ)"]);
            linqSeries.AxisLabel = methodNames[0];
            noLinqSeries.AxisLabel = methodNames[0];

            chart1.Series.Add(linqSeries);
            chart1.Series.Add(noLinqSeries);

           
            for (int i = 1; i < methodNames.Length; i++)
            {
                linqSeries = new Series();
                noLinqSeries = new Series();
                linqSeries.IsVisibleInLegend = false;
                noLinqSeries.IsVisibleInLegend = false;
                linqSeries.Color = Color.Red;
                noLinqSeries.Color = Color.Orange;
                linqSeries.Points.AddXY(i, data[methodNames[i] + " (LINQ)"]);
                noLinqSeries.Points.AddXY(i, data[methodNames[i] + " (no LINQ)"]);
                linqSeries.AxisLabel = methodNames[i];
                noLinqSeries.AxisLabel = methodNames[i];

                chart1.Series.Add(linqSeries);
                chart1.Series.Add(noLinqSeries);
            }

        }


        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = dialog.SelectedPath;
                label1.Text = "Выбранная папка: " + selectedPath;
                //DrawStatistics();
                //замеры времени для других папок
                numericUpDown1.Maximum = Directory
                .GetFiles(selectedPath, "*", SearchOption.TopDirectoryOnly)
                .Length;

                numericUpDown1.Minimum = 0;
                numericUpDown1.Value = numericUpDown1.Maximum;

                var extensions = Directory.GetFiles(selectedPath)
                              .Select(file => Path.GetExtension(file))
                              .GroupBy(ext => ext)
                              .OrderByDescending(group => group.Count())
                              .ToDictionary(g => g.Key, g => g.Count());


                numericUpDown2.Maximum = extensions.Count;

                numericUpDown2.Minimum = 0;
                numericUpDown2.Value = numericUpDown2.Maximum;

                DrawPieChart(numericUpDown2.Value);
                Refresh();
            }
        }


        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            DrawPieChart(numericUpDown2.Value);
        }

        private void DrawPieChart(decimal n)
        {
            var extensions = Directory.GetFiles(selectedPath)
                              .Select(file => Path.GetExtension(file))
                              .GroupBy(ext => ext)
                              .OrderByDescending(group => group.Count())
                              .Take((int)n)
                              .ToDictionary(g => g.Key, g => g.Count());


            var series = new Series("Sector Volume");
            series.ChartType = SeriesChartType.Pie;
            series.Color = Color.RoyalBlue;

            foreach (var kvp in extensions)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            chart2.Series.Clear();
            chart2.Series.Add(series);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if (checkBoxLinqUse.Checked)
            {
                dataGridView1.Columns.Add("Номер", "Расширение");

                dataGridView1.Rows.Add(linqSolver.FindMostFrequentExtension(selectedPath));

            }
            else
            {
                dataGridView1.Columns.Add("Номер", "Расширение");

                dataGridView1.Rows.Add(noLinqSolver.FindMostFrequentExtension(selectedPath));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
            if (checkBoxLinqUse.Checked)
            {
                dataGridView1.Columns.Add("Номер", "Файл");

                string[] res = linqSolver.GetNRecentFiles(selectedPath, (int)numericUpDown1.Value);
                // Add some rows to the DataGridView control
                foreach (string row in res)
                {
                    dataGridView1.Rows.Add(row);
                }
            }
            else
            {
                dataGridView1.Columns.Add("Номер", "Файл");
                string[] res = noLinqSolver.GetNRecentFiles(selectedPath, (int)numericUpDown1.Value);

                foreach (string row in res)
                {
                    dataGridView1.Rows.Add(row);
                }


            }
        }

        private void btnDublicates_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (checkBoxLinqUse.Checked)
            {
                dataGridView1.Columns.Add("Номер", "Папки-дубликаты");

                List<List<string>> res = linqSolver.GetDuplicateFolders(selectedPath);

                foreach (List<string> row in res)
                {
                    dataGridView1.Rows.Add(string.Join("-------", row));
                }
            }
            else
            {
                dataGridView1.Columns.Add("Номер", "Файл");
                List<List<string>> res = noLinqSolver.GetDuplicateFolders(selectedPath);

                foreach (List<string> row in res)
                {
                    dataGridView1.Rows.Add(string.Join("-------", row));
                }


            }
        }

        private void btnSortMethod_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (checkBoxLinqUse.Checked)
            {
                dataGridView1.Columns.Add("Номер", "Файл");

                foreach (string row in linqSolver.SortFilesByName(selectedPath))
                {
                    dataGridView1.Rows.Add(row);
                }
            }
            else
            {
                dataGridView1.Columns.Add("Номер", "Файл");

                foreach (string row in noLinqSolver.SortFilesByName(selectedPath))
                {
                    dataGridView1.Rows.Add(row);
                }


            }
        }



        

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void FolderAnalyzator2000_Load(object sender, EventArgs e)
        {

        }
    }
}