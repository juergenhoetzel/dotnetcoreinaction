using System;

namespace BusinessDays
{
  public class WeekendRule : IRule
  {
    public bool CheckDate(DateTime date)
    {
      return
        date.DayOfWeek != DayOfWeek.Saturday &&
        date.DayOfWeek != DayOfWeek.Sunday;
    }
  }
}
