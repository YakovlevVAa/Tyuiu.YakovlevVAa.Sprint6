namespace Tyuiu.YakovlevVAa.Sprint6.Task4.V2
{
    partial class FormMain_YVA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_YVA = new GroupBox();
            textBoxCondition_YVA = new TextBox();
            groupBoxEnter_YVA = new GroupBox();
            label2 = new Label();
            labelStartStep_YVA = new Label();
            textBoxStopStep_YVA = new TextBox();
            textBoxStartStep_YVA = new TextBox();
            groupBoxResult_YVA = new GroupBox();
            textBoxResult_YVA = new TextBox();
            chartFunction_YVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonStart_YVA = new Button();
            buttonSave_YVA = new Button();
            buttonHelp_YVA = new Button();
            groupBoxCondition_YVA.SuspendLayout();
            groupBoxEnter_YVA.SuspendLayout();
            groupBoxResult_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_YVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_YVA
            // 
            groupBoxCondition_YVA.Controls.Add(textBoxCondition_YVA);
            groupBoxCondition_YVA.Location = new Point(12, 12);
            groupBoxCondition_YVA.Name = "groupBoxCondition_YVA";
            groupBoxCondition_YVA.Size = new Size(442, 95);
            groupBoxCondition_YVA.TabIndex = 0;
            groupBoxCondition_YVA.TabStop = false;
            groupBoxCondition_YVA.Text = "Условие:";
            // 
            // textBoxCondition_YVA
            // 
            textBoxCondition_YVA.Font = new Font("Segoe UI", 6F);
            textBoxCondition_YVA.Location = new Point(6, 24);
            textBoxCondition_YVA.Multiline = true;
            textBoxCondition_YVA.Name = "textBoxCondition_YVA";
            textBoxCondition_YVA.ReadOnly = true;
            textBoxCondition_YVA.Size = new Size(430, 65);
            textBoxCondition_YVA.TabIndex = 0;
            textBoxCondition_YVA.Text = "Протабулировать функцию на диапазоне от -5 до 5\r\nРезультат вывести в textBox, построить график функции и сохранить в файл\r\nOutPutFileTask4V2.txt";
            // 
            // groupBoxEnter_YVA
            // 
            groupBoxEnter_YVA.Controls.Add(label2);
            groupBoxEnter_YVA.Controls.Add(labelStartStep_YVA);
            groupBoxEnter_YVA.Controls.Add(textBoxStopStep_YVA);
            groupBoxEnter_YVA.Controls.Add(textBoxStartStep_YVA);
            groupBoxEnter_YVA.Location = new Point(460, 12);
            groupBoxEnter_YVA.Name = "groupBoxEnter_YVA";
            groupBoxEnter_YVA.Size = new Size(294, 95);
            groupBoxEnter_YVA.TabIndex = 1;
            groupBoxEnter_YVA.TabStop = false;
            groupBoxEnter_YVA.Text = "Ввод данных:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F);
            label2.Location = new Point(154, 24);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 2;
            label2.Text = "Конец шага:";
            // 
            // labelStartStep_YVA
            // 
            labelStartStep_YVA.AutoSize = true;
            labelStartStep_YVA.Font = new Font("Segoe UI", 7F);
            labelStartStep_YVA.Location = new Point(6, 24);
            labelStartStep_YVA.Name = "labelStartStep_YVA";
            labelStartStep_YVA.Size = new Size(82, 19);
            labelStartStep_YVA.TabIndex = 0;
            labelStartStep_YVA.Text = "Старт шага:";
            // 
            // textBoxStopStep_YVA
            // 
            textBoxStopStep_YVA.Location = new Point(154, 47);
            textBoxStopStep_YVA.Name = "textBoxStopStep_YVA";
            textBoxStopStep_YVA.Size = new Size(134, 31);
            textBoxStopStep_YVA.TabIndex = 1;
            // 
            // textBoxStartStep_YVA
            // 
            textBoxStartStep_YVA.Location = new Point(6, 47);
            textBoxStartStep_YVA.Name = "textBoxStartStep_YVA";
            textBoxStartStep_YVA.Size = new Size(134, 31);
            textBoxStartStep_YVA.TabIndex = 0;
            // 
            // groupBoxResult_YVA
            // 
            groupBoxResult_YVA.Controls.Add(textBoxResult_YVA);
            groupBoxResult_YVA.Location = new Point(12, 113);
            groupBoxResult_YVA.Name = "groupBoxResult_YVA";
            groupBoxResult_YVA.Size = new Size(300, 468);
            groupBoxResult_YVA.TabIndex = 2;
            groupBoxResult_YVA.TabStop = false;
            groupBoxResult_YVA.Text = "Вывод:";
            // 
            // textBoxResult_YVA
            // 
            textBoxResult_YVA.Location = new Point(6, 30);
            textBoxResult_YVA.Multiline = true;
            textBoxResult_YVA.Name = "textBoxResult_YVA";
            textBoxResult_YVA.ReadOnly = true;
            textBoxResult_YVA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_YVA.Size = new Size(288, 432);
            textBoxResult_YVA.TabIndex = 0;
            // 
            // chartFunction_YVA
            // 
            chartArea3.Name = "ChartArea1";
            chartFunction_YVA.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            chartFunction_YVA.Legends.Add(legend3);
            chartFunction_YVA.Location = new Point(329, 113);
            chartFunction_YVA.Name = "chartFunction_YVA";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFunction_YVA.Series.Add(series3);
            chartFunction_YVA.Size = new Size(890, 468);
            chartFunction_YVA.TabIndex = 3;
            chartFunction_YVA.Text = "chart1";
            // 
            // buttonStart_YVA
            // 
            buttonStart_YVA.BackColor = Color.ForestGreen;
            buttonStart_YVA.Location = new Point(760, 22);
            buttonStart_YVA.Name = "buttonStart_YVA";
            buttonStart_YVA.Size = new Size(112, 79);
            buttonStart_YVA.TabIndex = 4;
            buttonStart_YVA.Text = "Выполнить";
            buttonStart_YVA.UseVisualStyleBackColor = false;
            buttonStart_YVA.Click += buttonStart_Click;
            // 
            // buttonSave_YVA
            // 
            buttonSave_YVA.BackColor = Color.RoyalBlue;
            buttonSave_YVA.Location = new Point(878, 22);
            buttonSave_YVA.Name = "buttonSave_YVA";
            buttonSave_YVA.Size = new Size(112, 79);
            buttonSave_YVA.TabIndex = 5;
            buttonSave_YVA.Text = "Сохранить";
            buttonSave_YVA.UseVisualStyleBackColor = false;
            buttonSave_YVA.Click += buttonSave_Click;
            // 
            // buttonHelp_YVA
            // 
            buttonHelp_YVA.BackColor = Color.CornflowerBlue;
            buttonHelp_YVA.Location = new Point(1107, 22);
            buttonHelp_YVA.Name = "buttonHelp_YVA";
            buttonHelp_YVA.Size = new Size(112, 79);
            buttonHelp_YVA.TabIndex = 6;
            buttonHelp_YVA.Text = "Справка";
            buttonHelp_YVA.UseVisualStyleBackColor = false;
            buttonHelp_YVA.Click += buttonHelp_Click;
            // 
            // FormMain_YVA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 593);
            Controls.Add(buttonHelp_YVA);
            Controls.Add(buttonSave_YVA);
            Controls.Add(buttonStart_YVA);
            Controls.Add(chartFunction_YVA);
            Controls.Add(groupBoxResult_YVA);
            Controls.Add(groupBoxEnter_YVA);
            Controls.Add(groupBoxCondition_YVA);
            Name = "FormMain_YVA";
            Text = "Спринт 6 | Таск 4 | Вариант 2 | Яковлев В.А. ";
            Load += Form1_Load;
            groupBoxCondition_YVA.ResumeLayout(false);
            groupBoxCondition_YVA.PerformLayout();
            groupBoxEnter_YVA.ResumeLayout(false);
            groupBoxEnter_YVA.PerformLayout();
            groupBoxResult_YVA.ResumeLayout(false);
            groupBoxResult_YVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_YVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_YVA;
        private GroupBox groupBoxEnter_YVA;
        private TextBox textBoxCondition_YVA;
        private GroupBox groupBoxResult_YVA;
        private TextBox textBoxResult_YVA;
        private Label label2;
        private Label labelStartStep_YVA;
        private TextBox textBoxStopStep_YVA;
        private TextBox textBoxStartStep_YVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_YVA;
        private Button buttonStart_YVA;
        private Button buttonSave_YVA;
        private Button buttonHelp_YVA;
    }
}
