namespace Tyuiu.YakovlevVAa.Sprint6.Task6.V26
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_YVA = new PictureBox();
            textBoxInfo_YVA = new TextBox();
            buttonOk_YVA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_YVA).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_YVA
            // 
            pictureBox_YVA.Image = (Image)resources.GetObject("pictureBox_YVA.Image");
            pictureBox_YVA.Location = new Point(12, 12);
            pictureBox_YVA.Name = "pictureBox_YVA";
            pictureBox_YVA.Size = new Size(212, 293);
            pictureBox_YVA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_YVA.TabIndex = 0;
            pictureBox_YVA.TabStop = false;
            // 
            // textBoxInfo_YVA
            // 
            textBoxInfo_YVA.Location = new Point(249, 12);
            textBoxInfo_YVA.Multiline = true;
            textBoxInfo_YVA.Name = "textBoxInfo_YVA";
            textBoxInfo_YVA.ReadOnly = true;
            textBoxInfo_YVA.Size = new Size(455, 238);
            textBoxInfo_YVA.TabIndex = 1;
            textBoxInfo_YVA.Text = resources.GetString("textBoxInfo_YVA.Text");
            // 
            // buttonOk_YVA
            // 
            buttonOk_YVA.Location = new Point(581, 271);
            buttonOk_YVA.Name = "buttonOk_YVA";
            buttonOk_YVA.Size = new Size(112, 34);
            buttonOk_YVA.TabIndex = 2;
            buttonOk_YVA.Text = "Ок";
            buttonOk_YVA.UseVisualStyleBackColor = true;
            buttonOk_YVA.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 317);
            Controls.Add(buttonOk_YVA);
            Controls.Add(textBoxInfo_YVA);
            Controls.Add(pictureBox_YVA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_YVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_YVA;
        private TextBox textBoxInfo_YVA;
        private Button buttonOk_YVA;
    }
}