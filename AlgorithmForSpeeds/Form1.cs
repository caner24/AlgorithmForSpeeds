using System;
using System.Collections;
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
        int[] arr;
        int arrayNumber = 0;
        string _type;
        int karsilastirmaSayisi;
        ArrayList _stemArr = new ArrayList();

        private Random rand = new Random(0);
        Stopwatch _stopWatch = new Stopwatch();
        Stopwatch _algorithmSpeed = new Stopwatch();
        void sort(int[] arr)
        {
            _algorithmSpeed.Start();
            chart1.Series.Clear();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                        karsilastirmaSayisi++;
                    }

                Console.WriteLine(_algorithmSpeed.Elapsed.ToString());
                lblTime.Text = _algorithmSpeed.Elapsed.ToString();
                lblKarsilastirmaSayisi.Text = karsilastirmaSayisi.ToString();
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
        void InsertionSort()
        {
            if (_arr == null || _arr.Length == 0)
            {
                arr = new int[] { 64, 25, 12, 22, 11, 8 };
            }
            else
            {
                arr = _arr;
            }
            _algorithmSpeed.Start();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        karsilastirmaSayisi++;
                    }
                    Console.WriteLine(_algorithmSpeed.Elapsed.ToString());
                    lblTime.Text = _algorithmSpeed.Elapsed.ToString();
                }
            }
            _arr = arr;
            lblKarsilastirmaSayisi.Text = karsilastirmaSayisi.ToString();
        }

        void merge(int[] arr, int l, int m, int r)
        {

            int n1 = m - l + 1;
            int n2 = r - m;


            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];


            i = 0;
            j = 0;


            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                    karsilastirmaSayisi++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                    karsilastirmaSayisi++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        void mergeSort(int[] arr, int l, int r)
        {
            _algorithmSpeed.Start();
            if (l < r)
            {
                int m = l + (r - l) / 2;
                mergeSort(arr, l, m);
                mergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
            _arr = arr;
            Console.WriteLine(_algorithmSpeed.Elapsed.ToString());
            lblTime.Text = _algorithmSpeed.Elapsed.ToString();
            lblKarsilastirmaSayisi.Text = karsilastirmaSayisi.ToString();
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
                ChartGetirBar();
            }

        }
        private void ChartGetirBar(int numbers = 0)
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
                DialogResult results = MessageBox.Show("Geçen Süre : " + _stopWatch.Elapsed.ToString(), "Durdurmak için (yes) basın", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

                lblTime.Text = _algorithmSpeed.Elapsed.ToString();
                chart1.Titles.Clear();
                chart1.Titles.Add($"Column Chart ({pointCount} points per series)");
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
        private void ChartYazdirStem(int values)
        {
            if (_stemArr.Count == 2)
            {
                _stemArr.Clear();
            }
            _stemArr.Add(values);
            Series series1 = new Series("Number :" + values.ToString());
            series1.Points.DataBindY(_stemArr);
            series1.ChartType = SeriesChartType.FastLine;
            chart1.Series.Add(series1);
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
                DialogResult results = MessageBox.Show("Geçen Süre : " + _stopWatch.Elapsed.ToString(), "Durdurmak için (yes) basın", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
                chart1.Titles.Add($"Fast Line Plot ({pointCount:N0} points per series)");
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
            if (_arr == null)
            {
                MessageBox.Show("Algoritma Seçilmedi ", "Lütfen bir algoritma seçimi yapınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _type = "Stem";
                ChartGetirStem();
            }

        }

        private void ChartGetirStem(int numbers = 0)
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
                ChartYazdirStem(_arr[i]);
                _stopWatch.Stop();
                DialogResult results = MessageBox.Show("Geçen Süre : " + _stopWatch.Elapsed.ToString(), "Durdurmak için (yes) basın", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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

                lblTime.Text = _stopWatch.Elapsed.ToString() + " ms ";
                chart1.ResetAutoValues();
                chart1.Titles.Clear();
                chart1.Titles.Add($"Fast Line Plot ({pointCount:N0} points per series)");
                chart1.ChartAreas[0].AxisX.Title = "Horizontal Axis Label";
                chart1.ChartAreas[0].AxisY.Title = "Vertical Axis Label";
                chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            }

        }

        void SelectionShort()
        {

            if (_arr == null || _arr.Length == 0)
            {
                arr = new int[] { 64, 25, 12, 22, 11, 8 };
            }
            else
            {
                arr = _arr;
            }
            sort(arr);
            _arr = arr;
        }
        void BubbleSort()
        {
            _algorithmSpeed.Start();

            if (_arr == null || _arr.Length == 0)
            {
                arr = new int[] { 64, 25, 12, 22, 11, 8 };
            }
            else
            {
                arr = _arr;
            }
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        karsilastirmaSayisi++;
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                    Console.WriteLine(_algorithmSpeed.Elapsed.ToString());
                }
            }
            _arr = arr;
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
            lblKarsilastirmaSayisi.Text = karsilastirmaSayisi.ToString();
        }
        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            _speedValue = tbSpeed.Value;
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            if (_type == "Scatter")
                ChartGetirScatter(arrayNumber);
            if (_type == "Bar")
                ChartGetirBar(arrayNumber);
            if (_type == "Stem")
                ChartGetirStem(arrayNumber);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSpeed.Value = 0;
            _stopWatch.Reset();
            _arr = new int[] { 64, 25, 12, 22, 11, 8 };
            lblKarsilastirmaSayisi.Text = "0";
            karsilastirmaSayisi = 0;
            rbSelectionSort.Checked = false;
            rbBubbleSort.Checked = false;
            rbMergeSort.Checked = false;
            rbQucikSort.Checked = false;
            rbInsertionSort.Checked = false;
            btnBar.Enabled = true;
            btnScatter.Enabled = true;
            btnStem.Enabled = true;
            chart1.Series.Clear();
            chart1.Titles.Clear();

            tbSpeed.Value = 0;
            _stopWatch.Reset();
            _arr = new int[] { 64, 25, 12, 22, 11, 8 };
            lblKarsilastirmaSayisi.Text = "0";
            karsilastirmaSayisi = 0;
            rbSelectionSort.Checked = false;
            rbBubbleSort.Checked = false;
            rbMergeSort.Checked = false;
            rbQucikSort.Checked = false;
            rbInsertionSort.Checked = false;
            btnBar.Enabled = true;
            btnScatter.Enabled = true;
            btnStem.Enabled = true;
            chart1.Series.Clear();
            chart1.Titles.Clear();

        }

        private void rbSelectionSort_CheckedChanged(object sender, EventArgs e)
        {
            lblBest.Text = "Ω(n^2)";
            lblAverage.Text = "θ(n^2)";
            lblWorst.Text = "O(n^2)";
            lblWorst2.Text = "O(1)";
            karsilastirmaSayisi = 0;
            _algorithmSpeed.Reset();
            SelectionShort();
        }

        private void rbBubbleSort_CheckedChanged(object sender, EventArgs e)
        {
            lblBest.Text = "Ω(n)";
            lblAverage.Text = "θ(n^2)";
            lblWorst.Text = "O(n^2)";
            lblWorst2.Text = "O(1)";
            karsilastirmaSayisi = 0;
            _algorithmSpeed.Reset();
            BubbleSort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblArrayInfo.Text = lblArrayInfo.Text.Substring(1) + lblArrayInfo.Text.Substring(0, 1);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            List<int> demoArr = new List<int>();
            string myArrays = tbxCustomArray.Text;
            int indis = 0;
            do
            {

                indis = myArrays.IndexOf(",");
                if (indis==-1)
                {
                    break;
                }
                string gelenSayi = myArrays.Substring(0, indis + 1);
                gelenSayi = gelenSayi.Replace(",", "");
                demoArr.Add(Convert.ToInt32(gelenSayi));
                myArrays = myArrays.Substring(indis + 1);
            } while (indis != -1);
            demoArr.Add(Convert.ToInt32(myArrays));
            int[] fakeArr = new int[demoArr.Count];
            for (int i = 0; i < fakeArr.Length; i++)
            {
                fakeArr[i] = demoArr[i];
            }
            _arr = fakeArr;
        }
        private void rbInsertionSort_CheckedChanged(object sender, EventArgs e)
        {
            lblBest.Text = "Ω(n)";
            lblAverage.Text = "θ(n^2)";
            lblWorst.Text = "O(n^2)";
            lblWorst2.Text = "O(1)";
            karsilastirmaSayisi = 0;
            _algorithmSpeed.Reset();
            InsertionSort();
        }

        private void rbMergeSort_CheckedChanged(object sender, EventArgs e)
        {
            lblBest.Text = "Ω(n log(n))";
            lblAverage.Text = "Ω(n log(n))";
            lblWorst.Text = "Ω(n log(n))";
            lblWorst2.Text = "O(n)";
            karsilastirmaSayisi = 0;
            _algorithmSpeed.Reset();
            if (_arr == null)
            {
                arr = new int[] { 64, 25, 12, 22, 11, 8 };
            }
            else
            {
                arr = _arr;

            }
            mergeSort(arr, 0, arr.Length - 1);
        }


        void Quick_Sort(int[] arr, int left, int right)
        {
            _algorithmSpeed.Start();
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                    karsilastirmaSayisi++;
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                    karsilastirmaSayisi++;
                }
            }
            _arr = arr;
            Console.WriteLine(_algorithmSpeed.Elapsed.ToString());
            lblTime.Text = _algorithmSpeed.Elapsed.ToString();
            lblKarsilastirmaSayisi.Text = karsilastirmaSayisi.ToString();

        }

        int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        private void rbQucikSort_CheckedChanged(object sender, EventArgs e)
        {
            lblBest.Text = "Ω(n log(n))";
            lblAverage.Text = "Ω(n log(n))";
            lblWorst.Text = "O(n^2)";
            lblWorst2.Text = "O(n)";
            karsilastirmaSayisi = 0;
            _algorithmSpeed.Reset();
            if (_arr == null)
            {
                arr = new int[] { 64, 25, 12, 22, 11, 8 };
            }
            else
            {
                arr = _arr;

            }
            Quick_Sort(arr, 0, arr.Length - 1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
