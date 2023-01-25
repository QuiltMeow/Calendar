using Microsoft.International.Converters.TraditionalChineseToSimplifiedConverter;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar
{
    public static class Util
    {
        public const string SPACE = " ";

        public static string CHSToCHT(string input)
        {
            return ChineseConverter.Convert(input, ChineseConversionDirection.SimplifiedToTraditional);
        }

        public static string CHTToCHS(string input)
        {
            return ChineseConverter.Convert(input, ChineseConversionDirection.TraditionalToSimplified);
        }

        public static string getRoCYear(int ADyear)
        {
            int ret = ADyear - 1911;
            if (ret <= 0)
            {
                return $"中華民國前 {Math.Abs(ret - 1)} 年";
            }
            return $"中華民國 {ret} 年";
        }

        public static string getFullSpace(int count)
        {
            return new string('　', count);
        }

        public static Image saveControlImage(Control control)
        {
            Size size = control.ClientSize;
            Bitmap ret = new Bitmap(size.Width, size.Height);
            control.DrawToBitmap(ret, control.ClientRectangle);
            return ret;
        }

        public static string getYearTitle(int year)
        {
            const int space = 130;
            return $"{getRoCYear(year)}{getFullSpace(space)}{year}";
        }
    }
}