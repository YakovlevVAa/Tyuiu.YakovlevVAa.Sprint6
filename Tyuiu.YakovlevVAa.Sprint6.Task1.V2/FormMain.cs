using System.Linq.Expressions;
using Tyuiu.YakovlevVAa.Sprint6.Task1.V2.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task1.V2
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
                int StartStep = Convert.ToInt32(textBoxStartStep_YVA.Text);
                int StopStep = Convert.ToInt32(textBoxStopStep_YVA.Text);
                string strLine;
                int len = ds.GetMassFunction(StartStep, StopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(StartStep, StopStep);
                textBoxResult_YVA.Text = "";
                textBoxResult_YVA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_YVA.AppendText("|     X    |   f(x)   |" + Environment.NewLine);
                textBoxResult_YVA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |    {1, 5:f2}    |", StartStep, valueArray[i]);
                    textBoxResult_YVA.AppendText(strLine + Environment.NewLine);
                    StartStep++;
                }
                textBoxResult_YVA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-2 Яковлев Виктор Александрович", "Сообщение");
        }
        
    }
}
