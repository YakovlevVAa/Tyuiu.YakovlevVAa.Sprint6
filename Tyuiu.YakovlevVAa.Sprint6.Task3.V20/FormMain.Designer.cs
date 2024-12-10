namespace Tyuiu.YakovlevVAa.Sprint6.Task3.V20
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
            groupBoxCondition_YVA = new GroupBox();
            buttonHelp_YVA = new Button();
            buttonStart_YVA = new Button();
            groupBoxResult_YVA = new GroupBox();
            dataGridViewResult_YVA = new DataGridView();
            ColumnFirst_YVA = new DataGridViewTextBoxColumn();
            ColumnSecond_YVA = new DataGridViewTextBoxColumn();
            ColumnThird_YVA = new DataGridViewTextBoxColumn();
            ColumnFourth_YVA = new DataGridViewTextBoxColumn();
            ColumnFifth_YVA = new DataGridViewTextBoxColumn();
            textBoxCondition_YVA = new TextBox();
            groupBoxCondition_YVA.SuspendLayout();
            groupBoxResult_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_YVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_YVA
            // 
            groupBoxCondition_YVA.Controls.Add(textBoxCondition_YVA);
            groupBoxCondition_YVA.Controls.Add(buttonHelp_YVA);
            groupBoxCondition_YVA.Controls.Add(buttonStart_YVA);
            groupBoxCondition_YVA.Location = new Point(12, 12);
            groupBoxCondition_YVA.Name = "groupBoxCondition_YVA";
            groupBoxCondition_YVA.Size = new Size(410, 420);
            groupBoxCondition_YVA.TabIndex = 0;
            groupBoxCondition_YVA.TabStop = false;
            groupBoxCondition_YVA.Text = "Условие";
            // 
            // buttonHelp_YVA
            // 
            buttonHelp_YVA.FlatStyle = FlatStyle.Popup;
            buttonHelp_YVA.Location = new Point(243, 376);
            buttonHelp_YVA.Name = "buttonHelp_YVA";
            buttonHelp_YVA.Size = new Size(34, 34);
            buttonHelp_YVA.TabIndex = 8;
            buttonHelp_YVA.Text = "?";
            buttonHelp_YVA.UseVisualStyleBackColor = true;
            buttonHelp_YVA.Click += buttonHelp_Click;
            // 
            // buttonStart_YVA
            // 
            buttonStart_YVA.FlatStyle = FlatStyle.Popup;
            buttonStart_YVA.Location = new Point(287, 376);
            buttonStart_YVA.Name = "buttonStart_YVA";
            buttonStart_YVA.Size = new Size(112, 34);
            buttonStart_YVA.TabIndex = 7;
            buttonStart_YVA.Text = "Выполнить";
            buttonStart_YVA.UseVisualStyleBackColor = true;
            buttonStart_YVA.Click += buttonStart_Click;
            // 
            // groupBoxResult_YVA
            // 
            groupBoxResult_YVA.Controls.Add(dataGridViewResult_YVA);
            groupBoxResult_YVA.Location = new Point(428, 12);
            groupBoxResult_YVA.Name = "groupBoxResult_YVA";
            groupBoxResult_YVA.Size = new Size(464, 426);
            groupBoxResult_YVA.TabIndex = 1;
            groupBoxResult_YVA.TabStop = false;
            groupBoxResult_YVA.Text = "Результат";
            // 
            // dataGridViewResult_YVA
            // 
            dataGridViewResult_YVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_YVA.ColumnHeadersVisible = false;
            dataGridViewResult_YVA.Columns.AddRange(new DataGridViewColumn[] { ColumnFirst_YVA, ColumnSecond_YVA, ColumnThird_YVA, ColumnFourth_YVA, ColumnFifth_YVA });
            dataGridViewResult_YVA.Location = new Point(6, 30);
            dataGridViewResult_YVA.Name = "dataGridViewResult_YVA";
            dataGridViewResult_YVA.RowHeadersVisible = false;
            dataGridViewResult_YVA.RowHeadersWidth = 62;
            dataGridViewResult_YVA.Size = new Size(452, 390);
            dataGridViewResult_YVA.TabIndex = 0;
            // 
            // ColumnFirst_YVA
            // 
            ColumnFirst_YVA.HeaderText = "1";
            ColumnFirst_YVA.MinimumWidth = 8;
            ColumnFirst_YVA.Name = "ColumnFirst_YVA";
            ColumnFirst_YVA.ReadOnly = true;
            ColumnFirst_YVA.Width = 50;
            // 
            // ColumnSecond_YVA
            // 
            ColumnSecond_YVA.HeaderText = "2";
            ColumnSecond_YVA.MinimumWidth = 8;
            ColumnSecond_YVA.Name = "ColumnSecond_YVA";
            ColumnSecond_YVA.ReadOnly = true;
            ColumnSecond_YVA.Width = 50;
            // 
            // ColumnThird_YVA
            // 
            ColumnThird_YVA.HeaderText = "3";
            ColumnThird_YVA.MinimumWidth = 8;
            ColumnThird_YVA.Name = "ColumnThird_YVA";
            ColumnThird_YVA.ReadOnly = true;
            ColumnThird_YVA.Width = 50;
            // 
            // ColumnFourth_YVA
            // 
            ColumnFourth_YVA.HeaderText = "4";
            ColumnFourth_YVA.MinimumWidth = 8;
            ColumnFourth_YVA.Name = "ColumnFourth_YVA";
            ColumnFourth_YVA.ReadOnly = true;
            ColumnFourth_YVA.Width = 50;
            // 
            // ColumnFifth_YVA
            // 
            ColumnFifth_YVA.HeaderText = "5";
            ColumnFifth_YVA.MinimumWidth = 8;
            ColumnFifth_YVA.Name = "ColumnFifth_YVA";
            ColumnFifth_YVA.ReadOnly = true;
            ColumnFifth_YVA.Width = 50;
            // 
            // textBoxCondition_YVA
            // 
            textBoxCondition_YVA.Location = new Point(6, 30);
            textBoxCondition_YVA.Multiline = true;
            textBoxCondition_YVA.Name = "textBoxCondition_YVA";
            textBoxCondition_YVA.ReadOnly = true;
            textBoxCondition_YVA.Size = new Size(393, 340);
            textBoxCondition_YVA.TabIndex = 9;
            textBoxCondition_YVA.Text = "Дан массив 5 на 5 элементов.\r\n-14  17 -19   3   2\r\n\r\n  -4 -14 -19  -9  -1\r\n\r\n   1   0  13  14   8\r\n\r\n  13   7   8  -3 -15\r\n\r\n   2 -20  12 -14   4\r\nЗаменить четные значения в пятой строке на 0.";
            // 
            // FormMain_YVA
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(groupBoxResult_YVA);
            Controls.Add(groupBoxCondition_YVA);
            Name = "FormMain_YVA";
            Text = "Спринт 6 | Таск 3 | Вариант 20 | Яковлев В.А.";
            groupBoxCondition_YVA.ResumeLayout(false);
            groupBoxCondition_YVA.PerformLayout();
            groupBoxResult_YVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_YVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_YVA;
        private GroupBox groupBoxResult_YVA;
        private Button buttonStart_YVA;
        private DataGridView dataGridViewResult_YVA;
        private DataGridViewTextBoxColumn ColumnFirst_YVA;
        private DataGridViewTextBoxColumn ColumnSecond_YVA;
        private DataGridViewTextBoxColumn ColumnThird_YVA;
        private DataGridViewTextBoxColumn ColumnFourth_YVA;
        private DataGridViewTextBoxColumn ColumnFifth_YVA;
        private Button buttonHelp_YVA;
        private TextBox textBoxCondition_YVA;
    }
}
