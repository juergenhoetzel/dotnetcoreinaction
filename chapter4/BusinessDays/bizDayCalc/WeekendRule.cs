using System;

namespace BusinessDays
{
  public class WeekendRule
  {
    public static bool CheckDate(DateTime date) =>
        date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
  }
}

