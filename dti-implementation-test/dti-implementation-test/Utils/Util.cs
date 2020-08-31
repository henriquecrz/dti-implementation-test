using System;

namespace dti_implementation_test.Utils
{
    public class Util
    {
        public static bool IsWeekend(DateTime dateTime) => dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday;
    }
}
