namespace Tyuiu.YakovlevVAa.Sprint6.Task6.V26
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
            buttonOpenFile_YVA = new Button();
            buttonStart_YVA = new Button();
            buttonHelp_YVA = new Button();
            groupBoxCondition_YVA = new GroupBox();
            textBox1 = new TextBox();
            groupBoxEnter_YVA = new GroupBox();
            textBoxIn_YVA = new TextBox();
            openFileDialogTask6_YVA = new OpenFileDialog();
            toolTip_YVA = new ToolTip(components);
            textBoxOut_YVA = new TextBox();
            groupBoxResult_YVA = new GroupBox();
            groupBoxCondition_YVA.SuspendLayout();
            groupBoxEnter_YVA.SuspendLayout();
            groupBoxResult_YVA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_YVA
            // 
            buttonOpenFile_YVA.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_YVA.BackgroundImage");
            buttonOpenFile_YVA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_YVA.Location = new Point(12, 12);
            buttonOpenFile_YVA.Name = "buttonOpenFile_YVA";
            buttonOpenFile_YVA.Size = new Size(92, 73);
            buttonOpenFile_YVA.TabIndex = 0;
            toolTip_YVA.SetToolTip(buttonOpenFile_YVA, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_YVA.UseVisualStyleBackColor = true;
            buttonOpenFile_YVA.Click += buttonOpenFile_Click;
            // 
            // buttonStart_YVA
            // 
            buttonStart_YVA.BackgroundImage = (Image)resources.GetObject("buttonStart_YVA.BackgroundImage");
            buttonStart_YVA.BackgroundImageLayout = ImageLayout.Center;
            buttonStart_YVA.Enabled = false;
            buttonStart_YVA.Location = new Point(110, 12);
            buttonStart_YVA.Name = "buttonStart_YVA";
            buttonStart_YVA.Size = new Size(92, 73);
            buttonStart_YVA.TabIndex = 1;
            toolTip_YVA.SetToolTip(buttonStart_YVA, "Выводить последнее слово в строчке");
            buttonStart_YVA.UseVisualStyleBackColor = true;
            buttonStart_YVA.Click += buttonStart_Click;
            // 
            // buttonHelp_YVA
            // 
            buttonHelp_YVA.AutoSize = true;
            buttonHelp_YVA.BackgroundImage = (Image)resources.GetObject("buttonHelp_YVA.BackgroundImage");
            buttonHelp_YVA.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_YVA.Location = new Point(1121, 12);
            buttonHelp_YVA.Name = "buttonHelp_YVA";
            buttonHelp_YVA.Size = new Size(92, 73);
            buttonHelp_YVA.TabIndex = 2;
            toolTip_YVA.SetToolTip(buttonHelp_YVA, "Сведение о программе");
            buttonHelp_YVA.UseVisualStyleBackColor = true;
            buttonHelp_YVA.Click += buttonHelp_Click;
            // 
            // groupBoxCondition_YVA
            // 
            groupBoxCondition_YVA.Controls.Add(textBox1);
            groupBoxCondition_YVA.Location = new Point(12, 91);
            groupBoxCondition_YVA.Name = "groupBoxCondition_YVA";
            groupBoxCondition_YVA.Size = new Size(1201, 91);
            groupBoxCondition_YVA.TabIndex = 3;
            groupBoxCondition_YVA.TabStop = false;
            groupBoxCondition_YVA.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 21);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1189, 64);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дан файл InPutFileTask6V26.txt. Загрузить файл в textBoxIn через openFileDialog. Вывести последнее слово каждой строки в результирующею строку и вывести ее в textBoxOut.";
            // 
            // groupBoxEnter_YVA
            // 
            groupBoxEnter_YVA.AutoSize = true;
            groupBoxEnter_YVA.Controls.Add(textBoxIn_YVA);
            groupBoxEnter_YVA.Location = new Point(12, 188);
            groupBoxEnter_YVA.Name = "groupBoxEnter_YVA";
            groupBoxEnter_YVA.Size = new Size(600, 436);
            groupBoxEnter_YVA.TabIndex = 4;
            groupBoxEnter_YVA.TabStop = false;
            groupBoxEnter_YVA.Text = "Ввод";
            // 
            // textBoxIn_YVA
            // 
            textBoxIn_YVA.Location = new Point(6, 30);
            textBoxIn_YVA.Multiline = true;
            textBoxIn_YVA.Name = "textBoxIn_YVA";
            textBoxIn_YVA.ReadOnly = true;
            textBoxIn_YVA.ScrollBars = ScrollBars.Vertical;
            textBoxIn_YVA.Size = new Size(588, 376);
            textBoxIn_YVA.TabIndex = 0;
            // 
            // openFileDialogTask6_YVA
            // 
            openFileDialogTask6_YVA.FileName = "openFileDialog1";
            // 
            // toolTip_YVA
            // 
            toolTip_YVA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_YVA.ToolTipTitle = "Подсказка";
            // 
            // textBoxOut_YVA
            // 
            textBoxOut_YVA.Location = new Point(6, 30);
            textBoxOut_YVA.Multiline = true;
            textBoxOut_YVA.Name = "textBoxOut_YVA";
            textBoxOut_YVA.ReadOnly = true;
            textBoxOut_YVA.ScrollBars = ScrollBars.Vertical;
            textBoxOut_YVA.Size = new Size(583, 372);
            textBoxOut_YVA.TabIndex = 0;
            // 
            // groupBoxResult_YVA
            // 
            groupBoxResult_YVA.AutoSize = true;
            groupBoxResult_YVA.Controls.Add(textBoxOut_YVA);
            groupBoxResult_YVA.Location = new Point(618, 188);
            groupBoxResult_YVA.Name = "groupBoxResult_YVA";
            groupBoxResult_YVA.Size = new Size(595, 432);
            groupBoxResult_YVA.TabIndex = 5;
            groupBoxResult_YVA.TabStop = false;
            groupBoxResult_YVA.Text = "Вывод";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(1225, 608);
            Controls.Add(groupBoxResult_YVA);
            Controls.Add(groupBoxEnter_YVA);
            Controls.Add(groupBoxCondition_YVA);
            Controls.Add(buttonHelp_YVA);
            Controls.Add(buttonStart_YVA);
            Controls.Add(buttonOpenFile_YVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 26 |  Яковлев В.А.";
            groupBoxCondition_YVA.ResumeLayout(false);
            groupBoxCondition_YVA.PerformLayout();
            groupBoxEnter_YVA.ResumeLayout(false);
            groupBoxEnter_YVA.PerformLayout();
            groupBoxResult_YVA.ResumeLayout(false);
            groupBoxResult_YVA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOpenFile_YVA;
        private Button buttonStart_YVA;
        private Button buttonHelp_YVA;
        private GroupBox groupBoxCondition_YVA;
        private TextBox textBox1;
        private GroupBox groupBoxEnter_YVA;
        private TextBox textBoxIn_YVA;
        private OpenFileDialog openFileDialogTask6_YVA;
        private ToolTip toolTip_YVA;
        private TextBox textBoxOut_YVA;
        private GroupBox groupBoxResult_YVA;
    }
}
