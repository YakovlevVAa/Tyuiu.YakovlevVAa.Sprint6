using Tyuiu.YakovlevVAa.Sprint6.Task6.V26.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        public void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask6_YVA.ShowDialog();
            openFilePath = openFileDialogTask6_YVA.FileName;
            textBoxIn_YVA.Text = File.ReadAllText(openFilePath);
            groupBoxEnter_YVA.Text = groupBoxEnter_YVA.Text + " " + openFileDialogTask6_YVA.FileName;
            buttonStart_YVA.Enabled = true;
        }
        public void buttonStart_Click(object sender, EventArgs e)
        {
            
            textBoxOut_YVA.Text = ds.CollectTextFromFile(openFilePath);
        }
        public void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

    }
}
