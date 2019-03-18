namespace TSP_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.S0TextBox = new System.Windows.Forms.TextBox();
            this.S1TextBox = new System.Windows.Forms.TextBox();
            this.S2TextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.S0S0TextBox = new System.Windows.Forms.TextBox();
            this.S0S1TextBox = new System.Windows.Forms.TextBox();
            this.S0S2TextBox = new System.Windows.Forms.TextBox();
            this.S1S0TextBox = new System.Windows.Forms.TextBox();
            this.S1S1TextBox = new System.Windows.Forms.TextBox();
            this.S1S2TextBox = new System.Windows.Forms.TextBox();
            this.S2S0TextBox = new System.Windows.Forms.TextBox();
            this.S2S1TextBox = new System.Windows.Forms.TextBox();
            this.S2S2TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NumberOfExperimentsTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MeanShotsTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "S0 (цель не повреждена): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "S1 (цель повреждена): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "S1 (цель уничтожена): ";
            // 
            // S0TextBox
            // 
            this.S0TextBox.Location = new System.Drawing.Point(157, 6);
            this.S0TextBox.Name = "S0TextBox";
            this.S0TextBox.Size = new System.Drawing.Size(100, 20);
            this.S0TextBox.TabIndex = 3;
            this.S0TextBox.Text = "0,6";
            // 
            // S1TextBox
            // 
            this.S1TextBox.Location = new System.Drawing.Point(157, 32);
            this.S1TextBox.Name = "S1TextBox";
            this.S1TextBox.Size = new System.Drawing.Size(100, 20);
            this.S1TextBox.TabIndex = 4;
            this.S1TextBox.Text = "0,2";
            // 
            // S2TextBox
            // 
            this.S2TextBox.Location = new System.Drawing.Point(157, 58);
            this.S2TextBox.Name = "S2TextBox";
            this.S2TextBox.Size = new System.Drawing.Size(100, 20);
            this.S2TextBox.TabIndex = 5;
            this.S2TextBox.Text = "0,2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(263, 6);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(404, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(7, 252);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(245, 54);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Симуляция";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Матрица состояний (столбец - из, строка - в): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "S0: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "S1: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "S2: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "S0: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "S1: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(135, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "S2: ";
            // 
            // S0S0TextBox
            // 
            this.S0S0TextBox.Location = new System.Drawing.Point(44, 120);
            this.S0S0TextBox.Name = "S0S0TextBox";
            this.S0S0TextBox.Size = new System.Drawing.Size(34, 20);
            this.S0S0TextBox.TabIndex = 15;
            this.S0S0TextBox.Text = "0,4";
            // 
            // S0S1TextBox
            // 
            this.S0S1TextBox.Location = new System.Drawing.Point(85, 120);
            this.S0S1TextBox.Name = "S0S1TextBox";
            this.S0S1TextBox.Size = new System.Drawing.Size(34, 20);
            this.S0S1TextBox.TabIndex = 16;
            this.S0S1TextBox.Text = "0,4";
            // 
            // S0S2TextBox
            // 
            this.S0S2TextBox.Location = new System.Drawing.Point(125, 120);
            this.S0S2TextBox.Name = "S0S2TextBox";
            this.S0S2TextBox.Size = new System.Drawing.Size(34, 20);
            this.S0S2TextBox.TabIndex = 17;
            this.S0S2TextBox.Text = "0,2";
            // 
            // S1S0TextBox
            // 
            this.S1S0TextBox.Location = new System.Drawing.Point(44, 146);
            this.S1S0TextBox.Name = "S1S0TextBox";
            this.S1S0TextBox.Size = new System.Drawing.Size(34, 20);
            this.S1S0TextBox.TabIndex = 18;
            this.S1S0TextBox.Text = "0";
            // 
            // S1S1TextBox
            // 
            this.S1S1TextBox.Location = new System.Drawing.Point(84, 146);
            this.S1S1TextBox.Name = "S1S1TextBox";
            this.S1S1TextBox.Size = new System.Drawing.Size(35, 20);
            this.S1S1TextBox.TabIndex = 19;
            this.S1S1TextBox.Text = "0,6";
            // 
            // S1S2TextBox
            // 
            this.S1S2TextBox.Location = new System.Drawing.Point(125, 146);
            this.S1S2TextBox.Name = "S1S2TextBox";
            this.S1S2TextBox.Size = new System.Drawing.Size(34, 20);
            this.S1S2TextBox.TabIndex = 20;
            this.S1S2TextBox.Text = "0,4";
            // 
            // S2S0TextBox
            // 
            this.S2S0TextBox.Location = new System.Drawing.Point(44, 172);
            this.S2S0TextBox.Name = "S2S0TextBox";
            this.S2S0TextBox.Size = new System.Drawing.Size(34, 20);
            this.S2S0TextBox.TabIndex = 21;
            this.S2S0TextBox.Text = "0";
            // 
            // S2S1TextBox
            // 
            this.S2S1TextBox.Location = new System.Drawing.Point(84, 172);
            this.S2S1TextBox.Name = "S2S1TextBox";
            this.S2S1TextBox.Size = new System.Drawing.Size(34, 20);
            this.S2S1TextBox.TabIndex = 22;
            this.S2S1TextBox.Text = "0";
            // 
            // S2S2TextBox
            // 
            this.S2S2TextBox.Location = new System.Drawing.Point(124, 172);
            this.S2S2TextBox.Name = "S2S2TextBox";
            this.S2S2TextBox.Size = new System.Drawing.Size(35, 20);
            this.S2S2TextBox.TabIndex = 23;
            this.S2S2TextBox.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Число экспериментов: ";
            // 
            // NumberOfExperimentsTextBox
            // 
            this.NumberOfExperimentsTextBox.Location = new System.Drawing.Point(137, 201);
            this.NumberOfExperimentsTextBox.Name = "NumberOfExperimentsTextBox";
            this.NumberOfExperimentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfExperimentsTextBox.TabIndex = 25;
            this.NumberOfExperimentsTextBox.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Среднее число выстрелов: ";
            // 
            // MeanShotsTextBox
            // 
            this.MeanShotsTextBox.Location = new System.Drawing.Point(152, 226);
            this.MeanShotsTextBox.Name = "MeanShotsTextBox";
            this.MeanShotsTextBox.ReadOnly = true;
            this.MeanShotsTextBox.Size = new System.Drawing.Size(100, 20);
            this.MeanShotsTextBox.TabIndex = 27;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(7, 312);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(660, 25);
            this.ClearButton.TabIndex = 28;
            this.ClearButton.Text = "Очистить график и среднее число выстрелов";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 343);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.MeanShotsTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NumberOfExperimentsTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.S2S2TextBox);
            this.Controls.Add(this.S2S1TextBox);
            this.Controls.Add(this.S2S0TextBox);
            this.Controls.Add(this.S1S2TextBox);
            this.Controls.Add(this.S1S1TextBox);
            this.Controls.Add(this.S1S0TextBox);
            this.Controls.Add(this.S0S2TextBox);
            this.Controls.Add(this.S0S1TextBox);
            this.Controls.Add(this.S0S0TextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.S2TextBox);
            this.Controls.Add(this.S1TextBox);
            this.Controls.Add(this.S0TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox S0TextBox;
        private System.Windows.Forms.TextBox S1TextBox;
        private System.Windows.Forms.TextBox S2TextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox S0S0TextBox;
        private System.Windows.Forms.TextBox S0S1TextBox;
        private System.Windows.Forms.TextBox S0S2TextBox;
        private System.Windows.Forms.TextBox S1S0TextBox;
        private System.Windows.Forms.TextBox S1S1TextBox;
        private System.Windows.Forms.TextBox S1S2TextBox;
        private System.Windows.Forms.TextBox S2S0TextBox;
        private System.Windows.Forms.TextBox S2S1TextBox;
        private System.Windows.Forms.TextBox S2S2TextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NumberOfExperimentsTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MeanShotsTextBox;
        private System.Windows.Forms.Button ClearButton;
    }
}

