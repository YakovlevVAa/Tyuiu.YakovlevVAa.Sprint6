namespace Tyuiu.YakovlevVAa.Sprint6.Task2.V9
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
            groupBoxResult_YVA = new GroupBox();
            chartFunction_YVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_YVA = new DataGridView();
            ColumnX_YVA = new DataGridViewTextBoxColumn();
            ColumnFunction_YVA = new DataGridViewTextBoxColumn();
            groupBoxCondition_YVA = new GroupBox();
            labelCondition2_YVA = new Label();
            labelCondition1_YVA = new Label();
            groupBoxEnter_YVA = new GroupBox();
            labelStop_YVA = new Label();
            labelStart_YVA = new Label();
            textBoxStopStep_YVA = new TextBox();
            textBoxStartStep_YVA = new TextBox();
            buttonHelp_YVA = new Button();
            buttonStart_YVA = new Button();
            groupBoxResult_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_YVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_YVA).BeginInit();
            groupBoxCondition_YVA.SuspendLayout();
            groupBoxEnter_YVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxResult_YVA
            // 
            groupBoxResult_YVA.Controls.Add(chartFunction_YVA);
            groupBoxResult_YVA.Controls.Add(dataGridView_YVA);
            groupBoxResult_YVA.Location = new Point(696, 12);
            groupBoxResult_YVA.Name = "groupBoxResult_YVA";
            groupBoxResult_YVA.Size = new Size(653, 426);
            groupBoxResult_YVA.TabIndex = 0;
            groupBoxResult_YVA.TabStop = false;
            groupBoxResult_YVA.Text = "Вывод данных";
            // 
            // chartFunction_YVA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_YVA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_YVA.Legends.Add(legend1);
            chartFunction_YVA.Location = new Point(154, 30);
            chartFunction_YVA.Name = "chartFunction_YVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_YVA.Series.Add(series1);
            chartFunction_YVA.Size = new Size(493, 390);
            chartFunction_YVA.TabIndex = 1;
            chartFunction_YVA.Text = "chart1";
            // 
            // dataGridView_YVA
            // 
            dataGridView_YVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_YVA.Columns.AddRange(new DataGridViewColumn[] { ColumnX_YVA, ColumnFunction_YVA });
            dataGridView_YVA.Location = new Point(6, 30);
            dataGridView_YVA.Name = "dataGridView_YVA";
            dataGridView_YVA.RowHeadersVisible = false;
            dataGridView_YVA.RowHeadersWidth = 62;
            dataGridView_YVA.ScrollBars = ScrollBars.Vertical;
            dataGridView_YVA.Size = new Size(142, 390);
            dataGridView_YVA.TabIndex = 0;
            // 
            // ColumnX_YVA
            // 
            ColumnX_YVA.HeaderText = "X";
            ColumnX_YVA.MinimumWidth = 8;
            ColumnX_YVA.Name = "ColumnX_YVA";
            ColumnX_YVA.ReadOnly = true;
            ColumnX_YVA.Width = 70;
            // 
            // ColumnFunction_YVA
            // 
            ColumnFunction_YVA.HeaderText = "f(x)";
            ColumnFunction_YVA.MinimumWidth = 8;
            ColumnFunction_YVA.Name = "ColumnFunction_YVA";
            ColumnFunction_YVA.ReadOnly = true;
            ColumnFunction_YVA.Width = 70;
            // 
            // groupBoxCondition_YVA
            // 
            groupBoxCondition_YVA.Controls.Add(labelCondition2_YVA);
            groupBoxCondition_YVA.Controls.Add(labelCondition1_YVA);
            groupBoxCondition_YVA.Location = new Point(12, 12);
            groupBoxCondition_YVA.Name = "groupBoxCondition_YVA";
            groupBoxCondition_YVA.Size = new Size(678, 295);
            groupBoxCondition_YVA.TabIndex = 1;
            groupBoxCondition_YVA.TabStop = false;
            groupBoxCondition_YVA.Text = "Условие";
            // 
            // labelCondition2_YVA
            // 
            labelCondition2_YVA.AutoSize = true;
            labelCondition2_YVA.Font = new Font("Segoe UI", 8F);
            labelCondition2_YVA.Location = new Point(6, 52);
            labelCondition2_YVA.Name = "labelCondition2_YVA";
            labelCondition2_YVA.Size = new Size(468, 21);
            labelCondition2_YVA.TabIndex = 1;
            labelCondition2_YVA.Text = "Результат вывести в DataGridView и построить график функции";
            // 
            // labelCondition1_YVA
            // 
            labelCondition1_YVA.AutoSize = true;
            labelCondition1_YVA.Font = new Font("Segoe UI", 8F);
            labelCondition1_YVA.Location = new Point(6, 27);
            labelCondition1_YVA.Name = "labelCondition1_YVA";
            labelCondition1_YVA.Size = new Size(387, 21);
            labelCondition1_YVA.TabIndex = 0;
            labelCondition1_YVA.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // groupBoxEnter_YVA
            // 
            groupBoxEnter_YVA.Controls.Add(labelStop_YVA);
            groupBoxEnter_YVA.Controls.Add(labelStart_YVA);
            groupBoxEnter_YVA.Controls.Add(textBoxStopStep_YVA);
            groupBoxEnter_YVA.Controls.Add(textBoxStartStep_YVA);
            groupBoxEnter_YVA.Location = new Point(12, 313);
            groupBoxEnter_YVA.Name = "groupBoxEnter_YVA";
            groupBoxEnter_YVA.Size = new Size(345, 125);
            groupBoxEnter_YVA.TabIndex = 2;
            groupBoxEnter_YVA.TabStop = false;
            groupBoxEnter_YVA.Text = "Ввод данных";
            // 
            // labelStop_YVA
            // 
            labelStop_YVA.AutoSize = true;
            labelStop_YVA.Location = new Point(176, 51);
            labelStop_YVA.Name = "labelStop_YVA";
            labelStop_YVA.Size = new Size(107, 25);
            labelStop_YVA.TabIndex = 3;
            labelStop_YVA.Text = "Конец шага";
            // 
            // labelStart_YVA
            // 
            labelStart_YVA.AutoSize = true;
            labelStart_YVA.Location = new Point(6, 51);
            labelStart_YVA.Name = "labelStart_YVA";
            labelStart_YVA.Size = new Size(117, 25);
            labelStart_YVA.TabIndex = 2;
            labelStart_YVA.Text = "Начало шага";
            // 
            // textBoxStopStep_YVA
            // 
            textBoxStopStep_YVA.Location = new Point(176, 79);
            textBoxStopStep_YVA.Name = "textBoxStopStep_YVA";
            textBoxStopStep_YVA.Size = new Size(150, 31);
            textBoxStopStep_YVA.TabIndex = 1;
            // 
            // textBoxStartStep_YVA
            // 
            textBoxStartStep_YVA.Location = new Point(6, 79);
            textBoxStartStep_YVA.Name = "textBoxStartStep_YVA";
            textBoxStartStep_YVA.Size = new Size(150, 31);
            textBoxStartStep_YVA.TabIndex = 0;
            // 
            // buttonHelp_YVA
            // 
            buttonHelp_YVA.BackColor = SystemColors.Highlight;
            buttonHelp_YVA.ForeColor = Color.Black;
            buttonHelp_YVA.Location = new Point(363, 324);
            buttonHelp_YVA.Name = "buttonHelp_YVA";
            buttonHelp_YVA.Size = new Size(112, 114);
            buttonHelp_YVA.TabIndex = 3;
            buttonHelp_YVA.Text = "Справка";
            buttonHelp_YVA.UseVisualStyleBackColor = false;
            buttonHelp_YVA.Click += buttonHelp_Click;
            // 
            // buttonStart_YVA
            // 
            buttonStart_YVA.BackColor = Color.Green;
            buttonStart_YVA.Location = new Point(481, 324);
            buttonStart_YVA.Name = "buttonStart_YVA";
            buttonStart_YVA.Size = new Size(209, 114);
            buttonStart_YVA.TabIndex = 4;
            buttonStart_YVA.Text = "Выполнить";
            buttonStart_YVA.UseVisualStyleBackColor = false;
            buttonStart_YVA.Click += buttonStart_Click;
            buttonStart_YVA.MouseDown += buttonStart_MouseDown;
            buttonStart_YVA.MouseEnter += buttonStart_MouseEnter;
            buttonStart_YVA.MouseLeave += buttonStart_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 450);
            Controls.Add(buttonStart_YVA);
            Controls.Add(buttonHelp_YVA);
            Controls.Add(groupBoxEnter_YVA);
            Controls.Add(groupBoxCondition_YVA);
            Controls.Add(groupBoxResult_YVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 9 | Яковлев В.А.";
            groupBoxResult_YVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_YVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_YVA).EndInit();
            groupBoxCondition_YVA.ResumeLayout(false);
            groupBoxCondition_YVA.PerformLayout();
            groupBoxEnter_YVA.ResumeLayout(false);
            groupBoxEnter_YVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult_YVA;
        private GroupBox groupBoxCondition_YVA;
        private GroupBox groupBoxEnter_YVA;
        private Label labelCondition2_YVA;
        private Label labelCondition1_YVA;
        private TextBox textBoxStopStep_YVA;
        private TextBox textBoxStartStep_YVA;
        private Label labelStop_YVA;
        private Label labelStart_YVA;
        private Button buttonHelp_YVA;
        private Button buttonStart_YVA;
        private DataGridView dataGridView_YVA;
        private DataGridViewTextBoxColumn ColumnX_YVA;
        private DataGridViewTextBoxColumn ColumnFunction_YVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_YVA;
    }
}
