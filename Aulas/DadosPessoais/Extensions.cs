using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoais
{
    public static class Extensions
    {
        public static string ToSizeString(this long originalSize)
        {
            long KB = 1024;
            long MB = KB * 1024;
            long GB = MB * 1024;
            long TB = GB * 1024;
            double size = originalSize;

            if (size >= TB)
            {
                size = Math.Round((double)originalSize / TB, 2);
                return $"{size} TB";
            }
            else if (size >= GB)
            {
                size = Math.Round((double)originalSize / GB, 2);
                return $"{size} GB";
            }
            else if (size >= MB)
            {
                size = Math.Round((double)originalSize / MB, 2);
                return $"{size} MB";
            }
            else
            {
                size = Math.Round((double)originalSize / KB, 2);
                return $"{size} KB";
            }
        }
    }
}
