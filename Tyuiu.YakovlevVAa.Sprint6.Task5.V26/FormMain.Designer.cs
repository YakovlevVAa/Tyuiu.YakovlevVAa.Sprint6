namespace Tyuiu.YakovlevVAa.Sprint6.Task5.V26
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_YVA = new GroupBox();
            textBoxCondition_YVA = new TextBox();
            groupBoxResult_YVA = new GroupBox();
            dataGridViewResult_YVA = new DataGridView();
            chartNumbers_YVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonStart_YVA = new Button();
            buttonOpenFIle_YVA = new Button();
            buttonHelp_YVA = new Button();
            groupBoxCondition_YVA.SuspendLayout();
            groupBoxResult_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_YVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartNumbers_YVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_YVA
            // 
            groupBoxCondition_YVA.Controls.Add(textBoxCondition_YVA);
            groupBoxCondition_YVA.Location = new Point(12, 12);
            groupBoxCondition_YVA.Name = "groupBoxCondition_YVA";
            groupBoxCondition_YVA.Size = new Size(589, 93);
            groupBoxCondition_YVA.TabIndex = 0;
            groupBoxCondition_YVA.TabStop = false;
            groupBoxCondition_YVA.Text = "Условие";
            // 
            // textBoxCondition_YVA
            // 
            textBoxCondition_YVA.Font = new Font("Segoe UI", 7F);
            textBoxCondition_YVA.Location = new Point(6, 30);
            textBoxCondition_YVA.Multiline = true;
            textBoxCondition_YVA.Name = "textBoxCondition_YVA";
            textBoxCondition_YVA.ReadOnly = true;
            textBoxCondition_YVA.Size = new Size(577, 57);
            textBoxCondition_YVA.TabIndex = 0;
            textBoxCondition_YVA.Text = "Прочитать данные из файла InPutFileTask5V26.txt. Вывести в dataGridView\r\nвсе числа, кратные 5. Построить диаграмму по этим значениям.";
            // 
            // groupBoxResult_YVA
            // 
            groupBoxResult_YVA.Controls.Add(dataGridViewResult_YVA);
            groupBoxResult_YVA.Location = new Point(12, 111);
            groupBoxResult_YVA.Name = "groupBoxResult_YVA";
            groupBoxResult_YVA.Size = new Size(203, 468);
            groupBoxResult_YVA.TabIndex = 1;
            groupBoxResult_YVA.TabStop = false;
            groupBoxResult_YVA.Text = "Вывод данных:";
            // 
            // dataGridViewResult_YVA
            // 
            dataGridViewResult_YVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_YVA.ColumnHeadersVisible = false;
            dataGridViewResult_YVA.EnableHeadersVisualStyles = false;
            dataGridViewResult_YVA.Location = new Point(6, 30);
            dataGridViewResult_YVA.Name = "dataGridViewResult_YVA";
            dataGridViewResult_YVA.ReadOnly = true;
            dataGridViewResult_YVA.RowHeadersVisible = false;
            dataGridViewResult_YVA.RowHeadersWidth = 62;
            dataGridViewResult_YVA.Size = new Size(191, 432);
            dataGridViewResult_YVA.TabIndex = 0;
            // 
            // chartNumbers_YVA
            // 
            chartArea1.Name = "ChartArea1";
            chartNumbers_YVA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartNumbers_YVA.Legends.Add(legend1);
            chartNumbers_YVA.Location = new Point(221, 111);
            chartNumbers_YVA.Name = "chartNumbers_YVA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartNumbers_YVA.Series.Add(series1);
            chartNumbers_YVA.Size = new Size(769, 468);
            chartNumbers_YVA.TabIndex = 2;
            chartNumbers_YVA.Text = "chart1";
            // 
            // buttonStart_YVA
            // 
            buttonStart_YVA.BackColor = Color.ForestGreen;
            buttonStart_YVA.Location = new Point(607, 12);
            buttonStart_YVA.Name = "buttonStart_YVA";
            buttonStart_YVA.Size = new Size(127, 93);
            buttonStart_YVA.TabIndex = 3;
            buttonStart_YVA.Text = "Выполнить";
            buttonStart_YVA.UseVisualStyleBackColor = false;
            buttonStart_YVA.Click += buttonStart_Click;
            // 
            // buttonOpenFIle_YVA
            // 
            buttonOpenFIle_YVA.BackColor = Color.RoyalBlue;
            buttonOpenFIle_YVA.Location = new Point(740, 12);
            buttonOpenFIle_YVA.Name = "buttonOpenFIle_YVA";
            buttonOpenFIle_YVA.Size = new Size(121, 93);
            buttonOpenFIle_YVA.TabIndex = 4;
            buttonOpenFIle_YVA.Text = "Открыть файл";
            buttonOpenFIle_YVA.UseVisualStyleBackColor = false;
            buttonOpenFIle_YVA.Click += buttonOpenFile_Click;
            // 
            // buttonHelp_YVA
            // 
            buttonHelp_YVA.BackColor = Color.DodgerBlue;
            buttonHelp_YVA.Location = new Point(867, 12);
            buttonHelp_YVA.Name = "buttonHelp_YVA";
            buttonHelp_YVA.Size = new Size(123, 93);
            buttonHelp_YVA.TabIndex = 5;
            buttonHelp_YVA.Text = "Справка";
            buttonHelp_YVA.UseVisualStyleBackColor = false;
            buttonHelp_YVA.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 591);
            Controls.Add(buttonHelp_YVA);
            Controls.Add(buttonOpenFIle_YVA);
            Controls.Add(buttonStart_YVA);
            Controls.Add(chartNumbers_YVA);
            Controls.Add(groupBoxResult_YVA);
            Controls.Add(groupBoxCondition_YVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 26 | Яковлев В.А.";
            Load += Form1_Load;
            groupBoxCondition_YVA.ResumeLayout(false);
            groupBoxCondition_YVA.PerformLayout();
            groupBoxResult_YVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_YVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartNumbers_YVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_YVA;
        private GroupBox groupBoxResult_YVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumbers_YVA;
        private TextBox textBoxCondition_YVA;
        private DataGridView dataGridViewResult_YVA;
        private Button buttonStart_YVA;
        private Button buttonOpenFIle_YVA;
        private Button buttonHelp_YVA;
    }
}
