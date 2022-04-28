using SamuraiSudokuCozucu.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SamuraiSudokuCozucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btn_sec_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string str = string.Empty;
                Stream fileStream = ofd.OpenFile();
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    str = streamReader.ReadToEnd();
                }
                t_dosya.Text = str;
                Sudoku.RawText = str;
            }

            Sudoku.ProcessRawText();
            Sudoku.FillMainBlock();
            /*Sudoku.Block1 = Sudoku.GetSubBlock(0, 9, 0, 9);
            Sudoku.Block2 = Sudoku.GetSubBlock(12, 21, 0, 9);
            Sudoku.Block3 = Sudoku.GetSubBlock(0, 9, 12, 21);
            Sudoku.Block4 = Sudoku.GetSubBlock(12, 21, 12, 21);
            Sudoku.BlockCenter = Sudoku.GetSubBlock(6, 15, 6, 15);*/
            Asamalar.SelectedTab = tab_sudoku;
            dtg_sudoku.DataSource = Sudoku.GetAllSolvedBlocktoDataTable();
        }

        private void btn_coz_Click(object sender, EventArgs e)
        {
            if(Sudoku.RawText.IsNullOrWhiteSpace())
            {
                MessageBox.Show("Önce dosya seçiniz!");
                return;
            }
            
            DataTable DtReport = Sudoku.SolveSudoku();
            DataTable DtReport2 = Sudoku.SolveSudoku2();
            DataTable DtAll = DtReport.Copy();
            DtAll.Merge(DtReport2, false, MissingSchemaAction.Add);
            dtg_sudoku.DataSource = Sudoku.GetAllSolvedBlocktoDataTable();
            dtg_report.DataSource = DtAll;
            dtg_report.Columns["ThreadName"].HeaderText = "İşlem Adı";
            dtg_report.Columns["Interval"].HeaderText = "Geçen Süre";

            chart1.Series.Clear();
            Series series = chart1.Series.Add("Tek Başlangıç");
            series.ChartType = SeriesChartType.Spline;
            foreach (DataRow dr in DtReport.Rows)
                /*series.Points.AddXY(dr["Interval"].ConvertToInt(), dr["ThreadName"].ConvertToString().Substring(dr["ThreadName"].ConvertToString().Length - 1));
                Bunu yapmamamızın sebebi görüntünün kötü gözükmesi*/
                series.Points.AddXY(dr["ThreadName"].ConvertToString().Substring(dr["ThreadName"].ConvertToString().Length - 1), dr["Interval"].ConvertToInt());
            Series series2 = chart1.Series.Add("İki Başlangıç");
            series2.ChartType = SeriesChartType.Spline;
            foreach (DataRow dr in DtReport2.Rows)
                /*series2.Points.AddXY(dr["Interval"].ConvertToInt(), dr["ThreadName"].ConvertToString().Substring(dr["ThreadName"].ConvertToString().Length - 1));
                Bunu yapmamamızın sebebi görüntünün kötü gözükmesi*/
                series2.Points.AddXY(dr["ThreadName"].ConvertToString().Substring(dr["ThreadName"].ConvertToString().Length - 1), dr["Interval"].ConvertToInt());
            Sudoku.AddToDatabaseTekli(DtReport);
            Sudoku.AddToDatabaseIkili(DtReport2);
            Sudoku.AddToDatabaseTamami(DtAll);
        }

        private void dtg_sudoku_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex.In(0, 1, 2, 3, 4, 5, 6, 7, 8, 12, 13, 14, 15, 16, 17, 18, 19, 20) && 
                e.RowIndex.In(0, 1, 2, 3, 4, 5, 6, 7, 8, 12, 13, 14, 15, 16, 17, 18, 19, 20))
            {
                e.CellStyle.BackColor = Color.LightSkyBlue;
            }

            if(e.ColumnIndex.In(6,7,8,9,10,11,12,13,14) && e.RowIndex.In(6,7,8,9,10,11,12,13,14))
            {
                e.CellStyle.BackColor = Color.DodgerBlue;
            }
        }

        private void dtg_sudoku_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtg_sudoku.ClearSelection();
        }

        private void asamabox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
