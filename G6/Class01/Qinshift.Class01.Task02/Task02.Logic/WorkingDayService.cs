namespace Task02.Logic
{
    public class WorkingDayService
    {
        private readonly List<DateTime> NonWorkingDays = new List<DateTime>
        {
            new DateTime(DateTime.Now.Year, 1, 1),   // January 1
            new DateTime(DateTime.Now.Year, 1, 7),   // January 7
            new DateTime(DateTime.Now.Year, 4, 20),  // April 20
            new DateTime(DateTime.Now.Year, 5, 1),   // May 1
            new DateTime(DateTime.Now.Year, 5, 25),  // May 25
            new DateTime(DateTime.Now.Year, 8, 3),   // August 3
            new DateTime(DateTime.Now.Year, 9, 8),   // September 8
            new DateTime(DateTime.Now.Year, 10, 12), // October 12
            new DateTime(DateTime.Now.Year, 10, 23), // October 23
            new DateTime(DateTime.Now.Year, 12, 8),  // December 8
        };

        public bool IsWorkingDay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            foreach (var nonWorkingDay in NonWorkingDays)
            {
                if (date.Day == nonWorkingDay.Day && date.Month == nonWorkingDay.Month)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
