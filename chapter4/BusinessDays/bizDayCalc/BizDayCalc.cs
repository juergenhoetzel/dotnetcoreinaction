using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessDays
{
  public class BizDayCalc
  {
    private List<Func<DateTime,bool>> workDayPredicates = new List<Func<DateTime,bool>>();

    public void AddRule(Func<DateTime,bool> datePredicate) {
        workDayPredicates.Add(datePredicate);
    }

    public bool IsBusinessDay(DateTime date) => workDayPredicates.All(p => p(date));
  }
}
