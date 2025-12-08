using Tyuiu.PrilukovDA.Sprint6.Task1.V25.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task1.V25
{
    public partial class Form1 : Form
    {
            DataService ds = new DataService();

            public Form1()
            {
                InitializeComponent();
            }

            private void buttonDone_Click(object sender, EventArgs e)
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);

                double[] result = ds.GetMassFunction(start, stop);

                listBoxResult.Items.Clear();
                listBoxResult.Items.Add("   X     |   f(x)");
                listBoxResult.Items.Add("----------------------");

                int index = 0;

                for (int x = start; x <= stop; x++)
                {
                    listBoxResult.Items.Add($"{x,5}   |  {result[index],6:F2}");
                    index++;
                }
            }

            private void buttonHelp_Click(object sender, EventArgs e)
            {
                MessageBox.Show(
                    "Task 1. Выполнил студент НТм-24-1 Прилуков Д.А.",
                    "Справка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
