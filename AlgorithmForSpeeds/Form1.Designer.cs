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
            this.lblKarsilastirma = new System.Windows.Forms.Label();
            this.lblKarsilastirmaSayisi = new System.Windows.Forms.Label();
            this.lblArrayInfo = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCustomArray = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBest = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblWorst = new System.Windows.Forms.Label();
            this.lblWorst2 = new System.Windows.Forms.Label();
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
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(387, 189);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(410, 271);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(8, 189);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(367, 45);
            this.tbSpeed.TabIndex = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rbQucikSort);
            this.panel1.Controls.Add(this.rbMergeSort);
            this.panel1.Controls.Add(this.rbInsertionSort);
            this.panel1.Controls.Add(this.rbBubbleSort);
            this.panel1.Controls.Add(this.rbSelectionSort);
            this.panel1.Location = new System.Drawing.Point(7, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 145);
            this.panel1.TabIndex = 3;
            // 
            // rbQucikSort
            // 
            this.rbQucikSort.AutoSize = true;
            this.rbQucikSort.Location = new System.Drawing.Point(17, 116);
            this.rbQucikSort.Name = "rbQucikSort";
            this.rbQucikSort.Size = new System.Drawing.Size(75, 17);
            this.rbQucikSort.TabIndex = 9;
            this.rbQucikSort.TabStop = true;
            this.rbQucikSort.Text = "Quick Sort";
            this.rbQucikSort.UseVisualStyleBackColor = true;
            this.rbQucikSort.CheckedChanged += new System.EventHandler(this.rbQucikSort_CheckedChanged);
            // 
            // rbMergeSort
            // 
            this.rbMergeSort.AutoSize = true;
            this.rbMergeSort.Location = new System.Drawing.Point(17, 93);
            this.rbMergeSort.Name = "rbMergeSort";
            this.rbMergeSort.Size = new System.Drawing.Size(77, 17);
            this.rbMergeSort.TabIndex = 8;
            this.rbMergeSort.TabStop = true;
            this.rbMergeSort.Text = "Merge Sort";
            this.rbMergeSort.UseVisualStyleBackColor = true;
            this.rbMergeSort.CheckedChanged += new System.EventHandler(this.rbMergeSort_CheckedChanged);
            // 
            // rbInsertionSort
            // 
            this.rbInsertionSort.AutoSize = true;
            this.rbInsertionSort.Location = new System.Drawing.Point(17, 67);
            this.rbInsertionSort.Name = "rbInsertionSort";
            this.rbInsertionSort.Size = new System.Drawing.Size(87, 17);
            this.rbInsertionSort.TabIndex = 7;
            this.rbInsertionSort.TabStop = true;
            this.rbInsertionSort.Text = "Insertion Sort";
            this.rbInsertionSort.UseVisualStyleBackColor = true;
            this.rbInsertionSort.CheckedChanged += new System.EventHandler(this.rbInsertionSort_CheckedChanged);
            // 
            // rbBubbleSort
            // 
            this.rbBubbleSort.AutoSize = true;
            this.rbBubbleSort.Location = new System.Drawing.Point(17, 41);
            this.rbBubbleSort.Name = "rbBubbleSort";
            this.rbBubbleSort.Size = new System.Drawing.Size(80, 17);
            this.rbBubbleSort.TabIndex = 6;
            this.rbBubbleSort.TabStop = true;
            this.rbBubbleSort.Text = "Bubble Sort";
            this.rbBubbleSort.UseVisualStyleBackColor = true;
            this.rbBubbleSort.CheckedChanged += new System.EventHandler(this.rbBubbleSort_CheckedChanged);
            // 
            // rbSelectionSort
            // 
            this.rbSelectionSort.AutoSize = true;
            this.rbSelectionSort.Location = new System.Drawing.Point(17, 15);
            this.rbSelectionSort.Name = "rbSelectionSort";
            this.rbSelectionSort.Size = new System.Drawing.Size(97, 17);
            this.rbSelectionSort.TabIndex = 5;
            this.rbSelectionSort.TabStop = true;
            this.rbSelectionSort.Text = "Selection Short";
            this.rbSelectionSort.UseVisualStyleBackColor = true;
            this.rbSelectionSort.CheckedChanged += new System.EventHandler(this.rbSelectionSort_CheckedChanged);
            // 
            // btnBar
            // 
            this.btnBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBar.Location = new System.Drawing.Point(425, 146);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(75, 37);
            this.btnBar.TabIndex = 4;
            this.btnBar.Text = "Bar";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnScatter
            // 
            this.btnScatter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScatter.Location = new System.Drawing.Point(567, 146);
            this.btnScatter.Name = "btnScatter";
            this.btnScatter.Size = new System.Drawing.Size(75, 37);
            this.btnScatter.TabIndex = 5;
            this.btnScatter.Text = "Scatter";
            this.btnScatter.UseVisualStyleBackColor = true;
            this.btnScatter.Click += new System.EventHandler(this.btnScatter_Click);
            // 
            // btnStem
            // 
            this.btnStem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStem.Location = new System.Drawing.Point(713, 146);
            this.btnStem.Name = "btnStem";
            this.btnStem.Size = new System.Drawing.Size(75, 37);
            this.btnStem.TabIndex = 6;
            this.btnStem.Text = "Stem";
            this.btnStem.UseVisualStyleBackColor = true;
            this.btnStem.Click += new System.EventHandler(this.btnStem_Click);
            // 
            // lblExpiresTime
            // 
            this.lblExpiresTime.AutoSize = true;
            this.lblExpiresTime.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiresTime.Location = new System.Drawing.Point(6, 4);
            this.lblExpiresTime.Name = "lblExpiresTime";
            this.lblExpiresTime.Size = new System.Drawing.Size(128, 23);
            this.lblExpiresTime.TabIndex = 7;
            this.lblExpiresTime.Text = "Geçen Süre : ";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Red;
            this.lblTime.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(140, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(32, 23);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hız Ayarı";
            // 
            // btnDevam
            // 
            this.btnDevam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDevam.Enabled = false;
            this.btnDevam.Location = new System.Drawing.Point(36, 241);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(339, 27);
            this.btnDevam.TabIndex = 11;
            this.btnDevam.Text = "Devam Et";
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.lblWorst);
            this.panel2.Controls.Add(this.lblWorst2);
            this.panel2.Controls.Add(this.lblAverage);
            this.panel2.Controls.Add(this.lblBest);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnScreen);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnHide);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblExpiresTime);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 126);
            this.panel2.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(760, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnScreen
            // 
            this.btnScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScreen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreen.Location = new System.Drawing.Point(721, 4);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(37, 23);
            this.btnScreen.TabIndex = 11;
            this.btnScreen.Text = "[ ]";
            this.btnScreen.UseVisualStyleBackColor = true;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Location = new System.Drawing.Point(678, 3);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(37, 23);
            this.btnHide.TabIndex = 10;
            this.btnHide.Text = "__";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClear.Location = new System.Drawing.Point(36, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(339, 27);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Sıfrıla";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.Image = global::AlgorithmForSpeeds.Properties.Resources.resf;
            this.pictureBox2.Location = new System.Drawing.Point(7, 285);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::AlgorithmForSpeeds.Properties.Resources.play;
            this.pictureBox1.Location = new System.Drawing.Point(7, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.lblKarsilastirma);
            this.panel4.Controls.Add(this.lblKarsilastirmaSayisi);
            this.panel4.Controls.Add(this.lblArrayInfo);
            this.panel4.Controls.Add(this.btnSend);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.tbxCustomArray);
            this.panel4.Location = new System.Drawing.Point(0, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 126);
            this.panel4.TabIndex = 19;
            // 
            // lblKarsilastirma
            // 
            this.lblKarsilastirma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKarsilastirma.AutoSize = true;
            this.lblKarsilastirma.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarsilastirma.Location = new System.Drawing.Point(542, 91);
            this.lblKarsilastirma.Name = "lblKarsilastirma";
            this.lblKarsilastirma.Size = new System.Drawing.Size(202, 23);
            this.lblKarsilastirma.TabIndex = 13;
            this.lblKarsilastirma.Text = "Karsilastirma Sayisi : ";
            // 
            // lblKarsilastirmaSayisi
            // 
            this.lblKarsilastirmaSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKarsilastirmaSayisi.AutoSize = true;
            this.lblKarsilastirmaSayisi.BackColor = System.Drawing.Color.Red;
            this.lblKarsilastirmaSayisi.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarsilastirmaSayisi.Location = new System.Drawing.Point(756, 91);
            this.lblKarsilastirmaSayisi.Name = "lblKarsilastirmaSayisi";
            this.lblKarsilastirmaSayisi.Size = new System.Drawing.Size(32, 23);
            this.lblKarsilastirmaSayisi.TabIndex = 14;
            this.lblKarsilastirmaSayisi.Text = "00";
            // 
            // lblArrayInfo
            // 
            this.lblArrayInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArrayInfo.BackColor = System.Drawing.Color.Red;
            this.lblArrayInfo.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrayInfo.Location = new System.Drawing.Point(74, 9);
            this.lblArrayInfo.Name = "lblArrayInfo";
            this.lblArrayInfo.Size = new System.Drawing.Size(655, 33);
            this.lblArrayInfo.TabIndex = 3;
            this.lblArrayInfo.Text = "Lütfen aralarına virgül koyarak giriniz örnek : [1,2,3,4,5]";
            this.lblArrayInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Location = new System.Drawing.Point(357, 94);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 20);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Set Array";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Array";
            // 
            // tbxCustomArray
            // 
            this.tbxCustomArray.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxCustomArray.Location = new System.Drawing.Point(174, 94);
            this.tbxCustomArray.Name = "tbxCustomArray";
            this.tbxCustomArray.Size = new System.Drawing.Size(177, 20);
            this.tbxCustomArray.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Time Complexity";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Space Complexity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = " Best : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Average : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Worst : ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(675, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Worst : ";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.BackColor = System.Drawing.Color.Red;
            this.lblBest.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBest.Location = new System.Drawing.Point(83, 61);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(14, 15);
            this.lblBest.TabIndex = 6;
            this.lblBest.Text = "0";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.BackColor = System.Drawing.Color.Red;
            this.lblAverage.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(83, 84);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(14, 15);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "0";
            // 
            // lblWorst
            // 
            this.lblWorst.AutoSize = true;
            this.lblWorst.BackColor = System.Drawing.Color.Red;
            this.lblWorst.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorst.Location = new System.Drawing.Point(83, 109);
            this.lblWorst.Name = "lblWorst";
            this.lblWorst.Size = new System.Drawing.Size(14, 15);
            this.lblWorst.TabIndex = 8;
            this.lblWorst.Text = "0";
            // 
            // lblWorst2
            // 
            this.lblWorst2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorst2.AutoSize = true;
            this.lblWorst2.BackColor = System.Drawing.Color.Red;
            this.lblWorst2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorst2.Location = new System.Drawing.Point(744, 61);
            this.lblWorst2.Name = "lblWorst2";
            this.lblWorst2.Size = new System.Drawing.Size(14, 15);
            this.lblWorst2.TabIndex = 9;
            this.lblWorst2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
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
        private System.Windows.Forms.Label lblKarsilastirma;
        private System.Windows.Forms.Label lblKarsilastirmaSayisi;
        private System.Windows.Forms.Label lblWorst;
        private System.Windows.Forms.Label lblWorst2;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

