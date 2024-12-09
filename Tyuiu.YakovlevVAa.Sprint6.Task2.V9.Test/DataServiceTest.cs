using Tyuiu.YakovlevVAa.Sprint6.Task2.V9.Lib;
namespace Tyuiu.YakovlevVAa.Sprint6.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valuesWaitArray;
            valuesWaitArray = new double[len];
            valuesWaitArray[0] = 4.34;
            valuesWaitArray[1] = 4.16;
            valuesWaitArray[2] = 3.71;
            valuesWaitArray[3] = 3.27;
            valuesWaitArray[4] = 2.93;
            valuesWaitArray[5] = 2.5;
            valuesWaitArray[6] = 0.71;
            valuesWaitArray[7] = -47.61;
            valuesWaitArray[8] = 55.15;
            valuesWaitArray[9] = 45.17;
            valuesWaitArray[10] = 14.97;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valuesWaitArray, res);
        }
    }
}