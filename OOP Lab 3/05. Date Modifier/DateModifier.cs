using System;
using System.Collections.Generic;
using System.Text;

namespace DateDiff
{
    public class DateModifier
    {
        public int DaysBetween(string dateStr1, string dateStr2)
        {
            return Math.Abs((DateTime.Parse(dateStr1) - DateTime.Parse(dateStr2)).Days);
        }
    }
}
