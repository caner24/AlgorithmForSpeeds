namespace AlgorithmForSpeeds
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbQucikSort = new System.Windows.Forms.RadioButton();
            this.rbMergeSort = new System.Windows.Forms.RadioButton();
            this.rbInsertionSort = new System.Windows.Forms.RadioButton();
            this.rbBubbleSort = new System.Windows.Forms.RadioButton();
            this.rbSelectionSort = new System.Windows.Forms.RadioButton();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnScatter = new System.Windows.Forms.Button();
            this.btnStem = new System.Windows.Forms.Button();
            this.lblExpiresTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDevam = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnScreen = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblArrayInfo = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCustomArray = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(509, 137);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(547, 334);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(12, 133);
            this.tbSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(489, 56);
            this.tbSpeed.TabIndex = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbQucikSort);
            this.panel1.Controls.Add(this.rbMergeSort);
            this.panel1.Controls.Add(this.rbInsertionSort);
            this.panel1.Controls.Add(this.rbBubbleSort);
            this.panel1.Controls.Add(this.rbSelectionSort);
            this.panel1.Location = new System.Drawing.Point(9, 292);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 178);
            this.panel1.TabIndex = 3;
            // 
            // rbQucikSort
            // 
            this.rbQucikSort.AutoSize = true;
            this.rbQucikSort.Location = new System.Drawing.Point(23, 143);
            this.rbQucikSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbQucikSort.Name = "rbQucikSort";
            this.rbQucikSort.Size = new System.Drawing.Size(89, 20);
            this.rbQucikSort.TabIndex = 9;
            this.rbQucikSort.TabStop = true;
            this.rbQucikSort.Text = "Quick Sort";
            this.rbQucikSort.UseVisualStyleBackColor = true;
            // 
            // rbMergeSort
            // 
            this.rbMergeSort.AutoSize = true;
            this.rbMergeSort.Location = new System.Drawing.Point(23, 114);
            this.rbMergeSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMergeSort.Name = "rbMergeSort";
            this.rbMergeSort.Size = new System.Drawing.Size(94, 20);
            this.rbMergeSort.TabIndex = 8;
            this.rbMergeSort.TabStop = true;
            this.rbMergeSort.Text = "Merge Sort";
            this.rbMergeSort.UseVisualStyleBackColor = true;
            // 
            // rbInsertionSort
            // 
            this.rbInsertionSort.AutoSize = true;
            this.rbInsertionSort.Location = new System.Drawing.Point(23, 82);
            this.rbInsertionSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbInsertionSort.Name = "rbInsertionSort";
            this.rbInsertionSort.Size = new System.Drawing.Size(105, 20);
            this.rbInsertionSort.TabIndex = 7;
            this.rbInsertionSort.TabStop = true;
            this.rbInsertionSort.Text = "Insertion Sort";
            this.rbInsertionSort.UseVisualStyleBackColor = true;
            // 
            // rbBubbleSort
            // 
            this.rbBubbleSort.AutoSize = true;
            this.rbBubbleSort.Location = new System.Drawing.Point(23, 50);
            this.rbBubbleSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBubbleSort.Name = "rbBubbleSort";
            this.rbBubbleSort.Size = new System.Drawing.Size(98, 20);
            this.rbBubbleSort.TabIndex = 6;
            this.rbBubbleSort.TabStop = true;
            this.rbBubbleSort.Text = "Bubble Sort";
            this.rbBubbleSort.UseVisualStyleBackColor = true;
            this.rbBubbleSort.CheckedChanged += new System.EventHandler(this.rbBubbleSort_CheckedChanged);
            // 
            // rbSelectionSort
            // 
            this.rbSelectionSort.AutoSize = true;
            this.rbSelectionSort.Location = new System.Drawing.Point(23, 18);
            this.rbSelectionSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSelectionSort.Name = "rbSelectionSort";
            this.rbSelectionSort.Size = new System.Drawing.Size(118, 20);
            this.rbSelectionSort.TabIndex = 5;
            this.rbSelectionSort.TabStop = true;
            this.rbSelectionSort.Text = "Selection Short";
            this.rbSelectionSort.UseVisualStyleBackColor = true;
            this.rbSelectionSort.CheckedChanged += new System.EventHandler(this.rbSelectionSort_CheckedChanged);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(509, 84);
            this.btnBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(100, 46);
            this.btnBar.TabIndex = 4;
            this.btnBar.Text = "Bar";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnScatter
            // 
            this.btnScatter.Location = new System.Drawing.Point(733, 84);
            this.btnScatter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScatter.Name = "btnScatter";
            this.btnScatter.Size = new System.Drawing.Size(100, 46);
            this.btnScatter.TabIndex = 5;
            this.btnScatter.Text = "Scatter";
            this.btnScatter.UseVisualStyleBackColor = true;
            this.btnScatter.Click += new System.EventHandler(this.btnScatter_Click);
            // 
            // btnStem
            // 
            this.btnStem.Location = new System.Drawing.Point(956, 84);
            this.btnStem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStem.Name = "btnStem";
            this.btnStem.Size = new System.Drawing.Size(100, 46);
            this.btnStem.TabIndex = 6;
            this.btnStem.Text = "Stem";
            this.btnStem.UseVisualStyleBackColor = true;
            this.btnStem.Click += new System.EventHandler(this.btnStem_Click);
            // 
            // lblExpiresTime
            // 
            this.lblExpiresTime.AutoSize = true;
            this.lblExpiresTime.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiresTime.Location = new System.Drawing.Point(4, 36);
            this.lblExpiresTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiresTime.Name = "lblExpiresTime";
            this.lblExpiresTime.Size = new System.Drawing.Size(158, 28);
            this.lblExpiresTime.TabIndex = 7;
            this.lblExpiresTime.Text = "Geçen Süre : ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Red;
            this.lblTime.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(183, 36);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 28);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hız Ayarı";
            // 
            // btnDevam
            // 
            this.btnDevam.Enabled = false;
            this.btnDevam.Location = new System.Drawing.Point(49, 197);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(452, 33);
            this.btnDevam.TabIndex = 11;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnScreen);
            this.panel2.Controls.Add(this.btnHide);
            this.panel2.Controls.Add(this.lblExpiresTime);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 76);
            this.panel2.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1013, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 28);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnScreen
            // 
            this.btnScreen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreen.Location = new System.Drawing.Point(956, 4);
            this.btnScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(49, 28);
            this.btnScreen.TabIndex = 11;
            this.btnScreen.Text = "[ ]";
            this.btnScreen.UseVisualStyleBackColor = true;
            // 
            // btnHide
            // 
            this.btnHide.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(899, 5);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(49, 28);
            this.btnHide.TabIndex = 10;
            this.btnHide.Text = "__";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(49, 251);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(452, 33);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Sıfrıla";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AlgorithmForSpeeds.Properties.Resources.resf;
            this.pictureBox2.Location = new System.Drawing.Point(9, 251);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AlgorithmForSpeeds.Properties.Resources.play;
            this.pictureBox1.Location = new System.Drawing.Point(9, 197);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.lblArrayInfo);
            this.panel4.Controls.Add(this.btnSend);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tbxCustomArray);
            this.panel4.Location = new System.Drawing.Point(0, 478);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 76);
            this.panel4.TabIndex = 19;
            // 
            // lblArrayInfo
            // 
            this.lblArrayInfo.AutoSize = true;
            this.lblArrayInfo.BackColor = System.Drawing.Color.Red;
            this.lblArrayInfo.Font = new System.Drawing.Font("Segoe Script", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrayInfo.Location = new System.Drawing.Point(209, 7);
            this.lblArrayInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArrayInfo.Name = "lblArrayInfo";
            this.lblArrayInfo.Size = new System.Drawing.Size(555, 28);
            this.lblArrayInfo.TabIndex = 3;
            this.lblArrayInfo.Text = "Lütfen aralarına virgül koyarak giriniz örnek : [1,2,3,4,5]";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(476, 42);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 25);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Set Array";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Array";
            // 
            // tbxCustomArray
            // 
            this.tbxCustomArray.Location = new System.Drawing.Point(232, 42);
            this.tbxCustomArray.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCustomArray.Name = "tbxCustomArray";
            this.tbxCustomArray.Size = new System.Drawing.Size(235, 22);
            this.tbxCustomArray.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnStem);
            this.Controls.Add(this.btnScatter);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnScatter;
        private System.Windows.Forms.Button btnStem;
        private System.Windows.Forms.Label lblExpiresTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnScreen;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbBubbleSort;
        private System.Windows.Forms.RadioButton rbSelectionSort;
        private System.Windows.Forms.RadioButton rbInsertionSort;
        private System.Windows.Forms.RadioButton rbQucikSort;
        private System.Windows.Forms.RadioButton rbMergeSort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCustomArray;
        private System.Windows.Forms.Label lblArrayInfo;
        private System.Windows.Forms.Timer timer1;
    }
}

