using Application;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Utils
{
    public static class ExtensionMethods
    {
        public static bool IsWeekend(this DateTime dateTime) =>
            dateTime.DayOfWeek == DayOfWeek.Sunday || dateTime.DayOfWeek == DayOfWeek.Saturday;

        public static IPetshop GetBestPetshop(this IEnumerable<IPetshop> petshops) =>
            petshops
                .OrderBy(petshop => petshop.Amount)
                .ThenBy(petshop => petshop.Distance)
                .ToList()
                .FirstOrDefault();
    }
}
