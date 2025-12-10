using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PrilukovDA.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                if (Math.Abs(x + 1.7) < 1e-9)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Sin(x) / (x + 1.7)) - Math.Cos(x) * (4 * x) - 6;
                }

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
