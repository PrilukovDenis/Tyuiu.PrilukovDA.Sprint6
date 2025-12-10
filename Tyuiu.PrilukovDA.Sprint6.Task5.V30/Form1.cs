using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.PrilukovDA.Sprint6.Task5.V30.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task5.V30
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (*.txt)|*.txt";

                // Указываем путь заранее, чтобы пользователь сразу видел файл
                ofd.FileName = @"C:\Users\prilu\source\repos\Tyuiu.PrilukovDA.Sprint6\Tyuiu.PrilukovDA.Sprint6.Task5.V30\bin\Debug\net8.0-windows\InPutFileTask5V30.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = ofd.FileName;

                    // Получение данных из файла
                    double[] values = ds.LoadFromDataFile(ofd.FileName);

                    // === Вывод в DataGridView ===
                    dataGridViewValues.Rows.Clear();
                    dataGridViewValues.Columns.Clear();
                    dataGridViewValues.Columns.Add("colValue", "Значение");

                    foreach (double v in values)
                    {
                        dataGridViewValues.Rows.Add(v);
                    }

                    // === Построение ступенчатой диаграммы ===
                    chartValues.Series[0].Points.Clear();
                    chartValues.Series[0].ChartType = SeriesChartType.StepLine;
                    chartValues.Series[0].BorderWidth = 3;
                    chartValues.Series[0].Color = Color.Blue;

                    for (int i = 0; i < values.Length; i++)
                    {
                        chartValues.Series[0].Points.AddXY(i + 1, values[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения файла:\n" + ex.Message);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задание: прочитать файл, выбрать числа от 2 до 7,\n" +
                "вывести их в таблицу и построить ступенчатую диаграмму.\n\n" +
                "Sprint 6 — Task 5 — Variant 30\nАвтор: Прилуков Д.А.",
                "Справка"
            );
        }

    }
}
