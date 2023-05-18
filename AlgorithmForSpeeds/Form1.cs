using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AlgorithmForSpeeds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pointCount = 5;
        int _speedValue = 0;
        int[] _arr;
        int arrayNumber = 0;
        string _type;

        private Random rand = new Random(0);
        Stopwatch _stopWatch = new Stopwatch();
        void sort(int[] arr)
        {
            chart1.Series.Clear();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
        private double[] RandomWalk(int points = 5, double start = 100, double mult = 50)
        {
            // return an array of difting random numbers
            double[] values = new double[points];
            values[0] = start;
            for (int i = 1; i < points; i++)
                values[i] = values[i - 1] + (rand.NextDouble() - .5) * mult;
            return values;
        }
        private void btnBar_Click(object sender, EventArgs e)
        {
            if (_arr == null)
            {
                MessageBox.Show("Algoritma Seçilmedi ", "Lütfen bir algoritma seçimi yapınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _type = "Bar";
                ChartGetir();
            }

        }
        private void ChartGetir(int numbers = 0)
        {
            btnDevam.Enabled = false;
            _stopWatch.Start();
            int n = _arr.Length;
            if (numbers == 0)
            {
                chart1.Series.Clear();
            }

            for (int i = numbers; i < n; ++i)
            {
                if (i != 0)
                    _stopWatch.Start();

                Thread.Sleep(_speedValue * 100);
                ChartYazdir(i, _arr[i]);
                _stopWatch.Stop();
                DialogResult results = MessageBox.Show("Geçen Süre : " + _stopWatch.ElapsedMilliseconds.ToString(), "Durdurmak için (yes) basın", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (results == DialogResult.Yes)
                {
                    _stopWatch.Stop();
                    btnDevam.Enabled = true;
                    btnBar.Enabled = false;
                    btnScatter.Enabled = false;
                    btnStem.Enabled = false;
                    arrayNumber = i + 1;
                    if (i == n - 1)
                    {
                        arrayNumber = 0;
                    }
                    break;
                }

                lblTime.Text = _stopWatch.ElapsedMilliseconds.ToString() + " ms ";
                chart1.Titles.Clear();
                chart1.Titles.Add($"Dizideki toplam eleman sayisi ({pointCount} )");
                chart1.ChartAreas[0].AxisX.Title = "Horizontal Axis Label";
                chart1.ChartAreas[0].AxisY.Title = "Vertical Axis Label";
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            }
        }
        private void ChartYazdir(int indis, int values)
        {
            Series series1 = new Series("Number :" + values.ToString());
            series1.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series1);
            chart1.Series["Number :" + values.ToString()].Points.AddXY(indis, values);
            Thread.Sleep(_speedValue * 100);
        }
        private void ChartYazdirScatter(int indis, int values)
        {
            Series series1 = new Series("Number :" + values.ToString());
            series1.ChartType = SeriesChartType.Line;
            series1.MarkerStyle = MarkerStyle.Circle;
            chart1.Series.Add(series1);
            chart1.Series["Number :" + values.ToString()].Points.AddXY(indis, values);
            Thread.Sleep(_speedValue * 100);
        }
        private void ChartGetirScatter(int numbers = 0)
        {
            btnDevam.Enabled = false;
            _stopWatch.Start();
            int n = _arr.Length;
            if (numbers == 0)
            {
                chart1.Series.Clear();
            }

            for (int i = numbers; i < n; ++i)
            {
                if (i != 0)
                    _stopWatch.Start();

                Thread.Sleep(_speedValue * 100);
                ChartYazdirScatter(i, _arr[i]);
                _stopWatch.Stop();
                DialogResult results = MessageBox.Show("Geçen Süre : " + _stopWatch.ElapsedMilliseconds.ToString(), "Durdurmak için (yes) basın", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (results == DialogResult.Yes)
                {
                    _stopWatch.Stop();
                    btnDevam.Enabled = true;
                    btnBar.Enabled = false;
                    btnScatter.Enabled = false;
                    btnStem.Enabled = false;
                    arrayNumber = i + 1;
                    if (i == n - 1)
                    {
                        arrayNumber = 0;
                    }
                    break;
                }

                lblTime.Text = _stopWatch.ElapsedMilliseconds.ToString() + " ms ";
                chart1.ResetAutoValues();
                chart1.Titles.Clear();
                chart1.Titles.Add($"Scatter Plot ({pointCount:N0} points per series)");
                chart1.ChartAreas[0].AxisX.Title = "Horizontal Axis Label";
                chart1.ChartAreas[0].AxisY.Title = "Vertical Axis Label";
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            }
        }
        private void btnScatter_Click(object sender, EventArgs e)
        {
            if (_arr == null)
            {
                MessageBox.Show("Algoritma Seçilmedi ", "Lütfen bir algoritma seçimi yapınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _type = "Scatter";
                ChartGetirScatter();
            }
        }

        private void btnStem_Click(object sender, EventArgs e)
        {
            // generate some random Y data
            int pointCount = 100_000;
            double[] ys1 = RandomWalk(pointCount);
            double[] ys2 = RandomWalk(pointCount);

            // create a series for each line
            Series series1 = new Series("Group A");
            series1.Points.DataBindY(ys1);
            series1.ChartType = SeriesChartType.FastLine;

            Series series2 = new Series("Group B");
            series2.Points.DataBindY(ys2);
            series2.ChartType = SeriesChartType.FastLine;

            chart1.Series.Clear();
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.ResetAutoValues();
            chart1.Titles.Clear();
            chart1.Titles.Add($"Fast Line Plot ({pointCount:N0} points per series)");
            chart1.ChartAreas[0].AxisX.Title = "Horizontal Axis Label";
            chart1.ChartAreas[0].AxisY.Title = "Vertical Axis Label";
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
        }

        void SelectionShort()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            sort(arr);
            _arr = arr;
        }
        void BubbleSort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            _arr = arr;
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            _speedValue = tbSpeed.Value;
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (_type == "Scatter")
            {
                ChartGetirScatter(arrayNumber);
            }
            if (_type == "Bar")
                ChartGetir(arrayNumber);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _stopWatch.Reset();
            btnBar.Enabled = true;
            btnScatter.Enabled = true;
            btnStem.Enabled = true;
            chart1.Series.Clear();
            chart1.Titles.Clear();

        }

        private void rbSelectionSort_CheckedChanged(object sender, EventArgs e)
        {
            SelectionShort();
        }

        private void rbBubbleSort_CheckedChanged(object sender, EventArgs e)
        {
            BubbleSort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblArrayInfo.Text = lblArrayInfo.Text.Substring(1) + lblArrayInfo.Text.Substring(0, 1);
        }
    }
}
