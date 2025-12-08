using System.Drawing;
using System.Windows.Forms;

namespace Tyuiu.PrilukovDA.Sprint6.Task3.V22
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelCondition;
        private DataGridView dataGridViewMatrix;
        private Button buttonRun;

        private GroupBox groupBoxOutput;
        private Label labelResult;
        private TextBox textBoxResult;

        private Panel panelTableBorder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelCondition = new Label();
            dataGridViewMatrix = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            buttonRun = new Button();
            groupBoxOutput = new GroupBox();
            labelResult = new Label();
            textBoxResult = new TextBox();
            panelTableBorder = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxOutput.SuspendLayout();
            panelTableBorder.SuspendLayout();
            SuspendLayout();
            // 
            // labelCondition
            // 
            labelCondition.Font = new Font("Segoe UI", 10F);
            labelCondition.Location = new Point(20, 20);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(260, 160);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Условие:\nДан массив 5×5 элементов.\nЗаменить чётные значения в первой строке на 0.\nРезультат вывести в таблицу.";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.AllowUserToAddRows = false;
            dataGridViewMatrix.AllowUserToResizeColumns = false;
            dataGridViewMatrix.AllowUserToResizeRows = false;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewMatrix.Location = new Point(5, 3);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(372, 239);
            dataGridViewMatrix.TabIndex = 0;
            dataGridViewMatrix.CellContentClick += dataGridViewMatrix_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // buttonRun
            // 
            buttonRun.Font = new Font("Segoe UI", 10F);
            buttonRun.Location = new Point(306, 275);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(150, 45);
            buttonRun.TabIndex = 3;
            buttonRun.Text = "Выполнить";
            buttonRun.Click += buttonRun_Click;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(labelResult);
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Font = new Font("Segoe UI", 10F);
            groupBoxOutput.Location = new Point(20, 200);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(260, 120);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных:";
            // 
            // labelResult
            // 
            labelResult.Location = new Point(15, 35);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(80, 25);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(100, 32);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(130, 25);
            textBoxResult.TabIndex = 1;
            // 
            // panelTableBorder
            // 
            panelTableBorder.BorderStyle = BorderStyle.FixedSingle;
            panelTableBorder.Controls.Add(dataGridViewMatrix);
            panelTableBorder.Location = new Point(300, 20);
            panelTableBorder.Name = "panelTableBorder";
            panelTableBorder.Size = new Size(378, 249);
            panelTableBorder.TabIndex = 1;
            // 
            // Form1
            // 
            ClientSize = new Size(890, 440);
            Controls.Add(labelCondition);
            Controls.Add(panelTableBorder);
            Controls.Add(groupBoxOutput);
            Controls.Add(buttonRun);
            Name = "Form1";
            Text = "Спринт 6 | Task 3 | Вариант 22";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            panelTableBorder.ResumeLayout(false);
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
