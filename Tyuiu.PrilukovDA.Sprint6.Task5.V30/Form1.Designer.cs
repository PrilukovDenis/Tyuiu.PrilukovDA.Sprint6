namespace Tyuiu.PrilukovDA.Sprint6.Task5.V30
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLoadFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.DataGridView dataGridViewValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValues;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonLoadFile = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.dataGridViewValues = new System.Windows.Forms.DataGridView();
            this.chartValues = new System.Windows.Forms.DataVisualization.Charting.Chart();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).BeginInit();
            this.SuspendLayout();

            // ==== ГЛАВНОЕ ОПИСАНИЕ ====
            this.labelTitle.Text =
                "Прочитать файл, вывести числа от 2 до 7 и построить ступенчатую диаграмму.\n" +
                "Sprint 6 — Task 5 — Variant 30";
            this.labelTitle.Location = new System.Drawing.Point(10, 10);
            this.labelTitle.Size = new System.Drawing.Size(750, 40);
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);

            // ==== КНОПКА ЗАГРУЗКИ ====
            this.buttonLoadFile.Text = "Открыть файл";
            this.buttonLoadFile.Location = new System.Drawing.Point(10, 60);
            this.buttonLoadFile.Size = new System.Drawing.Size(140, 30);
            this.buttonLoadFile.Click += new System.EventHandler(this.buttonLoadFile_Click);

            // ==== ПОЛЕ ПУТИ ФАЙЛА ====
            this.textBoxPath.Location = new System.Drawing.Point(160, 65);
            this.textBoxPath.Size = new System.Drawing.Size(400, 23);

            // ==== КНОПКА СПРАВКИ ====
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.Location = new System.Drawing.Point(570, 60);
            this.buttonHelp.Size = new System.Drawing.Size(100, 30);
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // ==== ТАБЛИЦА ====
            this.dataGridViewValues.Location = new System.Drawing.Point(10, 110);
            this.dataGridViewValues.Size = new System.Drawing.Size(250, 300);
            this.dataGridViewValues.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // ==== ДИАГРАММА ====
            var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            chartArea.AxisX.Title = "Номер элемента";
            chartArea.AxisY.Title = "Значение";
            chartArea.AxisX.Interval = 1;
            chartArea.Name = "ChartArea1";
            this.chartValues.ChartAreas.Add(chartArea);

            var series = new System.Windows.Forms.DataVisualization.Charting.Series();
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series.BorderWidth = 3;
            series.Color = System.Drawing.Color.Blue;
            series.Name = "Series1";
            series.ChartArea = "ChartArea1";
            this.chartValues.Series.Add(series);

            this.chartValues.Location = new System.Drawing.Point(270, 110);
            this.chartValues.Size = new System.Drawing.Size(500, 300);

            // ==== ФОРМА ====
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonLoadFile);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.dataGridViewValues);
            this.Controls.Add(this.chartValues);
            this.Text = "Sprint 6 | Task 5 | Variant 30";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
