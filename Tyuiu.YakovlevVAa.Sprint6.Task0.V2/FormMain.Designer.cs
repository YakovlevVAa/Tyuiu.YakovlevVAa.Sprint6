using Tyuiu.YakovlevVAa.Sprint6.Task0.V2.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task0.V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonStart_YVA = new Button();
            labelGoal_YVA = new Label();
            groupBoxCondition_YVA = new GroupBox();
            pictureBoxFormula_YVA = new PictureBox();
            groupBoxVariable_YVA = new GroupBox();
            labelVariableA_YVA = new Label();
            textBoxWrite_YVA = new TextBox();
            groupBoxResult_YVA = new GroupBox();
            labelResult_YVA = new Label();
            textBoxResult_YVA = new TextBox();
            buttonHelp_YVA = new Button();
            groupBoxCondition_YVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_YVA).BeginInit();
            groupBoxVariable_YVA.SuspendLayout();
            groupBoxResult_YVA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonStart_YVA
            // 
            buttonStart_YVA.Location = new Point(623, 404);
            buttonStart_YVA.Name = "buttonStart_YVA";
            buttonStart_YVA.Size = new Size(165, 34);
            buttonStart_YVA.TabIndex = 0;
            buttonStart_YVA.Text = "Выполнить";
            buttonStart_YVA.UseVisualStyleBackColor = true;
            buttonStart_YVA.Click += buttonStart_YVA_Click;
            // 
            // labelGoal_YVA
            // 
            labelGoal_YVA.AutoSize = true;
            labelGoal_YVA.Location = new Point(16, 59);
            labelGoal_YVA.Name = "labelGoal_YVA";
            labelGoal_YVA.Size = new Size(302, 25);
            labelGoal_YVA.TabIndex = 3;
            labelGoal_YVA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxCondition_YVA
            // 
            groupBoxCondition_YVA.Controls.Add(pictureBoxFormula_YVA);
            groupBoxCondition_YVA.Controls.Add(labelGoal_YVA);
            groupBoxCondition_YVA.Location = new Point(12, 12);
            groupBoxCondition_YVA.Name = "groupBoxCondition_YVA";
            groupBoxCondition_YVA.Size = new Size(776, 231);
            groupBoxCondition_YVA.TabIndex = 4;
            groupBoxCondition_YVA.TabStop = false;
            groupBoxCondition_YVA.Text = "Условие";
            // 
            // pictureBoxFormula_YVA
            // 
            pictureBoxFormula_YVA.Image = (Image)resources.GetObject("pictureBoxFormula_YVA.Image");
            pictureBoxFormula_YVA.Location = new Point(500, 43);
            pictureBoxFormula_YVA.Name = "pictureBoxFormula_YVA";
            pictureBoxFormula_YVA.Size = new Size(234, 134);
            pictureBoxFormula_YVA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_YVA.TabIndex = 4;
            pictureBoxFormula_YVA.TabStop = false;
            // 
            // groupBoxVariable_YVA
            // 
            groupBoxVariable_YVA.Controls.Add(labelVariableA_YVA);
            groupBoxVariable_YVA.Controls.Add(textBoxWrite_YVA);
            groupBoxVariable_YVA.Location = new Point(12, 259);
            groupBoxVariable_YVA.Name = "groupBoxVariable_YVA";
            groupBoxVariable_YVA.Size = new Size(393, 119);
            groupBoxVariable_YVA.TabIndex = 5;
            groupBoxVariable_YVA.TabStop = false;
            groupBoxVariable_YVA.Text = "Ввод данных";
            // 
            // labelVariableA_YVA
            // 
            labelVariableA_YVA.AutoSize = true;
            labelVariableA_YVA.Location = new Point(16, 35);
            labelVariableA_YVA.Name = "labelVariableA_YVA";
            labelVariableA_YVA.Size = new Size(134, 25);
            labelVariableA_YVA.TabIndex = 1;
            labelVariableA_YVA.Text = "Переменная X:";
            // 
            // textBoxWrite_YVA
            // 
            textBoxWrite_YVA.Cursor = Cursors.IBeam;
            textBoxWrite_YVA.Location = new Point(16, 63);
            textBoxWrite_YVA.Name = "textBoxWrite_YVA";
            textBoxWrite_YVA.Size = new Size(216, 31);
            textBoxWrite_YVA.TabIndex = 6;
            textBoxWrite_YVA.KeyPress += textBoxWrite_YVA_KeyPress;
            // 
            // groupBoxResult_YVA
            // 
            groupBoxResult_YVA.Controls.Add(labelResult_YVA);
            groupBoxResult_YVA.Controls.Add(textBoxResult_YVA);
            groupBoxResult_YVA.Location = new Point(428, 259);
            groupBoxResult_YVA.Name = "groupBoxResult_YVA";
            groupBoxResult_YVA.Size = new Size(360, 119);
            groupBoxResult_YVA.TabIndex = 6;
            groupBoxResult_YVA.TabStop = false;
            groupBoxResult_YVA.Text = "Вывод данных";
            // 
            // labelResult_YVA
            // 
            labelResult_YVA.AutoSize = true;
            labelResult_YVA.Location = new Point(23, 35);
            labelResult_YVA.Name = "labelResult_YVA";
            labelResult_YVA.Size = new Size(93, 25);
            labelResult_YVA.TabIndex = 1;
            labelResult_YVA.Text = "Результат:";
            // 
            // textBoxResult_YVA
            // 
            textBoxResult_YVA.Location = new Point(23, 63);
            textBoxResult_YVA.Name = "textBoxResult_YVA";
            textBoxResult_YVA.ReadOnly = true;
            textBoxResult_YVA.Size = new Size(308, 31);
            textBoxResult_YVA.TabIndex = 0;
            textBoxResult_YVA.TextChanged += buttonStart_YVA_Click;
            // 
            // buttonHelp_YVA
            // 
            buttonHelp_YVA.Location = new Point(577, 404);
            buttonHelp_YVA.Name = "buttonHelp_YVA";
            buttonHelp_YVA.Size = new Size(40, 34);
            buttonHelp_YVA.TabIndex = 7;
            buttonHelp_YVA.Text = "?";
            buttonHelp_YVA.UseVisualStyleBackColor = true;
            buttonHelp_YVA.Click += buttonHelp_YVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_YVA);
            Controls.Add(groupBoxResult_YVA);
            Controls.Add(groupBoxVariable_YVA);
            Controls.Add(groupBoxCondition_YVA);
            Controls.Add(buttonStart_YVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 2 | Яковлев В.А. ";
            groupBoxCondition_YVA.ResumeLayout(false);
            groupBoxCondition_YVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_YVA).EndInit();
            groupBoxVariable_YVA.ResumeLayout(false);
            groupBoxVariable_YVA.PerformLayout();
            groupBoxResult_YVA.ResumeLayout(false);
            groupBoxResult_YVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart_YVA;
        private Label labelGoal_YVA;
        private GroupBox groupBoxCondition_YVA;
        private PictureBox pictureBoxFormula_YVA;
        private GroupBox groupBoxVariable_YVA;
        private GroupBox groupBoxResult_YVA;
        private TextBox textBoxWrite_YVA;
        private TextBox textBoxResult_YVA;
        private Button buttonHelp_YVA;
        private Label labelVariableA_YVA;
        private Label labelResult_YVA;
    }
}
