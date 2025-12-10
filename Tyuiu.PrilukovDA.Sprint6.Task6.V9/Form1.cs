using Tyuiu.PrilukovDA.Sprint6.Task6.V9.Lib;

namespace Tyuiu.PrilukovDA.Sprint6.Task6.V9
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBoxIn.Text = File.ReadAllText(ofd.FileName);
                    textBoxPath.Text = ofd.FileName; // показываем путь
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки файла:\n" + ex.Message);
            }
        }

        // кнопка "Выполнить"
        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxPath.Text))
                {
                    MessageBox.Show("Сначала выберите файл!", "Ошибка");
                    return;
                }

                string result = ds.CollectTextFromFile(textBoxPath.Text);

                textBoxOut.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обработки файла:\n" + ex.Message);
            }
        }

        // кнопка "Справка"
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Sprint 6 — Task 6 — Variant 9\n" +
                "Загрузите файл, программа выведет последнее слово каждой строки.",
                "Справка"
            );
        }
    }
}
