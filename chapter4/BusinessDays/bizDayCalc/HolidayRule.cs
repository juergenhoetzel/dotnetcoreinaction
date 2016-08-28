using System;
using System.Linq;
using System.Collections.Generic;

namespace BusinessDays
{
  public class HolidayRule
  {
    public static List<Tuple<int,int>>  USHolidays = new List<Tuple<int,int>>() {
        Tuple.Create(1, 1),
        Tuple.Create(7, 4),
        Tuple.Create(12, 24),
        Tuple.Create(12, 25)
    };

    public static bool CheckDate(DateTime date) => !USHolidays.Any(t => t.Item1 == date.Month
                                                            && t.Item2 == date.Day);
  }
}
