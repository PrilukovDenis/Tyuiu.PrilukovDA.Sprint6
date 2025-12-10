namespace Tyuiu.PrilukovDA.Sprint6.Task7.V20
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonHelp;

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelCondition;

        private System.Windows.Forms.DataGridView dataGridViewIn;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.Splitter splitterMiddle;

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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();

            this.labelCondition = new System.Windows.Forms.Label();

            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.splitterMiddle = new System.Windows.Forms.Splitter();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();

            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();

            this.SuspendLayout();

            // ========= Верхняя панель =========
            this.panelTop.BackColor = System.Drawing.Color.AliceBlue;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;

            // Кнопка Открыть
            this.buttonLoad.Location = new System.Drawing.Point(10, 10);
            this.buttonLoad.Size = new System.Drawing.Size(40, 40);
            this.buttonLoad.Text = "📂";
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 16);
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);

            // Кнопка Выполнить
            this.buttonExecute.Location = new System.Drawing.Point(60, 10);
            this.buttonExecute.Size = new System.Drawing.Size(40, 40);
            this.buttonExecute.Text = "▶";
            this.buttonExecute.Font = new System.Drawing.Font("Segoe UI", 16);
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);

            // Кнопка Сохранить
            this.buttonSave.Location = new System.Drawing.Point(110, 10);
            this.buttonSave.Size = new System.Drawing.Size(40, 40);
            this.buttonSave.Text = "💾";
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 16);
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // Кнопка Справка
            this.buttonHelp.Location = new System.Drawing.Point(160, 10);
            this.buttonHelp.Size = new System.Drawing.Size(40, 40);
            this.buttonHelp.Text = "?";
            this.buttonHelp.Font = new System.Drawing.Font("Segoe UI", 18);
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // Поле пути
            this.textBoxPath.Location = new System.Drawing.Point(220, 20);
            this.textBoxPath.Size = new System.Drawing.Size(400, 23);
            this.textBoxPath.ReadOnly = true;

            this.panelTop.Controls.Add(this.buttonLoad);
            this.panelTop.Controls.Add(this.buttonExecute);
            this.panelTop.Controls.Add(this.buttonSave);
            this.panelTop.Controls.Add(this.buttonHelp);
            this.panelTop.Controls.Add(this.textBoxPath);

            // ========= Условие =========
            this.labelCondition.Text =
                "Условие:\r\nДан файл InPutFileTask7V20.csv. Загрузить файл в dataGridViewIn, " +
                "изменить значения третьего столбца (1..20 → 111), вывести результат и сохранить.";
            this.labelCondition.AutoSize = false;
            this.labelCondition.Location = new System.Drawing.Point(10, 70);
            this.labelCondition.Size = new System.Drawing.Size(760, 50);

            // ========= Левая таблица =========
            this.dataGridViewIn.Location = new System.Drawing.Point(10, 130);
            this.dataGridViewIn.Size = new System.Drawing.Size(360, 300);

            // ========= Разделитель =========
            this.splitterMiddle.Location = new System.Drawing.Point(375, 130);
            this.splitterMiddle.Width = 5;

            // ========= Правая таблица =========
            this.dataGridViewOut.Location = new System.Drawing.Point(385, 130);
            this.dataGridViewOut.Size = new System.Drawing.Size(360, 300);

            // ========= Форма =========
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Text = "Sprint 6 | Таск 7 | Вариант 20 | Прилуков Д.А.";

            this.Controls.Add(this.dataGridViewOut);
            this.Controls.Add(this.splitterMiddle);
            this.Controls.Add(this.dataGridViewIn);
            this.Controls.Add(this.labelCondition);
            this.Controls.Add(this.panelTop);

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
