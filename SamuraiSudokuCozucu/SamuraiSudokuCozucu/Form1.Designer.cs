
namespace SamuraiSudokuCozucu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_coz = new System.Windows.Forms.Button();
            this.btn_sec = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tab_sudoku = new System.Windows.Forms.TabPage();
            this.dtg_sudoku = new System.Windows.Forms.DataGridView();
            this.dtg_report = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab_dosya = new System.Windows.Forms.TabPage();
            this.t_dosya = new System.Windows.Forms.RichTextBox();
            this.Asamalar = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_sudoku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sudoku)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tab_dosya.SuspendLayout();
            this.Asamalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_coz);
            this.groupBox1.Controls.Add(this.btn_sec);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1430, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_coz
            // 
            this.btn_coz.Image = global::SamuraiSudokuCozucu.Properties.Resources.yinyang;
            this.btn_coz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_coz.Location = new System.Drawing.Point(199, 19);
            this.btn_coz.Name = "btn_coz";
            this.btn_coz.Size = new System.Drawing.Size(183, 67);
            this.btn_coz.TabIndex = 1;
            this.btn_coz.Text = "Çözümü Başlat";
            this.btn_coz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_coz.UseVisualStyleBackColor = true;
            this.btn_coz.Click += new System.EventHandler(this.btn_coz_Click);
            // 
            // btn_sec
            // 
            this.btn_sec.Image = global::SamuraiSudokuCozucu.Properties.Resources.folder_up;
            this.btn_sec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sec.Location = new System.Drawing.Point(10, 17);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(183, 69);
            this.btn_sec.TabIndex = 0;
            this.btn_sec.Text = "Dosya Seçiniz...";
            this.btn_sec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Asamalar);
            this.groupBox2.Location = new System.Drawing.Point(15, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1430, 593);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // ofd
            // 
            this.ofd.Filter = "*.txt|*.txt";
            // 
            // tab_sudoku
            // 
            this.tab_sudoku.Controls.Add(this.chart1);
            this.tab_sudoku.Controls.Add(this.dtg_report);
            this.tab_sudoku.Controls.Add(this.dtg_sudoku);
            this.tab_sudoku.Location = new System.Drawing.Point(4, 25);
            this.tab_sudoku.Name = "tab_sudoku";
            this.tab_sudoku.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sudoku.Size = new System.Drawing.Size(1416, 543);
            this.tab_sudoku.TabIndex = 1;
            this.tab_sudoku.Text = "Sudoku Çözümü";
            this.tab_sudoku.UseVisualStyleBackColor = true;
            // 
            // dtg_sudoku
            // 
            this.dtg_sudoku.AllowUserToAddRows = false;
            this.dtg_sudoku.AllowUserToDeleteRows = false;
            this.dtg_sudoku.AllowUserToResizeColumns = false;
            this.dtg_sudoku.AllowUserToResizeRows = false;
            this.dtg_sudoku.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtg_sudoku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_sudoku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_sudoku.ColumnHeadersVisible = false;
            this.dtg_sudoku.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_sudoku.Enabled = false;
            this.dtg_sudoku.Location = new System.Drawing.Point(3, 3);
            this.dtg_sudoku.Name = "dtg_sudoku";
            this.dtg_sudoku.ReadOnly = true;
            this.dtg_sudoku.RowHeadersVisible = false;
            this.dtg_sudoku.RowHeadersWidth = 51;
            this.dtg_sudoku.RowTemplate.Height = 24;
            this.dtg_sudoku.Size = new System.Drawing.Size(687, 537);
            this.dtg_sudoku.TabIndex = 0;
            this.dtg_sudoku.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtg_sudoku_CellPainting);
            this.dtg_sudoku.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtg_sudoku_DataBindingComplete);
            // 
            // dtg_report
            // 
            this.dtg_report.AllowUserToAddRows = false;
            this.dtg_report.AllowUserToDeleteRows = false;
            this.dtg_report.AllowUserToResizeColumns = false;
            this.dtg_report.AllowUserToResizeRows = false;
            this.dtg_report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtg_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_report.Location = new System.Drawing.Point(696, 3);
            this.dtg_report.Name = "dtg_report";
            this.dtg_report.ReadOnly = true;
            this.dtg_report.RowHeadersWidth = 51;
            this.dtg_report.RowTemplate.Height = 24;
            this.dtg_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_report.Size = new System.Drawing.Size(400, 537);
            this.dtg_report.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1102, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SudokuChart";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(315, 537);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // tab_dosya
            // 
            this.tab_dosya.Controls.Add(this.t_dosya);
            this.tab_dosya.Location = new System.Drawing.Point(4, 25);
            this.tab_dosya.Name = "tab_dosya";
            this.tab_dosya.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dosya.Size = new System.Drawing.Size(1416, 543);
            this.tab_dosya.TabIndex = 0;
            this.tab_dosya.Text = "Seçilen Dosya İçeriği";
            this.tab_dosya.UseVisualStyleBackColor = true;
            // 
            // t_dosya
            // 
            this.t_dosya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_dosya.Location = new System.Drawing.Point(3, 3);
            this.t_dosya.Name = "t_dosya";
            this.t_dosya.ReadOnly = true;
            this.t_dosya.Size = new System.Drawing.Size(1410, 537);
            this.t_dosya.TabIndex = 0;
            this.t_dosya.Text = "";
            // 
            // Asamalar
            // 
            this.Asamalar.Controls.Add(this.tab_dosya);
            this.Asamalar.Controls.Add(this.tab_sudoku);
            this.Asamalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Asamalar.Location = new System.Drawing.Point(3, 18);
            this.Asamalar.Name = "Asamalar";
            this.Asamalar.SelectedIndex = 0;
            this.Asamalar.Size = new System.Drawing.Size(1424, 572);
            this.Asamalar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Samurai Sudoku Çözücü Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tab_sudoku.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_sudoku)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tab_dosya.ResumeLayout(false);
            this.Asamalar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.Button btn_coz;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TabControl Asamalar;
        private System.Windows.Forms.TabPage tab_dosya;
        private System.Windows.Forms.RichTextBox t_dosya;
        private System.Windows.Forms.TabPage tab_sudoku;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dtg_report;
        private System.Windows.Forms.DataGridView dtg_sudoku;
    }
}

