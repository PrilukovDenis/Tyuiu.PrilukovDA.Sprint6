using System;
using System.Windows.Forms;
using Tyuiu.PrilukovDA.Sprint6.Task2.V12.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task2.V12
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Задание выполнил студент группы НТм-24-1 Прилуков Д.А.",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                double[] values = ds.GetMassFunction(start, stop);

                dataGridViewResult.Rows.Clear();
                chartFunction.Series["Function"].Points.Clear();

                int index = 0;
                for (int x = start; x <= stop; x++)
                {
                    double y = values[index];
                    dataGridViewResult.Rows.Add(x, y);
                    chartFunction.Series["Function"].Points.AddXY(x, y);
                    index++;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода границ диапазона.",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
