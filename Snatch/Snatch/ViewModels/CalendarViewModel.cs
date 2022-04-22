using Snatch.Models;
using Snatch.Services.ChineseCalendar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Snatch.ViewModels
{
    class CalendarViewModel : BaseViewModel
    {
        public CalendarViewModel()
        {
            var calendar = new CalendarService(_calendar, DateTime.Now);
        }

        public async IAsyncEnumerable<(DateTime datetime, CalendarItem[] collection)> GetSexagenaryAsync(DateTime targetDate, int daysCount)
        {

            var dates = GetDates(targetDate, targetDate.AddDays(daysCount));
            foreach (var date in dates)
            {
                var dateTime = new CalendarService(_calendar, DateTime.Now);
                var chineseYear = dateTime.GetYearInfoAsync();
                var chineseMonth = dateTime.GetMonthInfoAsync(() => chineseYear);
                var chineseDay = dateTime.GetDayInfoAsync();

                var tasks = new List<Task<CalendarItem>>()
                {
                    chineseYear,
                    chineseMonth,
                    chineseDay
                };
                var taskResults = await Task.WhenAll(tasks).ConfigureAwait(false);
                yield return (date, taskResults);
            }
        }

        private static IEnumerable<DateTime> GetDates(DateTime start, DateTime finish)
        {
            for (var day = start; day < finish; day = day.AddDays(1))
            {
                yield return day;
            }
        }
    }
}
