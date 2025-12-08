using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.PrilukovDA.Sprint6.Task2.V12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelCondition;
        private Label labelStart;
        private Label labelStop;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private Button buttonHelp;
        private Button buttonRun;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn columnX;
        private DataGridViewTextBoxColumn columnY;
        private Chart chartFunction;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelCondition = new Label();
            labelStart = new Label();
            labelStop = new Label();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            buttonHelp = new Button();
            buttonRun = new Button();
            dataGridViewResult = new DataGridView();
            chartFunction = new Chart();
            columnX = new DataGridViewTextBoxColumn();
            columnY = new DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();

            // ======== УСЛОВИЕ ========
            labelCondition.Location = new Point(20, 20);
            labelCondition.Size = new Size(380, 120);
            labelCondition.Text =
                "Условие:\n" +
                "Построить таблицу значений функции.\n" +
                "Результат вывести в таблицу и построить график.";

            // ======== ВВОД ДАННЫХ ========
            labelStart.Location = new Point(20, 160);
            labelStart.Size = new Size(100, 23);
            labelStart.Text = "Старт шага:";

            textBoxStart.Location = new Point(120, 155);
            textBoxStart.Size = new Size(70, 23);
            textBoxStart.Text = "-5";

            labelStop.Location = new Point(20, 200);
            labelStop.Size = new Size(100, 23);
            labelStop.Text = "Конец шага:";

            textBoxStop.Location = new Point(120, 195);
            textBoxStop.Size = new Size(70, 23);
            textBoxStop.Text = "5";

            buttonHelp.Location = new Point(20, 330);
            buttonHelp.Size = new Size(120, 40);
            buttonHelp.Text = "Справка";
            buttonHelp.Click += buttonHelp_Click;

            buttonRun.Location = new Point(160, 330);
            buttonRun.Size = new Size(120, 40);
            buttonRun.Text = "Выполнить";
            buttonRun.Click += buttonRun_Click;

            // ======== ТАБЛИЦА ========
            dataGridViewResult.AllowUserToAddRows = false;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { columnX, columnY });
            dataGridViewResult.Location = new Point(432, 20);
            dataGridViewResult.Size = new Size(220, 350);

            columnX.HeaderText = "X";
            columnX.Width = 70;

            columnY.HeaderText = "F(X)";
            columnY.Width = 130;

            // ======== ГРАФИК ========
            chartFunction.Location = new Point(670, 20);
            chartFunction.Size = new Size(300, 350);

            ChartArea chartArea = new ChartArea("MainArea");
            chartFunction.ChartAreas.Add(chartArea);

            Series series = new Series("Function");
            series.ChartType = SeriesChartType.Line;
            series.ChartArea = "MainArea";
            chartFunction.Series.Add(series);

            // ======== ФОРМА ========
            ClientSize = new Size(1000, 400);
            Controls.Add(labelCondition);
            Controls.Add(labelStart);
            Controls.Add(labelStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxStop);
            Controls.Add(buttonHelp);
            Controls.Add(buttonRun);
            Controls.Add(dataGridViewResult);
            Controls.Add(chartFunction);

            Text = "Спринт 6 | Task 2 | Вариант 12 | Прилуков Д.А.";

            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
