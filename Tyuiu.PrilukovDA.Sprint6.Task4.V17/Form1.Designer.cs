namespace Tyuiu.PrilukovDA.Sprint6.Task4.V17
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы формы
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelStop;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBoxStop;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            labelCondition = new Label();
            labelStart = new Label();
            labelStop = new Label();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            buttonExecute = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // labelCondition
            // 
            labelCondition.Location = new Point(10, 10);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(600, 40);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Табулировать функцию F(x) на диапазоне [-5;5] с шагом 1.\r\nРезультат вывести в таблицу, построить график и сохранить в файл.";
            // 
            // labelStart
            // 
            labelStart.Location = new Point(10, 60);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(100, 23);
            labelStart.TabIndex = 1;
            labelStart.Text = "Старт шага:";
            // 
            // labelStop
            // 
            labelStop.Location = new Point(10, 90);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(100, 23);
            labelStop.TabIndex = 2;
            labelStop.Text = "Конец шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(116, 60);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(50, 23);
            textBoxStart.TabIndex = 3;
            textBoxStart.TextChanged += textBoxStart_TextChanged_1;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(116, 90);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(50, 23);
            textBoxStop.TabIndex = 4;
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(180, 60);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(100, 30);
            buttonExecute.TabIndex = 5;
            buttonExecute.Text = "Выполнить";
            buttonExecute.Click += buttonExecute_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(300, 60);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 30);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(420, 60);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(100, 30);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Справка";
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(10, 130);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(250, 300);
            textBoxOutput.TabIndex = 8;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(labelCondition);
            Controls.Add(labelStart);
            Controls.Add(labelStop);
            Controls.Add(textBoxStart);
            Controls.Add(textBoxStop);
            Controls.Add(buttonExecute);
            Controls.Add(buttonSave);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxOutput);
            Name = "Form1";
            Text = "Sprint 6 | Task 4 | Variant 17";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
