using Tyuiu.YakovlevVAa.Sprint6.Task5.V26.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task5.V26
{
    public partial class FormMain : Form
    {
        string path = @"C:\Users\victor\source\repos\Tyuiu.YakovlevVAa.Sprint6\Tyuiu.YakovlevVAa.Sprint6.Task5.V26\bin\Debug\net8.0-windows\InPutDataFileTask5V26.txt";
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            dataGridViewResult_YVA.ColumnCount = 2;
            dataGridViewResult_YVA.Columns[0].Width = 20;
            dataGridViewResult_YVA.Columns[1].Width = 50;
            this.chartNumbers_YVA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartNumbers_YVA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartNumbers_YVA.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_YVA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartNumbers_YVA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-24-2 Яковлев Виктор Александрович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
