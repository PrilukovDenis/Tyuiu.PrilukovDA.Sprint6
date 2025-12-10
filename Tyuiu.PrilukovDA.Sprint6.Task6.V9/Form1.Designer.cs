namespace Tyuiu.PrilukovDA.Sprint6.Task6.V9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonHelp;

        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Splitter splitterMiddle;

        private System.Windows.Forms.TextBox textBoxPath;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();

            this.labelCondition = new System.Windows.Forms.Label();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.splitterMiddle = new System.Windows.Forms.Splitter();

            this.textBoxPath = new System.Windows.Forms.TextBox();

            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // ========== Верхняя панель ==========
            this.panelTop.BackColor = System.Drawing.Color.AliceBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 55;

            // Кнопка Открыть
            this.buttonOpenFile.Text = "";
            this.buttonOpenFile.Width = 40;
            this.buttonOpenFile.Height = 40;
            this.buttonOpenFile.Location = new System.Drawing.Point(10, 7);
            this.buttonOpenFile.Image = System.Drawing.SystemIcons.WinLogo.ToBitmap();
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);

            // Кнопка Выполнить
            this.buttonExecute.Text = "";
            this.buttonExecute.Width = 40;
            this.buttonExecute.Height = 40;
            this.buttonExecute.Location = new System.Drawing.Point(60, 7);
            this.buttonExecute.Image = System.Drawing.SystemIcons.Application.ToBitmap();
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);

            // Кнопка Справка
            this.buttonHelp.Text = "?";
            this.buttonHelp.Width = 40;
            this.buttonHelp.Height = 40;
            this.buttonHelp.Location = new System.Drawing.Point(110, 7);
            this.buttonOpenFile.Image = System.Drawing.SystemIcons.Shield.ToBitmap();
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // textbox для пути файла
            this.textBoxPath.Location = new System.Drawing.Point(170, 15);
            this.textBoxPath.Width = 400;
            this.textBoxPath.ReadOnly = true;

            this.panelTop.Controls.Add(this.buttonOpenFile);
            this.panelTop.Controls.Add(this.buttonExecute);
            this.panelTop.Controls.Add(this.buttonHelp);
            this.panelTop.Controls.Add(this.textBoxPath);

            // ========== Текст условия ==========
            this.labelCondition.Text =
                "Условие:\r\nДан файл InPutFileTask6V9.txt, который может находиться в любом месте на диске. " +
                "Загрузить файл в textBoxIn через openFileDialog. Вывести последнее слово каждой строки " +
                "в результирующую строку и вывести её в textBoxOut.";
            this.labelCondition.AutoSize = false;
            this.labelCondition.Location = new System.Drawing.Point(10, 65);
            this.labelCondition.Size = new System.Drawing.Size(760, 60);

            // ========== Левый textbox ==========
            this.textBoxIn.Multiline = true;
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn.Location = new System.Drawing.Point(10, 130);
            this.textBoxIn.Size = new System.Drawing.Size(360, 300);

            // ========== Вертикальный Splitter ==========
            this.splitterMiddle.Location = new System.Drawing.Point(375, 130);
            this.splitterMiddle.Width = 3;

            // ========== Правый textbox ==========
            this.textBoxOut.Multiline = true;
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Location = new System.Drawing.Point(385, 130);
            this.textBoxOut.Size = new System.Drawing.Size(360, 300);

            // ========== Форма ==========
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Text = "Sprint 6 | Task 6 | Variant 9";

            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.splitterMiddle);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.panelTop);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
