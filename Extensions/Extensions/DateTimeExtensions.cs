using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Extensions.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToAMPMFormat(this DateTime input)
        {
            return input.ToString("hh:mm tt");
        }

        public static bool IsBetween(this DateTime time,DateTime startDate,DateTime EndDate)
        {
            return time.Ticks >= startDate.Ticks && time.Ticks <= EndDate.Ticks;
        }

        public static DateTime Tommarow(this DateTime time)
        {
            return time.AddDays(1);
        }
        public static DateTime Yesterday(this DateTime time)
        {
            return time.AddDays(-1);
        }

        public static DateTime FirstDayofWeek(this DateTime date)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            DayOfWeek firstDay = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            DateTime firstDayInWeek = date.Date;
            while (firstDayInWeek.DayOfWeek != firstDay)
                firstDayInWeek = firstDayInWeek.AddDays(-1);

            return firstDayInWeek;
        }
        public static DateTime LastDayofWeek(this DateTime date)
        {
            return date.FirstDayofWeek().AddDays(6);
        }

    }
}
