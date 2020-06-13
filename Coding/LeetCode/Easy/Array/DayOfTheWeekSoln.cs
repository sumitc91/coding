using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AskGif.Easy.Array
{
    public class DayOfTheWeekSoln
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            var date = new DateTime(year, month, day);
            return date.DayOfWeek.ToString();
        }
    }
}
