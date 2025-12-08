namespace Tyuiu.PrilukovDA.Sprint6.Task1.V25
{
    partial class Form1
    {
        private Label labelConditionTitle;
        private Label labelCondition;
        private Label labelStart;
        private Label labelStop;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxResult;
        private ListBox listBoxResult;

        private void InitializeComponent()
        {
            this.labelConditionTitle = new Label();
            this.labelCondition = new Label();
            this.labelStart = new Label();
            this.labelStop = new Label();
            this.textBoxStart = new TextBox();
            this.textBoxStop = new TextBox();
            this.buttonHelp = new Button();
            this.buttonDone = new Button();
            this.groupBoxResult = new GroupBox();
            this.listBoxResult = new ListBox();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();

            this.labelConditionTitle.AutoSize = true;
            this.labelConditionTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.labelConditionTitle.Location = new Point(20, 20);
            this.labelConditionTitle.Text = "Условие";

            this.labelCondition.Location = new Point(20, 50);
            this.labelCondition.Size = new Size(350, 150);
            this.labelCondition.Text =
                "Написать программу, которая выводит таблицу значений функции:\r\n" +
                "F(x) = (5x + 2,5)/(sin(x) - 2) + 2\r\n" +
                "(произвести табулирование) f(x) на диапазоне [-5; 5] с шагом 1.\r\n" +
                "Проверка деления на ноль. При делении на ноль вернуть 0.\r\n" +
                "Округлить до двух знаков после запятой.";

            this.labelStart.AutoSize = true;
            this.labelStart.Location = new Point(20, 220);
            this.labelStart.Text = "Старт шага:";

            this.textBoxStart.Location = new Point(100, 217);
            this.textBoxStart.Size = new Size(80, 23);

            this.labelStop.AutoSize = true;
            this.labelStop.Location = new Point(20, 255);
            this.labelStop.Text = "Конец шага:";

            this.textBoxStop.Location = new Point(100, 252);
            this.textBoxStop.Size = new Size(80, 23);

            this.buttonHelp.Location = new Point(20, 300);
            this.buttonHelp.Size = new Size(120, 40);
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.Click += buttonHelp_Click;

            this.buttonDone.Location = new Point(150, 300);
            this.buttonDone.Size = new Size(120, 40);
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.Click += buttonDone_Click;

            this.groupBoxResult.Controls.Add(this.listBoxResult);
            this.groupBoxResult.Location = new Point(400, 20);
            this.groupBoxResult.Size = new Size(350, 350);
            this.groupBoxResult.Text = "Вывод данных";

            this.listBoxResult.Dock = DockStyle.Fill;
            this.listBoxResult.Font = new Font("Consolas", 10F);

            this.ClientSize = new Size(780, 400);
            this.Controls.Add(this.labelConditionTitle);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.labelStop);
            this.Controls.Add(this.textBoxStop);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxResult);
            this.Text = "Спринт 6 | Task 1 | Вариант 25 | Прилуков Д.А.";
            this.groupBoxResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
