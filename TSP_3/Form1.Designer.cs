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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.S0TextBox = new System.Windows.Forms.TextBox();
            this.S1TextBox = new System.Windows.Forms.TextBox();
            this.S2TextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StartButton = new System.Windows.Forms.Button();
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(263, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(404, 300);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 87);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(245, 94);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Симуляция";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 314);
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
    }
}

