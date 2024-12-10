using System.Drawing;
using System.Windows.Forms;
using Tyuiu.YakovlevVAa.Sprint6.Task3.V20.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task3.V20
{
    public partial class FormMain_YVA : Form
    {
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { -14, 17, -19, 3, 2 }, { -4, -14, -19, -9, -1 }, { 1, 0, 13, 14, 8 }, { 13, 7, 8, -3, -15 }, { 2, -20, 12, -14, 4 } };
        
        public FormMain_YVA()
        {
            InitializeComponent();
           
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            

        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] mtrx = ds.Calculate(matrix);
                int rows = matrix.GetUpperBound(0) + 1;
                int columns = matrix.Length / rows;
                dataGridViewResult_YVA.ColumnCount = columns;
                dataGridViewResult_YVA.RowCount = rows;
                for (int i = 0; i < columns; i++)
                {
                    dataGridViewResult_YVA.Columns[i].Width = 50;

                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewResult_YVA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                    }
                }


            }
            catch
            {
                MessageBox.Show("Ошибка","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-24-2 Яковлев Виктор Александрович", "Сообщение");
        }

    }
}
