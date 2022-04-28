using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamuraiSudokuCozucu.Classess
{
    
    class Sudoku
    {
        public static string RawText = string.Empty;
        public static int[,] MainBlock = new int[21, 21];
        public static int[,] Block1 = new int[9, 9];
        public static int[,] Block2 = new int[9, 9];
        public static int[,] Block3 = new int[9, 9];
        public static int[,] Block4 = new int[9, 9];
        public static int[,] BlockCenter = new int[9, 9];

        public static void FillMainBlock()
        {
            char[] AllTextArray = RawText.ToCharArray();
            int k = 0;
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    MainBlock[i, j] = AllTextArray[k].ConvertToInt();
                    k++;
                }
            }
        }

        public static int[,] GetSubBlock(int fromi, int toi, int fromj, int toj)
        {
            int[,] ret = new int[9, 9];
            int x = 0;
            for (int i = fromi; i < toi; i++)
            {
                int y = 0; 
                for (int j = fromj; j < toj; j++)
                {
                    ret[x,y] = MainBlock[i, j];
                    y++;
                }
                x++;
            }
            return ret;
        }

        public static void SetSubBlock(int[,] input, int fromi, int toi, int fromj, int toj)
        {
            int x = 0;
            for (int i = fromi; i < toi; i++)
            {
                int y = 0;
                for (int j = fromj; j < toj; j++)
                {
                    MainBlock[i, j] = input[x, y];
                    y++;
                }
                x++;
            }
        }

        public static void ProcessRawText()
        {
            string[] RawLines = RawText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < RawLines.Length; i++)
            {
                if (i.In(0, 1, 2, 3, 4, 5, 15, 16, 17, 18, 19, 20))
                    RawLines[i] = RawLines[i].Insert(9, "***");
                if (i.In(9, 10, 11))
                {
                    RawLines[i] = RawLines[i].Insert(0, "******");
                    RawLines[i] = RawLines[i].Insert(15, "******");
                }
            }
            RawText = string.Join("", RawLines);
        }

        public static DataTable GetAllSolvedBlocktoDataTable()
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < 21; i++)
                dt.Columns.Add(i.ConvertToString(), typeof(int));
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (j == 0)
                        dt.Rows.Add(dt.NewRow());
                    dt.Rows[i][j] = MainBlock[i, j];
                }
            }
            return dt;
        }

        
        public static long SolveBlock1()
        {
            int x = 0;
            for (int i = 0; i < 9; i++)
            {
                int y = 0;
                for (int j = 0; j < 9; j++)
                {
                    Block1[x, y] = MainBlock[i, j];
                    y++;
                }
                x++;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(10);
            Solve(Block1);
            int a = 0;
            for (int i = 0; i < 9; i++)
            {
                int b = 0;
                for (int j = 0; j < 9; j++)
                {
                    MainBlock[i, j] = Block1[a, b];
                    b++;
                }
                a++;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static long SolveBlock2()
        {
            int x = 0;
            for (int i = 12; i < 21; i++)
            {
                int y = 0;
                for (int j = 0; j < 9; j++)
                {
                    Block2[x, y] = MainBlock[i, j];
                    y++;
                }
                x++;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(10);
            Solve(Block2);
            int a = 0;
            for (int i = 12; i < 21; i++)
            {
                int b = 0;
                for (int j = 0; j < 9; j++)
                {
                    MainBlock[i, j] = Block2[a, b];
                    b++;
                }
                a++;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static long SolveBlock3()
        {
            int x = 0;
            for (int i = 0; i < 9; i++)
            {
                int y = 0;
                for (int j = 12; j < 21; j++)
                {
                    Block3[x, y] = MainBlock[i, j];
                    y++;
                }
                x++;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(10);
            Solve(Block3);
            int a = 0;
            for (int i = 0; i < 9; i++)
            {
                int b = 0;
                for (int j = 12; j < 21; j++)
                {
                    MainBlock[i, j] = Block3[a, b];
                    b++;
                }
                a++;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static long SolveBlock4()
        {
            int x = 0;
            for (int i = 12; i < 21; i++)
            {
                int y = 0;
                for (int j = 12; j < 21; j++)
                {
                    Block4[x, y] = MainBlock[i, j];
                    y++;
                }
                x++;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(10);
            Solve(Block4);
            stopwatch.Stop();
            int a = 0;
            for (int i = 12; i < 21; i++)
            {
                int b = 0;
                for (int j = 12; j < 21; j++)
                {
                    MainBlock[i, j] = Block4[a, b];
                    b++;
                }
                a++;
            }
            return stopwatch.ElapsedMilliseconds;
        }

        public static long SolveBlockCenter()
        {
            int x = 0;
            for (int i = 6; i < 15; i++)
            {
                int y = 0;
                for (int j = 6; j < 15; j++)
                {
                    BlockCenter[x, y] = MainBlock[i, j];
                    y++;
                }
                x++;
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(10);
            Solve(BlockCenter);
            int a = 0;
            for (int i = 6; i < 15; i++)
            {
                int b = 0;
                for (int j = 6; j < 15; j++)
                {
                    MainBlock[i, j] = BlockCenter[a, b];
                    b++;
                }
                a++;
            }
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }


        public static bool Solve(int[,] Block)
        {
            
            for (int i = 0; i < Block.GetLength(0); i++)
            {
                for (int j = 0; j < Block.GetLength(1); j++)
                {
                    if (Block[i, j] == 0)
                    {
                        for (int c = 1; c <= 9; c++)
                        {

                            if (IsValid(Block, i, j, c))
                            {
                                Block[i, j] = c;

                                if (Solve(Block))

                                    return true;
                                else
                                    Block[i, j] = 0;
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool IsValid(int[,] Block, int Row, int Col, int C)
        {
            for (int i = 0; i < 9; i++)
            {
                
                if (Block[i, Col] != 0 && Block[i, Col] == C)
                    return false;
                
                if (Block[Row, i] != 0 && Block[Row, i] == C)
                    return false;
                
                if (Block[3 * (Row / 3) + i / 3, 3 * (Col / 3) + i % 3] != 0 && Block[3 * (Row / 3) + i / 3, 3 * (Col / 3) + i % 3] == C)
                    return false;
            }
            
            /*süreler cok fazla sarktıgı için ve grafikteki görüntüde bozulmalar olduğu için projede bu kısmı yorum satırına almak zorunda kaldık
            for (int a = 0; a < 9; a++)
            {
               
                for (int b = 0; b < 9; b++)
                {
                    Console.Write(Block[a,b] + " ");
                }
                Console.WriteLine();
            }*/
            return true;
        }

        public static DataTable SolveSudoku()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ThreadName");
            dt.Columns.Add("Interval", typeof(long));
            long Count1, Count2, Count3, Count4, Count5;
            Count1 = Count2 = Count3 = Count4 = Count5 = 0;
            Thread thread1 = new Thread(() => { Count1 = SolveBlock1(); });
            Thread thread2 = new Thread(() => { Count2 = SolveBlock2(); });
            Thread thread3 = new Thread(() => { Count3 = SolveBlock3(); });
            Thread thread4 = new Thread(() => { Count4 = SolveBlock4(); });
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
            Thread threadCenter = new Thread(() => { Count5 = SolveBlockCenter(); });
            threadCenter.Start();
            threadCenter.Join();

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "Tek Başlangıç Kutu İşlemi 1";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count1;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "Tek Başlangıç Kutu İşlemi 2";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count2;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "Tek Başlangıç Kutu İşlemi 3";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count3;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "Tek Başlangıç Kutu İşlemi 4";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count4;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "Tek Başlangıç Kutu İşlemi 5";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count5;

            SetSubBlock(Block1, 0, 9, 0, 9);
            SetSubBlock(Block2, 12, 21, 0, 9);
            SetSubBlock(Block3, 0, 9, 12, 21);
            SetSubBlock(Block4, 12, 21, 12, 21);
            SetSubBlock(BlockCenter, 6, 15, 6, 15);

            return dt;   
        }

        public static DataTable SolveSudoku2()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ThreadName");
            dt.Columns.Add("Interval", typeof(long));
            long Count1, Count2, Count3, Count4, Count5;
            Count1 = Count2 = Count3 = Count4 = Count5 = 0;
            Thread thread1 = new Thread(() => { Count1 = SolveBlock1(); });
            Thread thread2 = new Thread(() => { Count2 = SolveBlock2(); });
            Thread thread3 = new Thread(() => { Count3 = SolveBlock3(); });
            Thread thread4 = new Thread(() => { Count4 = SolveBlock4(); });
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
            Thread threadCenter = new Thread(() => { Count5 = SolveBlockCenter(); });
            threadCenter.Start();
            threadCenter.Join();

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 1";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count1;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 2";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count2;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 3";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count3;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 4";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count4;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 5";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count5;


            long Count11, Count22, Count33, Count44, Count55;
            Count11 = Count22 = Count33 = Count44 = Count55 = 0;
            Thread thread11 = new Thread(() => { Count11 = SolveBlock1(); });
            Thread thread22 = new Thread(() => { Count22 = SolveBlock2(); });
            Thread thread33 = new Thread(() => { Count33 = SolveBlock3(); });
            Thread thread44 = new Thread(() => { Count44 = SolveBlock4(); });
            thread33.Start();
            thread22.Start();
            thread44.Start();
            thread11.Start();
            thread11.Join();
            thread22.Join();
            thread33.Join();
            thread44.Join();
            Thread threadCenter2 = new Thread(() => { Count55 = SolveBlockCenter(); });
            threadCenter2.Start();
            threadCenter2.Join();

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 1";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count11;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 2";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count22;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 3";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count33;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 4";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count44;

            dt.Rows.Add(dt.NewRow());
            dt.Rows[dt.Rows.Count - 1]["ThreadName"] = "İki Başlangıç Kutu İşlemi 5";
            dt.Rows[dt.Rows.Count - 1]["Interval"] = Count55;

            SetSubBlock(Block1, 0, 9, 0, 9);
            SetSubBlock(Block2, 12, 21, 0, 9);
            SetSubBlock(Block3, 0, 9, 12, 21);
            SetSubBlock(Block4, 12, 21, 12, 21);
            SetSubBlock(BlockCenter, 6, 15, 6, 15);

            return dt;
        }
        public static void AddToDatabaseTekli(DataTable dt)
        {
            try
            {
                using (var con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SudokuVeriTabani.accdb"))
                {
                    con.Open();
                    

                    foreach (DataRow dr in dt.Rows)
                    {
                        var cmd = con.CreateCommand();
                        cmd.CommandText = "Insert into SudokuTekli (Tarih,IslemAdi,IslemSuresi) Values(Now(),@IslemAdi,@IslemSuresi)";
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@IslemAdi", dr["ThreadName"].ConvertToString());
                        cmd.Parameters.AddWithValue("@IslemSuresi", dr["Interval"].ConvertToInt());
                        cmd.ExecuteNonQuery();

                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AddToDatabaseIkili(DataTable dt)
        {
            try
            {
                using (var con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SudokuVeriTabani.accdb"))
                {
                    con.Open();
                    

                    foreach (DataRow dr in dt.Rows)
                    {
                        var cmd = con.CreateCommand();
                        cmd.CommandText = "Insert into SudokuIkili (Tarih,IslemAdi,IslemSuresi) Values(Now(),@IslemAdi,@IslemSuresi)";
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@IslemAdi", dr["ThreadName"].ConvertToString());
                        cmd.Parameters.AddWithValue("@IslemSuresi", dr["Interval"].ConvertToInt());
                        cmd.ExecuteNonQuery();

                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AddToDatabaseTamami(DataTable dt)
        {
            try
            {
                using (var con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SudokuVeriTabani.accdb"))
                {
                    con.Open();
                    
                    
                        foreach (DataRow dr in dt.Rows)
                        {
                            var cmd = con.CreateCommand();
                            cmd.CommandText = "Insert into SudokuTamami (Tarih,IslemAdi,IslemSuresi) Values(Now(),@IslemAdi,@IslemSuresi)";
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@IslemAdi", dr["ThreadName"].ConvertToString());
                            cmd.Parameters.AddWithValue("@IslemSuresi", dr["Interval"].ConvertToInt());
                            cmd.ExecuteNonQuery();
                            
                        }
                    
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
