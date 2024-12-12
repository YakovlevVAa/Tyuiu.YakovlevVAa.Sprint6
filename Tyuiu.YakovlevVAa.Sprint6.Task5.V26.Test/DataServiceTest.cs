namespace Tyuiu.YakovlevVAa.Sprint6.Task5.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\victor\source\repos\Tyuiu.YakovlevVAa.Sprint6\Tyuiu.YakovlevVAa.Sprint6.Task5.V26\bin\Debug\net8.0-windows\InPutDataFileTask5V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}