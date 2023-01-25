using Lunar;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;

namespace Calendar
{
    public static class CalendarDrawer
    {
        // 黑色筆刷
        public static readonly Brush blackBrush = new SolidBrush(Color.Black);

        // 紅色筆刷
        public static readonly Brush redBrush = new SolidBrush(Color.Red);

        // 綠色筆刷
        public static readonly Brush greenBrush = new SolidBrush(Color.Green);

        // 字串置中
        public static readonly StringFormat centerStringFormat = new StringFormat()
        {
            Alignment = StringAlignment.Center
        };

        // 起始位置
        public const int START_XY = 10;

        // 終止 X 位置
        public const int END_X = 1875;

        // 終止 Y 位置
        public const int END_Y = 975;

        // 內部框線起始位置
        public const int INNER_START_XY = 50;

        // 日期文字起始位置
        public const int DAY_START_X = 122;

        // 日期 X 間隔
        public const int DAY_SPACE_X = 48;

        // 月份 X 位置
        public const int MONTH_X = 55;

        // 月份 Y 間隔
        public const int MONTH_SPACE_Y = 77;

        // 月份數量
        public const int MONTH_COUNT = 12;

        // 每月格數
        public const int DAY_COUNT = 37;

        // 每星期天數
        public const int WEEK_DAY_COUNT = 7;

        // 字型名稱
        public const string FONT_NAME = "Microsoft JhengHei";

        // 月份水平線間隔
        public static int getMonthSpace(int month)
        {
            return INNER_START_XY + MONTH_SPACE_Y * month;
        }

