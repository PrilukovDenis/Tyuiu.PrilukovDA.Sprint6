using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PrilukovDA.Sprint6.Task1.V25.Lib
{
    public class DataService : ISprint6Task1V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) - 2;

                double y;

                if (Math.Abs(denominator) < 1e-10)
                {
                    y = 0;
                }
                else
                {
                    y = (5 * x + 2.5) / denominator + 2;
                }

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
