using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PrilukovDA.Sprint6.Task7.V20.Lib
{
    public class DataService : ISprint6Task7V20
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] parts = lines[i].Trim().Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(parts[j].Trim());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                int val = matrix[i, 2];

                if (val >= 1 && val <= 20)
                {
                    matrix[i, 2] = 111;
                }
            }

            return matrix;
        }
    }
    }
}
