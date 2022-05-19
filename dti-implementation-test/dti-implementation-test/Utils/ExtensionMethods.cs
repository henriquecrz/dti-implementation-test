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

        public static IPetShop GetBestPetShop(this IEnumerable<IPetShop> petShops) =>
            petShops
                .OrderBy(petShop => petShop.Amount)
                .ThenBy(petShop => petShop.Distance)
                .ToList()
                .FirstOrDefault();
    }
}
