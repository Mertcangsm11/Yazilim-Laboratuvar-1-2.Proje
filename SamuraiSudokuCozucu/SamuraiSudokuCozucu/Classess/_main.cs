using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamuraiSudokuCozucu.Classess;

namespace SamuraiSudokuCozucu
{
    class _main
    {
        
    }

    public static class ext
    {
        public static bool In(this string source, params string[] list)
        {
            bool ret = false;
            try
            {
                if (source.IsNotNullOrWhiteSpace() && list.Length > 0)
                    ret = list.Contains(source.Trim(), StringComparer.OrdinalIgnoreCase);
            }
            catch { }
            return ret;
        }

        public static bool In(this int source, params int[] list)
        {
            bool ret = false;
            try
            {
                if (source.IsNotNullOrWhiteSpace() && list.Length > 0)
                    ret = list.Contains(source);
            }
            catch { }
            return ret;
        }

        public static bool IsNullOrWhiteSpace(this object obj)
        {
            return string.IsNullOrWhiteSpace(obj.ConvertToString());
        }

        public static bool IsNotNullOrWhiteSpace(this object obj)
        {
            return !string.IsNullOrWhiteSpace(obj.ConvertToString());
        }
        public static int ConvertToInt(this object obj)
        {
            int ret = 0;
            if (obj != null)
                int.TryParse(obj.ToString(), out ret);
            return ret;
        }
        public static string ConvertToString(this object obj)
        {
            return obj == null ? string.Empty : obj.ToString();
        }
    }
}
