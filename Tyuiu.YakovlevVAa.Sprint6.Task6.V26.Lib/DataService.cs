using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YakovlevVAa.Sprint6.Task6.V26.Lib
{
    public class DataService : ISprint6Task6V26
    {
        public string CollectTextFromFile(string path)
        {

            string resStr = "";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    if (words.Length > 0) { string lastWord = words[words.Length - 1]; resStr += lastWord+ " "; }
                    resStr.Trim(' ');
                }
            }
            return resStr;
        }
    }
}
