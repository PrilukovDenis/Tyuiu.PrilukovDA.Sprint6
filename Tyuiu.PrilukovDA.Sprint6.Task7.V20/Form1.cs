using System.Windows.Forms;
using Tyuiu.PrilukovDA.Sprint6.Task7.V20.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task7.V20
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        int[,] matrix;       
        int[,] resultMatrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = ofd.FileName;

                    matrix = ds.GetMatrix(ofd.FileName);

                    LoadMatrixIntoGrid(matrix, dataGridViewIn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла:\n" + ex.Message);
            }
        }

        // ==========================
        // 2. Выполнить обработку
        // ==========================
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала загрузите файл!", "Ошибка");
                return;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            resultMatrix = new int[rows, cols];

            // копируем исходные значения
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrix[i, j];
                }
            }

            // заменяем 3-й столбец
            for (int i = 0; i < rows; i++)
            {
                int val = resultMatrix[i, 2];

                if (val >= 1 && val <= 20)
                {
                    resultMatrix[i, 2] = 111;
                }
            }

            LoadMatrixIntoGrid(resultMatrix, dataGridViewOut);
        }

        // ==========================
        // 3. Сохранить результат
        // ==========================
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (resultMatrix == null)
            {
                MessageBox.Show("Нет данных для сохранения", "Ошибка");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = "OutPutFileTask7.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveMatrixToCsv(resultMatrix, sfd.FileName);
                MessageBox.Show("Файл успешно сохранён!");
            }
        }

        // ==========================
        // 4. Метод: загрузка mat → Grid
        // ==========================
        private void LoadMatrixIntoGrid(int[,] mat, DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();

            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            // создаём колонки
            for (int j = 0; j < cols; j++)
            {
                grid.Columns.Add("col" + j, "Столбец " + (j + 1));
            }

            // заполняем строками
            for (int i = 0; i < rows; i++)
            {
                object[] row = new object[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = mat[i, j];
                }
                grid.Rows.Add(row);
            }
        }

        // ==========================
        // 5. Метод: сохранение матрицы в файл
        // ==========================
        private void SaveMatrixToCsv(int[,] mat, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                int rows = mat.GetLength(0);
                int cols = mat.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    string[] values = new string[cols];

                    for (int j = 0; j < cols; j++)
                    {
                        values[j] = mat[i, j].ToString();
                    }

                    sw.WriteLine(string.Join(";", values));
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sprint 6 — Task 6 — Variant 20\n" +
                "Работу выполнил Прилуков Денис Алексеевич",
                "Справка"
            );
        }
    }
}
