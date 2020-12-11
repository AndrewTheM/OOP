using System;

namespace DateDiff
{
    public class DateModifier
    {
        public int DifferenceInDays { get; private set; }

        public void UpdateStoredDaysBetween(string dateStr1, string dateStr2)
        {
            DifferenceInDays = Math.Abs((DateTime.Parse(dateStr1) - DateTime.Parse(dateStr2)).Days);
        }
    }
}
