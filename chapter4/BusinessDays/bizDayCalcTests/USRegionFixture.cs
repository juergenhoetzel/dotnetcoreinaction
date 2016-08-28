using BusinessDays;
using Xunit;

namespace BusinessDaysTest
{
  public class USRegionFixture
  {
    public BizDayCalc Calculator { get; private set; }

    public USRegionFixture()
    {
      Calculator = new BizDayCalc();
      Calculator.AddRule(WeekendRule.CheckDate);
      Calculator.AddRule(HolidayRule.CheckDate);
    }
  }

  [CollectionDefinition("US region collection")]
  public class USRegionCollection : ICollectionFixture<USRegionFixture> {}
}
