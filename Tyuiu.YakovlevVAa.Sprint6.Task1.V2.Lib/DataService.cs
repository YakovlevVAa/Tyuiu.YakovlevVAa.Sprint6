using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YakovlevVAa.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y =Math.Round( 2 + 2 * x + (5 * x + 2.5) / (Math.Sin(x) + 2), 3);
                valueArray[count] = y;
                count++;
            }
            return valueArray;

        }
    }
}
