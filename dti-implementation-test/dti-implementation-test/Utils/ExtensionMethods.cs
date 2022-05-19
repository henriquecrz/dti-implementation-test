using System;

namespace dti_implementation_test.Utils
{
    public static class ExtensionMethods
    {
        public static bool IsWeekend(this DateTime dateTime) =>
            dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday;
    }
}
