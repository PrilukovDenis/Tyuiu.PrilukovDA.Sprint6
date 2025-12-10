using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.PrilukovDA.Sprint6.Task4.V17.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task4.V17
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                double[] values = ds.GetMassFunction(start, stop);

                textBoxOutput.Clear();
                int x = start;

                foreach (double y in values)
                {
                    textBoxOutput.AppendText($"x = {x};  F(x) = {y}\r\n");
                    x++;
                }

                chartFunc.Series[0].Points.Clear();
                chartFunc.Series[0].ChartType = SeriesChartType.Line;

                x = start;

                foreach (double y in values)
                {
                    chartFunc.Series[0].Points.AddXY(x, y);
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "OutPutFileTask4V17.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBoxOutput.Text);
                MessageBox.Show("Файл сохранён!");
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа табулирует функцию и строит график.\nАвтор: Прилуков Д.А.", "Справка");
        }

        private void textBoxStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