        public static void drawCalendar(Graphics graphic, int year, int[] monthOffset = null, bool today = false, bool catAsRabbitYear = false)
        {
            Contract.Requires(monthOffset == null || monthOffset.Length == MONTH_COUNT);

            #region 底色

            const int BACKGROUND_COLOR_END_X = END_X - START_XY;
            Brush[] seasonBrush =
            {
                new SolidBrush(Color.FromArgb(255, 200, 215, 180)), // 綠
                new SolidBrush(Color.FromArgb(255, 230, 190, 200)), // 紅
                new SolidBrush(Color.FromArgb(255, 240, 230, 180)), // 黃
                new SolidBrush(Color.FromArgb(255, 200, 215, 225)) // 藍
            };
            int seasonCount = seasonBrush.Length;
            for (int i = 0, startY = START_XY; i < seasonCount; ++i)
            {
                int sizeY = getMonthSpace((i + 1) * 3) - startY;
                graphic.FillRectangle(seasonBrush[i], new Rectangle(START_XY, startY, BACKGROUND_COLOR_END_X, sizeY));
                startY += sizeY + 1;
            }

            #endregion 底色

            #region 外部框線

            const int OUTER_BORDER_WIDTH = 5;
            Pen borderPen = new Pen(Color.FromArgb(255, 40, 60, 95), OUTER_BORDER_WIDTH);
            graphic.DrawLine(borderPen, new Point(START_XY, START_XY), new Point(END_X, START_XY)); // 上橫線
            graphic.DrawLine(borderPen, new Point(START_XY, START_XY - 2), new Point(START_XY, END_Y + 3)); // 左直線

            graphic.DrawLine(borderPen, new Point(END_X, START_XY - 2), new Point(END_X, END_Y + 3)); // 右直線
            graphic.DrawLine(borderPen, new Point(START_XY, END_Y), new Point(END_X, END_Y)); // 下橫線

            #endregion 外部框線

            #region 內部框線

            const int INNER_BORDER_WIDTH = 2;
            Pen innerBorderPen = new Pen(Color.Black, INNER_BORDER_WIDTH);

            // 橫線
            graphic.DrawLine(innerBorderPen, new Point(START_XY, INNER_START_XY), new Point(END_X, INNER_START_XY));
            for (int i = 1; i < MONTH_COUNT; ++i)
            {
                int space = getMonthSpace(i);
                graphic.DrawLine(innerBorderPen, new Point(START_XY, space), new Point(END_X, space));
            }

            // 直線
            for (int i = 1; i <= DAY_COUNT; ++i)
            {
                int space = INNER_START_XY + DAY_SPACE_X * i;
                graphic.DrawLine(innerBorderPen, new Point(space, START_XY), new Point(space, END_Y));
            }

            #endregion 內部框線

            #region 年次、星期

            Font weekDayFont = new Font(FONT_NAME, 10.5F, FontStyle.Bold);
            Lunar.Lunar newYear = Lunar.Lunar.FromYmdHms(year, 1, 1);
            const int WEEK_Y = 21;

            string zodiac = newYear.YearShengXiao;
            if (catAsRabbitYear && zodiac == "兔")
            {
                zodiac = "貓";
            }
            graphic.DrawString(Util.CHSToCHT($"{newYear.YearInGanZhi}．{zodiac}年"), weekDayFont, blackBrush, MONTH_X, WEEK_Y, centerStringFormat);

            const string WEEK = "六日一二三四五";
            for (int i = 0; i < DAY_COUNT; ++i)
            {
                int index = i % WEEK_DAY_COUNT;
                Brush brush = index < 2 ? redBrush : blackBrush;
                graphic.DrawString($"星期{WEEK[index]}", weekDayFont, brush, DAY_START_X + DAY_SPACE_X * i, WEEK_Y, centerStringFormat);
            }

            #endregion 年次、星期

            #region 月份

            Brush[] monthBrush = {
                new SolidBrush(Color.FromArgb(255, 25, 60, 20)), // 綠
                redBrush, // 紅
                new SolidBrush(Color.FromArgb(255, 35, 65, 145)), // 藍
                blackBrush // 黑
            };
            Font monthFont = new Font(FONT_NAME, 48, FontStyle.Bold);
            for (int i = 0; i < MONTH_COUNT; ++i)
            {
                graphic.DrawString((i + 1).ToString(), monthFont, monthBrush[i / 3], MONTH_X, 43 + MONTH_SPACE_Y * i, centerStringFormat);
            }

            #endregion 月份

            #region 日期

            Font dayFont = new Font(FONT_NAME, 24, FontStyle.Bold);
            Font lunarFont = new Font(FONT_NAME, 11.5F, FontStyle.Bold);
            for (int i = 0; i < MONTH_COUNT; ++i)
            {
                int month = i + 1;
                DateTime firstDay = new DateTime(year, month, 1);
                int offset = ((int)firstDay.DayOfWeek + 1) % WEEK_DAY_COUNT;
                if (monthOffset != null)
                {
                    monthOffset[i] = offset;
                }

                int count = DateTime.DaysInMonth(year, month);
                for (int day = 1, j = offset; day <= count; ++day, ++j, offset = j % WEEK_DAY_COUNT)
                {
                    Solar solar = Solar.FromYmdHms(year, month, day);
                    Lunar.Lunar lunar = solar.Lunar;

                    IList<string> outputList = new List<string>();
                    string lunarDay = Util.CHSToCHT(lunar.DayInChinese);
                    int lunarDayNumber = lunar.Day;
                    if (lunarDayNumber == 1)
                    {
                        lunarDay = $"{Util.CHSToCHT(lunar.MonthInChinese)}月";
                        if (lunarDay.Length < 3)
                        {
                            if (count > 30)
                            {
                                lunarDay += "大";
                            }
                            else
                            {
                                lunarDay += "小";
                            }
                        }
                    }
                    else if (lunarDayNumber > 10)
                    {
                        lunarDay += "日";
                    }
                    else
                    {
                        lunarDay = lunarDay.Insert(1, Util.SPACE);
                    }
                    outputList.Add(lunarDay);

                    (string, bool) festival = queryFestival(solar, lunar);
                    string solarTerm = Util.CHSToCHT(lunar.JieQi);
                    if (!string.IsNullOrWhiteSpace(solarTerm))
                    {
                        if (solarTerm == "清明")
                        {
                            festival.Item2 = true;
                        }
                        outputList.Add(solarTerm);
                    }
                    string festivalName = festival.Item1;
                    if (!string.IsNullOrWhiteSpace(festivalName))
                    {
                        outputList.Add(festivalName);
                    }

                    Brush brush = offset < 2 || festival.Item2 ? redBrush : blackBrush;
                    graphic.DrawString(day.ToString(), dayFont, today && isToday(year, month, day) ? greenBrush : brush, DAY_START_X + DAY_SPACE_X * j, 45 + MONTH_SPACE_Y * i, centerStringFormat);
                    int outputCount = outputList.Count;
                    for (int k = 0; k < outputCount; ++k)
                    {
                        string output = outputList[k];
                        if (output.Length < 3)
                        {
                            output = output.Insert(1, Util.SPACE);
                        }
                        graphic.DrawString(output, lunarFont, brush, DAY_START_X + DAY_SPACE_X * j, 77 + MONTH_SPACE_Y * i + 15 * k, centerStringFormat);
                    }
                }
            }

            #endregion 日期
        }

        public static bool isToday(int year, int month, int day)
        {
            DateTime now = Program.now;
            return year == now.Year && month == now.Month && day == now.Day;
        }

        private static (string, bool) queryFestival(Solar solar, Lunar.Lunar lunar)
        {
            if (solar.Festivals.Count > 0)
            {
                string festival = Util.CHSToCHT(solar.Festivals[0]);
                switch (festival)
                {
                    case "母親節":
                        {
                            return (festival, true);
                        }
                    case "感恩節":
                        {
                            return (festival, false);
                        }
                }
            }

            Date? result = Festival.getFestival(CalendarType.Solar, solar.Month, solar.Day);
            if (result.HasValue)
            {
                Date ret = result.Value;
                return (ret.festival, ret.festivalHoliday);
            }

            result = Festival.getFestival(CalendarType.Lunar, lunar.Month, lunar.Day);
            if (result.HasValue)
            {
                Date ret = result.Value;
                return (ret.festival, ret.festivalHoliday);
            }
            return (null, false);
        }
    }
}