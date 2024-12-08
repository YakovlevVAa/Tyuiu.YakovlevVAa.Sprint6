using Tyuiu.YakovlevVAa.Sprint6.Task1.V2.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valuesWaitArray;
            valuesWaitArray = new double[len];
            valuesWaitArray[0] = -15.604;
            valuesWaitArray[1] = -12.348;
            valuesWaitArray[2] = -10.724;
            valuesWaitArray[3] = -8.876;
            valuesWaitArray[4] = -2.158;
            valuesWaitArray[5] = 3.25;
            valuesWaitArray[6] = 6.639;
            valuesWaitArray[7] = 10.297;
            valuesWaitArray[8] = 16.173;
            valuesWaitArray[9] = 28.098;
            valuesWaitArray[10] = 38.415;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valuesWaitArray, res);
        }
    }
}