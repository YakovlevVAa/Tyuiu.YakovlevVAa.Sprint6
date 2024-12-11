using Tyuiu.YakovlevVAa.Sprint6.Task4.V2.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task4.V2
{
    public partial class FormMain_YVA : Form
    {
        DataService ds = new DataService();
        public FormMain_YVA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
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
                this.chartFunction_YVA.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_YVA.ChartAreas[0].AxisY.Title = "��� Y";
                textBoxResult_YVA.Text = "";
                chartFunction_YVA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_YVA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_YVA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� ������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            

        }
        private void buttonHelp_Click( object sender, EventArgs e )
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-2 ������� ������ �������������", "���������");
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V2.txt";
                File.WriteAllText(path, textBoxResult_YVA.Text);
                DialogResult dialogResult = MessageBox.Show("���� " + path + " ������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        


    }
}
