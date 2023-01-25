using System.Collections.Generic;

namespace Calendar
{
    public enum CalendarType
    {
        Solar,
        Lunar
    }

    public struct Date
    {
        public CalendarType type;
        public bool festivalHoliday;
        public int month, day;
        public string festival;
    }

    public static class Festival
    {
        private static readonly IList<Date> festival = new List<Date>()
        {
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = true,
                month = 1,
                day = 1,
                festival = "元旦"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = true,
                month = 12,
                day = 29,
                festival = "小年夜"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = true,
                month = 12,
                day = 30,
                festival = "除夕"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = true,
                month = 1,
                day = 1,
                festival = "年初一"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = true,
                month = 1,
                day = 2,
                festival = "年初二"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = true,
                month = 1,
                day = 3,
                festival = "年初三"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = false,
                month = 1,
                day = 15,
                festival = "元宵節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 2,
                day = 14,
                festival = "情人節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = true,
                month = 2,
                day = 28,
                festival = "和平日"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 3,
                day = 8,
                festival = "婦女節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 3,
                day = 12,
                festival = "植樹節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 3,
                day = 29,
                festival = "青年節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 4,
                day = 1,
                festival = "愚人節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = true,
                month = 4,
                day = 4,
                festival = "兒童節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 4,
                day = 9,
                festival = "復活節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 4,
                day = 22,
                festival = "地球日"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 5,
                day = 1,
                festival = "勞動節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 5,
                day = 12,
                festival = "護師節"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = true,
                month = 5,
                day = 5,
                festival = "端午節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 8,
                day = 8,
                festival = "父親節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 8,
                day = 14,
                festival = "空軍節"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = false,
                month = 7,
                day = 7,
                festival = "七夕"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = false,
                month = 7,
                day = 15,
                festival = "中元節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 9,
                day = 3,
                festival = "軍人節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 9,
                day = 28,
                festival = "教師節"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = true,
                month = 8,
                day = 15,
                festival = "中秋節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = true,
                month = 10,
                day = 10,
                festival = "國慶日"
            },
            new Date()
            {
                type = CalendarType.Lunar,
                festivalHoliday = false,
                month = 9,
                day = 9,
                festival = "重陽節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 10,
                day = 25,
                festival = "光復節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 10,
                day = 31,
                festival = "萬聖節"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 12,
                day = 24,
                festival = "平安夜"
            },
            new Date()
            {
                type = CalendarType.Solar,
                festivalHoliday = false,
                month = 12,
                day = 25,
                festival = "聖誕節"
            }
        };

        private static readonly IDictionary<string, Date> cache = new Dictionary<string, Date>();

        static Festival()
        {
            foreach (Date date in festival)
            {
                cache.Add(convertKey(date.type, date.month, date.day), date);
            }
        }

        private static string convertKey(CalendarType type, int month, int day)
        {
            return $"{(type == CalendarType.Solar ? "S" : "L")}{prepend(month)}{prepend(day)}";
        }

        private static string prepend(int day)
        {
            string ret = day.ToString();
            if (ret.Length < 2)
            {
                ret = $"0{ret}";
            }
            return ret;
        }

        public static Date? getFestival(CalendarType type, int month, int day)
        {
            string key = convertKey(type, month, day);
            if (cache.ContainsKey(key))
            {
                return cache[key];
            }
            return null;
        }
    }
}