﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YakovlevVAa.Sprint6.Task5.V26.Lib
{
    public class DataService : ISprint6Task5V26
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    numsArray[index++] = double.Parse(line);
                }

            }
            numsArray = numsArray.Where(val => Math.Round(val,3)%5 == 0).ToArray();
            return numsArray;
        }
    }
}
