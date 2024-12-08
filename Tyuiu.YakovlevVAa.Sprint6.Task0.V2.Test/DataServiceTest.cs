using Tyuiu.YakovlevVAa.Sprint6.Task0.V2.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = 4.95;
            Assert.AreEqual(wait, res);
        }
    }
}