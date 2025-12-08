using System;
using System.Windows.Forms;
using Tyuiu.PrilukovDA.Sprint6.Task3.V22.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task3.V22
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();

        int[,] matrix =
        {
            { 17, 0, 19, -8, -1 },
            { 9, 4, -5, 7, 15 },
            { 11, 13, 4, -4, -14 },
            { 11, 14, 5, -15, 16 },
            { 2, -14, -2, 11, 11 }
        };

        public Form1()
        {
            InitializeComponent();
            SetupGrid();
            LoadMatrix();
        }

        private void SetupGrid()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dataGridViewMatrix.ColumnCount = cols;
            dataGridViewMatrix.RowCount = rows;

            for (int j = 0; j < cols; j++)
                dataGridViewMatrix.Columns[j].Width = 45;
        }

        private void LoadMatrix()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);

            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    dataGridViewMatrix.Rows[i].Cells[j].Value = result[i, j];

            textBoxResult.Text = "Обработано";
        }

        private void dataGridViewMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
