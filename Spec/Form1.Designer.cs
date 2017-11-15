﻿namespace Spec
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.StartStopToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Table = new unvell.ReoGrid.ReoGridControl();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AlphaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShiftTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.StartStopToolButton,
            this.ResetToolButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSaveToolButton});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // FileSaveToolButton
            // 
            this.FileSaveToolButton.Name = "FileSaveToolButton";
            this.FileSaveToolButton.Size = new System.Drawing.Size(158, 26);
            this.FileSaveToolButton.Text = "Сохранить";
            this.FileSaveToolButton.Click += new System.EventHandler(this.FileSaveToolButton_Click);
            // 
            // StartStopToolButton
            // 
            this.StartStopToolButton.Name = "StartStopToolButton";
            this.StartStopToolButton.Size = new System.Drawing.Size(59, 24);
            this.StartStopToolButton.Text = "Старт";
            this.StartStopToolButton.Click += new System.EventHandler(this.StartStopToolButton_Click);
            // 
            // ResetToolButton
            // 
            this.ResetToolButton.Name = "ResetToolButton";
            this.ResetToolButton.Size = new System.Drawing.Size(64, 24);
            this.ResetToolButton.Text = "Сброс";
            this.ResetToolButton.Click += new System.EventHandler(this.ResetToolButton_Click);
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.BackColor = System.Drawing.Color.Transparent;
            this.Graph.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.Graph.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea4);
            this.Graph.Location = new System.Drawing.Point(401, 69);
            this.Graph.Margin = new System.Windows.Forms.Padding(0);
            this.Graph.Name = "Graph";
            this.Graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "Graph";
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "GraphApproximated";
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.Graph.Series.Add(series7);
            this.Graph.Series.Add(series8);
            this.Graph.Size = new System.Drawing.Size(749, 501);
            this.Graph.TabIndex = 4;
            this.Graph.Text = "График";
            // 
            // Table
            // 
            this.Table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Table.BackColor = System.Drawing.Color.White;
            this.Table.ColumnHeaderContextMenuStrip = null;
            this.Table.LeadHeaderContextMenuStrip = null;
            this.Table.Location = new System.Drawing.Point(12, 69);
            this.Table.Name = "Table";
            this.Table.RowHeaderContextMenuStrip = null;
            this.Table.Script = null;
            this.Table.SheetTabContextMenuStrip = null;
            this.Table.SheetTabNewButtonVisible = true;
            this.Table.SheetTabVisible = true;
            this.Table.SheetTabWidth = 60;
            this.Table.ShowScrollEndSpacing = true;
            this.Table.Size = new System.Drawing.Size(393, 486);
            this.Table.TabIndex = 5;
            this.Table.Text = "Таблица";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "xlsx";
            this.SaveFileDialog.FileName = "Таблица";
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(96, 41);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(100, 22);
            this.IntervalTextBox.TabIndex = 6;
            this.IntervalTextBox.Text = "1000";
            this.IntervalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Интервал -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "α -";
            // 
            // AlphaTextBox
            // 
            this.AlphaTextBox.Location = new System.Drawing.Point(275, 41);
            this.AlphaTextBox.Name = "AlphaTextBox";
            this.AlphaTextBox.Size = new System.Drawing.Size(100, 22);
            this.AlphaTextBox.TabIndex = 9;
            this.AlphaTextBox.Text = "10";
            this.AlphaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Смещение -";
            // 
            // ShiftTextBox
            // 
            this.ShiftTextBox.Location = new System.Drawing.Point(503, 41);
            this.ShiftTextBox.Name = "ShiftTextBox";
            this.ShiftTextBox.Size = new System.Drawing.Size(100, 22);
            this.ShiftTextBox.TabIndex = 11;
            this.ShiftTextBox.Text = "0";
            this.ShiftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "мс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "у.е";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "у.е";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShiftTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlphaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Спектрофотометр";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartStopToolButton;
        private System.Windows.Forms.ToolStripMenuItem FileSaveToolButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private unvell.ReoGrid.ReoGridControl Table;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ResetToolButton;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AlphaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShiftTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
