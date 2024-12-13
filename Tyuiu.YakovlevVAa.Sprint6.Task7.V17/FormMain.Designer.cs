namespace Tyuiu.YakovlevVAa.Sprint6.Task7.V17
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonOpenFile_YVA = new Button();
            buttonStart_YVA = new Button();
            buttonSaveFile_YVA = new Button();
            buttonHelp_YVA = new Button();
            panel2 = new Panel();
            groupBoxCondition_YVA = new GroupBox();
            labelCondition_YVA = new Label();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            dataGridViewIn_YVA = new DataGridView();
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            dataGridViewOut_YVA = new DataGridView();
            toolTipButton = new ToolTip(components);
            openFileDialogTask7 = new OpenFileDialog();
            saveFileDialogTask7 = new SaveFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxCondition_YVA.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_YVA).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_YVA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(buttonOpenFile_YVA);
            panel1.Controls.Add(buttonStart_YVA);
            panel1.Controls.Add(buttonSaveFile_YVA);
            panel1.Controls.Add(buttonHelp_YVA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1224, 78);
            panel1.TabIndex = 0;
            // 
            // buttonOpenFile_YVA
            // 
            buttonOpenFile_YVA.Image = (Image)resources.GetObject("buttonOpenFile_YVA.Image");
            buttonOpenFile_YVA.Location = new Point(12, 3);
            buttonOpenFile_YVA.Name = "buttonOpenFile_YVA";
            buttonOpenFile_YVA.Size = new Size(112, 72);
            buttonOpenFile_YVA.TabIndex = 1;
            toolTipButton.SetToolTip(buttonOpenFile_YVA, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_YVA.UseVisualStyleBackColor = true;
            buttonOpenFile_YVA.Click += buttonOpenFile_Click;
            buttonOpenFile_YVA.MouseEnter += buttonOpenFile_MouseEnter;
            // 
            // buttonStart_YVA
            // 
            buttonStart_YVA.Enabled = false;
            buttonStart_YVA.Image = (Image)resources.GetObject("buttonStart_YVA.Image");
            buttonStart_YVA.Location = new Point(130, 3);
            buttonStart_YVA.Name = "buttonStart_YVA";
            buttonStart_YVA.Size = new Size(112, 72);
            buttonStart_YVA.TabIndex = 2;
            toolTipButton.SetToolTip(buttonStart_YVA, "Выполнить обработку данных");
            buttonStart_YVA.UseVisualStyleBackColor = true;
            buttonStart_YVA.Click += buttonStart_Click;
            buttonStart_YVA.MouseEnter += buttonStart_MouseEnter;
            // 
            // buttonSaveFile_YVA
            // 
            buttonSaveFile_YVA.Enabled = false;
            buttonSaveFile_YVA.Image = (Image)resources.GetObject("buttonSaveFile_YVA.Image");
            buttonSaveFile_YVA.Location = new Point(248, 3);
            buttonSaveFile_YVA.Name = "buttonSaveFile_YVA";
            buttonSaveFile_YVA.Size = new Size(112, 72);
            buttonSaveFile_YVA.TabIndex = 3;
            toolTipButton.SetToolTip(buttonSaveFile_YVA, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_YVA.UseVisualStyleBackColor = true;
            buttonSaveFile_YVA.Click += buttonSaveFile_Click;
            buttonSaveFile_YVA.MouseEnter += buttonSaveFile_MouseEnter;
            // 
            // buttonHelp_YVA
            // 
            buttonHelp_YVA.AutoSize = true;
            buttonHelp_YVA.Image = (Image)resources.GetObject("buttonHelp_YVA.Image");
            buttonHelp_YVA.Location = new Point(1100, 3);
            buttonHelp_YVA.Name = "buttonHelp_YVA";
            buttonHelp_YVA.Size = new Size(112, 72);
            buttonHelp_YVA.TabIndex = 0;
            toolTipButton.SetToolTip(buttonHelp_YVA, "Сведения о программе");
            buttonHelp_YVA.UseVisualStyleBackColor = true;
            buttonHelp_YVA.Click += buttonHelp_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxCondition_YVA);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1224, 93);
            panel2.TabIndex = 1;
            // 
            // groupBoxCondition_YVA
            // 
            groupBoxCondition_YVA.AutoSize = true;
            groupBoxCondition_YVA.Controls.Add(labelCondition_YVA);
            groupBoxCondition_YVA.Dock = DockStyle.Fill;
            groupBoxCondition_YVA.Location = new Point(0, 0);
            groupBoxCondition_YVA.Name = "groupBoxCondition_YVA";
            groupBoxCondition_YVA.Size = new Size(1224, 93);
            groupBoxCondition_YVA.TabIndex = 0;
            groupBoxCondition_YVA.TabStop = false;
            groupBoxCondition_YVA.Text = "Условие";
            // 
            // labelCondition_YVA
            // 
            labelCondition_YVA.AutoSize = true;
            labelCondition_YVA.Font = new Font("Segoe UI", 8F);
            labelCondition_YVA.Location = new Point(8, 27);
            labelCondition_YVA.Name = "labelCondition_YVA";
            labelCondition_YVA.Size = new Size(837, 63);
            labelCondition_YVA.TabIndex = 0;
            labelCondition_YVA.Text = resources.GetString("labelCondition_YVA.Text");
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(0, 175);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 495);
            panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(dataGridViewIn_YVA);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 495);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод";
            // 
            // dataGridViewIn_YVA
            // 
            dataGridViewIn_YVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_YVA.ColumnHeadersVisible = false;
            dataGridViewIn_YVA.Location = new Point(6, 30);
            dataGridViewIn_YVA.Name = "dataGridViewIn_YVA";
            dataGridViewIn_YVA.ReadOnly = true;
            dataGridViewIn_YVA.RowHeadersVisible = false;
            dataGridViewIn_YVA.RowHeadersWidth = 62;
            dataGridViewIn_YVA.ScrollBars = ScrollBars.Vertical;
            dataGridViewIn_YVA.Size = new Size(598, 429);
            dataGridViewIn_YVA.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(1224, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(0, 577);
            panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(dataGridViewOut_YVA);
            groupBox2.Location = new Point(631, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(587, 489);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // dataGridViewOut_YVA
            // 
            dataGridViewOut_YVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_YVA.Location = new Point(6, 30);
            dataGridViewOut_YVA.Name = "dataGridViewOut_YVA";
            dataGridViewOut_YVA.ReadOnly = true;
            dataGridViewOut_YVA.RowHeadersWidth = 62;
            dataGridViewOut_YVA.ScrollBars = ScrollBars.Vertical;
            dataGridViewOut_YVA.Size = new Size(572, 429);
            dataGridViewOut_YVA.TabIndex = 0;
            // 
            // openFileDialogTask7
            // 
            openFileDialogTask7.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1224, 655);
            Controls.Add(groupBox2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 17 | Яковлев В.А.";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBoxCondition_YVA.ResumeLayout(false);
            groupBoxCondition_YVA.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_YVA).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_YVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonHelp_YVA;
        private Button buttonSaveFile_YVA;
        private Button buttonStart_YVA;
        private Button buttonOpenFile_YVA;
        private Panel panel2;
        private GroupBox groupBoxCondition_YVA;
        private Panel panel3;
        private GroupBox groupBox1;
        private DataGridView dataGridViewIn_YVA;
        private Panel panel4;
        private GroupBox groupBox2;
        private DataGridView dataGridViewOut_YVA;
        private Label labelCondition_YVA;
        private ToolTip toolTipButton;
        private OpenFileDialog openFileDialogTask7;
        private SaveFileDialog saveFileDialogTask7;
    }
}
