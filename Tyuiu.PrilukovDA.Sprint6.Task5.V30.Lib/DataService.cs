using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PrilukovDA.Sprint6.Task5.V30.Lib
{
    public class DataService : ISprint6Task5V30
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string text = File.ReadAllText(path);

            char[] separators = { ' ', '\t', '\r', '\n', ';', ',' };

            string[] tokens = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<double> numbers = new List<double>();

            foreach (string token in tokens)
            {
                string normalized = token.Replace(',', '.');

                if (double.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                {
                    if (value >= 2.0 && value <= 7.0)
                    {
                        numbers.Add(Math.Round(value, 3));
                    }
                }
            }

            return numbers.ToArray();
        }
    }
}
