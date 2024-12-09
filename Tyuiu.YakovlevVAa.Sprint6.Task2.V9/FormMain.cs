using Tyuiu.YakovlevVAa.Sprint6.Task2.V9.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task2.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_YVA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_YVA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_YVA.Titles.Add("График функции");
                this.chartFunction_YVA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_YVA.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_YVA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_YVA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonStart_MouseEnter(object sender, EventArgs e)
        {
            buttonStart_YVA.BackColor = Color.Red;
        }
        private void buttonStart_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStart_YVA.BackColor = Color.Blue;
        }
        
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-2 Яковлев Виктор Александрович", "Сообщение");
        }

        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            buttonStart_YVA.BackColor = Color.Green;
        }
    }
}
