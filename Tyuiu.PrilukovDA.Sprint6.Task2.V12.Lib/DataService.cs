using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PrilukovDA.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;

                if (Math.Abs(denominator) < 1e-6)
                {
                    result[index] = 0;
                }
                else
                {
                    double y = (2 * x + 6) / denominator - 3;
                    result[index] = Math.Round(y, 2);
                }

                index++;
            }

            return result;
        }
    }
}
