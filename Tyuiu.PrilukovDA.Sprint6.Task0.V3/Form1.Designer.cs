namespace Tyuiu.PrilukovDA.Sprint6.Task0.V3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox textBoxVarX;
        private TextBox textBoxResult;
        private Button buttonDone;
        private Button buttonHelp;
        private Label labelCondition;
        private Label labelVarX;
        private Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxVarX = new TextBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            labelCondition = new Label();
            labelVarX = new Label();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(20, 175);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(412, 23);
            textBoxVarX.TabIndex = 2;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(450, 175);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(200, 23);
            textBoxResult.TabIndex = 4;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(450, 250);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(120, 40);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(580, 250);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(120, 40);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.Click += buttonHelp_Click;
            // 
            // labelCondition
            // 
            labelCondition.Font = new Font("Segoe UI", 8F);
            labelCondition.Location = new Point(20, 15);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(400, 120);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Дано выражение, вычислить его значение при x = 3,\nрезультат вывести в TextBox.\nОкруглить до трёх знаков после запятой.\nГрафический интерфейс оформить по шаблону из лекции.";
            // 
            // labelVarX
            // 
            labelVarX.Location = new Point(20, 150);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(120, 25);
            labelVarX.TabIndex = 1;
            labelVarX.Text = "Переменная X:";
            // 
            // labelResult
            // 
            labelResult.Location = new Point(450, 150);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(120, 25);
            labelResult.TabIndex = 3;
            labelResult.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 320);
            Controls.Add(labelCondition);
            Controls.Add(labelVarX);
            Controls.Add(textBoxVarX);
            Controls.Add(labelResult);
            Controls.Add(textBoxResult);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Name = "Form1";
            Text = "Спринт 6 | Task0 | Вариант 3 | Прилуков Д.А.";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
